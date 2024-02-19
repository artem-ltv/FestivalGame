using UnityEngine;

namespace Festival
{
    public class HealthMagic : MonoBehaviour
    {
        [SerializeField] private PlayerHealth _health;
        [SerializeField] private int _healthPoint;

        public void AddHealthToPlayer()
        {
            _health.Add(_healthPoint);
        }
    }
}
