using UnityEngine;
using UnityEngine.EventSystems;

namespace Festival
{
    public class MeteoriteMagic : MonoBehaviour
    {
        [SerializeField] private AimmingMouse _aimming;

        private bool _isUsing = false;

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
            Vector3 mousePosition = _aimming.GetAimCoordinates();
            _isUsing = false;
            Debug.Log("SummonMeteorit");
        }
    }
}
