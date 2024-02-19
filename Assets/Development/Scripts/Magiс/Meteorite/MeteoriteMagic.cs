using UnityEngine;
using UnityEngine.EventSystems;

namespace Festival
{
    public class MeteoriteMagic : MonoBehaviour
    {
        [SerializeField] private MouseAiming _aiming;
        [SerializeField] private Meteorite _meteorite;

        private float _spawnHeight = 5f;

        private void Update()
        {
            if (_aiming.IsAiming)
            {
                if(Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
                {
                    Create();
                    _aiming.SetVisibility(false);
                }
            }
        }

        public void Aim()
        {
            _aiming.SetVisibility(true);
        }

        private void Create()
        {
            Vector3 creationPoint = _aiming.GetHitCoordinates();
            creationPoint.y += _spawnHeight;

            Meteorite newMeteorite = Instantiate(_meteorite, creationPoint, Quaternion.identity);
            newMeteorite.Initialize(_spawnHeight);
            newMeteorite.Fall();
        }
    }
}
