using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovement _playerMovement;
        [SerializeField]private bool _isGround;

        private void Start()
        {
            _playerMovement = GetComponent<PlayerMovement>();
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
        }
    }
}

