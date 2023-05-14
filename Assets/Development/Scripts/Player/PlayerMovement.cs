using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Festival
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed;

        public void Rotate(Vector3 direction)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * _rotationSpeed);
        }
    }
}
