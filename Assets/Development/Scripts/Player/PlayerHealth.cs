using UnityEngine;

namespace Festival
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int _health;

        private int _maxHealth = 100;

        private void AddDamage(int damage)
        {
            _health -= damage;
            if(_health <= 0)
            {
                Die();
            }
        }

        private void AddHealth(int health)
        {
            _health += health;
            if(_health >= _maxHealth)
            {
                _health = _maxHealth;
            }
        }

        private void Die()
        {
            //
        }
    }
}
