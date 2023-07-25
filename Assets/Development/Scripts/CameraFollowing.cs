using UnityEngine;

namespace Festival
{
    public class CameraFollowing : MonoBehaviour
    {
        [SerializeField] private Transform _player;
        [SerializeField] private float _cameraSpeed;
        [SerializeField] private float _offsetX;
        [SerializeField] private float _offsetZ;

        private Vector3 _targetPosition;

        private void LateUpdate()
        {
            _targetPosition = new Vector3(_player.transform.position.x + _offsetX, transform.position.y, _player.transform.position.z + _offsetZ);
            transform.position = Vector3.Lerp(transform.position, _targetPosition, _cameraSpeed * Time.deltaTime);
        }
    }
}
