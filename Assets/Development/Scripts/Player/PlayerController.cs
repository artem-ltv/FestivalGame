using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovement _playerMovement;

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(-horizontal, 0f, -vertical);
            _playerMovement.Rotate(direction);

            //Quaternion rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * _rotationSpeed);


            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * _rotationSpeed);
            //_rigidbody.velocity = Vector3.ClampMagnitude(direction, 1) * _moveSpeed;
        }
    }
}
