using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerAnimatorController))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMovement _playerMovement;
        private PlayerAnimatorController _animatorController;

        private void Start()
        {
            _playerMovement = GetComponent<PlayerMovement>();
            _animatorController = GetComponent<PlayerAnimatorController>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(horizontal, 0f, vertical);

            if(direction != Vector3.zero)
            {
                _playerMovement.Rotate(direction);
                _playerMovement.Move(direction);
            }
            else
            {
                _playerMovement.Stop();
            }

            _animatorController.ActivateRun(Mathf.Abs(horizontal + vertical));
        }
    }
}

