using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeedStart;
        [SerializeField] private float _moveSpeeding;
        [SerializeField] private float _rotateSpeed;
        [SerializeField] private PlayerHealth _playerHealth;

        private Rigidbody _rigidbody;
        private float _moveSpeed;
        private int _accelerationDamage = 1;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _moveSpeed = _moveSpeedStart;
        }

        public void Move(Vector3 direction)
        {
            _rigidbody.velocity = Vector3.ClampMagnitude(direction, 1) * _moveSpeed;
        }

        public void Rotate(Vector3 direction)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * _rotateSpeed);
        }

        public void Stop()
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
        }

        public void Speeding(bool isSpeeding)
        {
            if (isSpeeding)
            {
                _moveSpeed = _moveSpeeding;
                _playerHealth.AddDamage(_accelerationDamage);
            }
            else
            {
                _moveSpeed = _moveSpeedStart;
            }
        }
    }
}
