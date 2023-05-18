using UnityEngine;

namespace Festival
{
    public class AimmingMouse : MonoBehaviour
    {
        [SerializeField] private GameObject _aim;
        [SerializeField] private LayerMask _layerMask;

        private Camera _camera;
        private bool _isVisible;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (_isVisible)
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, _layerMask))
                {
                    _aim.transform.position = hit.point;
                }
            }
        }

        private void SetVisibility(bool isVisible)
        {
            _isVisible = isVisible;
        }
    }
}
