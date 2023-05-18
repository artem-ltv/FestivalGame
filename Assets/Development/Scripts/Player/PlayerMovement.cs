using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _jumpForce;

        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Rotate(Vector3 direction)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * _rotationSpeed);
        }

        public void Move(Vector3 direction)
        {
            _rigidbody.velocity = Vector3.ClampMagnitude(direction, 1) * _moveSpeed;
        }

        public void Jump()
        {
            _rigidbody.velocity = new Vector3(0f, _jumpForce, 0f);
        }

        public void Stop()
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
        }
    }
}