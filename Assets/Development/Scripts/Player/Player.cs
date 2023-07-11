using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerHealth))]

    public class Player : MonoBehaviour
    {
        private PlayerInput _input;
        private PlayerMovement _movement;
        private PlayerHealth _healht;

        private void Awake()
        {
            _input = GetComponent<PlayerInput>();
            _movement = GetComponent<PlayerMovement>();
            _healht = GetComponent<PlayerHealth>();
        }

        private void OnEnable()
        {
            _healht.Dying += DisableComponents;
        }

        private void OnDisable()
        {
            _healht.Dying -= DisableComponents;
        }

        private void DisableComponents()
        {
            _input.enabled = false;
            _movement.enabled = false;
        }
    }
}
