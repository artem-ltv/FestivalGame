using UnityEngine;
using UnityEngine.EventSystems;

namespace Festival
{
    public class MeteoriteMagic : ObjectPool
    {
        [SerializeField] private AimmingMouse _aimming;
        [SerializeField] private Meteorite _meteorite;

        private float _heightSpawnMeteorite = 5f;
        private bool _isUsing = false;

        private void Start()
        {
            Initialize(_meteorite);
        }

        private void Update()
        {
            if (_aimming.IsAimming)
            {
                if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
                {
                    SummonMeteorite();
                    _aimming.SetVisibility(false);
                }
            }
        }

        public void ClickButtonUsingMagic()
        {
            _isUsing = !_isUsing;
            Aim(_isUsing);
        }

        private void Aim(bool isAimming)
        {
            _aimming.SetVisibility(isAimming);
        }

        private void SummonMeteorite()
        {
            _isUsing = false;

            Vector3 aimCoordinates = _aimming.GetAimCoordinates();
            Vector3 meteoriteSpawnPoint = new Vector3(aimCoordinates.x, aimCoordinates.y + _heightSpawnMeteorite, aimCoordinates.z);

            if(TryGetObject(out Meteorite meteorite))
            {
                SetMeteorite(meteorite, meteoriteSpawnPoint);
            }
        }

        private void SetMeteorite(Meteorite meteorite, Vector3 spawnPoint)
        {
            meteorite.gameObject.SetActive(true);
            meteorite.transform.position = spawnPoint;
            meteorite.Initialize(_heightSpawnMeteorite);
            meteorite.Fall();
        }
    }
}
