using UnityEngine;

namespace Festival
{
    public class Aiming : MonoBehaviour
    {
        public bool IsAiming => _isVisible;

        [SerializeField] private Camera _camera;
        [SerializeField] private GameObject _aim;
        [SerializeField] private LayerMask _layerMask;

        private bool _isVisible = false;
        private float _offsetY = 0.05f;

        private RaycastHit _hit;

        private void Update()
        {
            if (_isVisible)
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out _hit, float.MaxValue, _layerMask))
                {
                    _aim.transform.position = new Vector3(_hit.point.x, _hit.point.y + _offsetY, _hit.point.z);
                }
            }
        }

        public void SetVisibility(bool isVisible)
        {
            _isVisible = isVisible;
            _aim.SetActive(isVisible);
        }

        public Vector3 GetHitCoordinates()
        {
            return _hit.point;
        }
    }
}
