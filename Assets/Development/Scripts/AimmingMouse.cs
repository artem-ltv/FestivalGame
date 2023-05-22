using UnityEngine;

namespace Festival
{
    public class AimmingMouse : MonoBehaviour
    {
        public bool IsAimming => _isVisible;

        [SerializeField] private GameObject _aim;
        [SerializeField] private LayerMask _layerMask;

        private float _aimOffsetY = 0.05f;

        private Camera _camera;
        private bool _isVisible;
        private RaycastHit _hit;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (_isVisible)
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out _hit, float.MaxValue, _layerMask))
                {
                    _aim.transform.position = new Vector3(_hit.point.x, _hit.point.y + _aimOffsetY, _hit.point.z);
                }
            }
        }

        public void SetVisibility(bool isVisible)
        {
            _isVisible = isVisible;
            _aim.SetActive(isVisible);
        }

        public Vector3 GetAimCoordinates()
        {
            return _hit.point;
        }
    }
}
