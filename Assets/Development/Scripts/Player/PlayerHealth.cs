using UnityEngine;
using UnityEngine.Events;

namespace Festival
{
    public class PlayerHealth : MonoBehaviour
    {
        public event UnityAction PlayerDiedEvent;
        public event UnityAction<int> ChangedEvent;

        [SerializeField] private int _currentHealth;

        private int _maxHealth = 100;

        public void Add(int health)
        {
            if(health <= 0)
            {
                return;
            }

            _currentHealth += health;

            if(_currentHealth >= _maxHealth)
            {
                _currentHealth = _maxHealth;
            }

            ChangedEvent?.Invoke(_currentHealth);
        }

        public void AddDamage(int damage)
        {
            if(damage <= 0)
            {
                return;
            }

           _currentHealth -= damage;

           if(_currentHealth <= 0)
           {
                _currentHealth = 0;
                Die();
           }

            ChangedEvent?.Invoke(_currentHealth);
        }

        private void Die()
        {
            PlayerDiedEvent?.Invoke();
            Debug.Log("Player died");
        }
    }
}
