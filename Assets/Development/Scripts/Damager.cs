using UnityEngine;
using UnityEngine.Events;

namespace Festival
{
    public class Damager : MonoBehaviour
    {
        public UnityAction Damaging;

        private int _damage;

        public void SetDamage(int damage)
        {
            _damage = damage;
        }

        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerHealth playerHealth))
            {
                Damaging?.Invoke();
                playerHealth.AddDamage(_damage);
            }
        }
    }
}
