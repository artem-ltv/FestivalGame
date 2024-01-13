using UnityEngine;

namespace Festival
{
    public class CameraTracking : MonoBehaviour
    {
        [SerializeField] private Transform _player;
        [SerializeField] private Vector3 _offset;
        [SerializeField] private float _moveSpeed;

        private Vector3 _targetPosition;

        private void LateUpdate()
        {
            _targetPosition = new Vector3(_player.position.x + _offset.x, _player.position.y + _offset.y, _player.position.z + _offset.z);
            transform.position = Vector3.Lerp(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
        }
    }
}
