using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMovement _movement;

        private void Start()
        {
            _movement = GetComponent<PlayerMovement>();
        }

        private void FixedUpdate()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(horizontal, 0, vertical);

            if(direction != Vector3.zero)
            {
                _movement.Move(direction);
                _movement.Rotate(direction);
            }
            else
            {
                _movement.Stop();
            }
        }
    }
}
