using UnityEngine;
using UnityEngine.Events;

namespace Festival
{
    public class PlayerHealth : MonoBehaviour
    {
        public event UnityAction Dying;

        [SerializeField] private int _health;
        
        public void AddDamage(int damage)
        {
            if(damage > 0)
            {
                _health -= damage;

                if(_health <= 0)
                {
                    Die();
                }
            }
        }

        private void Die()
        {
            Dying?.Invoke();
            Debug.Log("Player died");
        }
    }
}
