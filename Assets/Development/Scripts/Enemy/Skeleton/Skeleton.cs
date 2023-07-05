using UnityEngine;

namespace Festival
{
    public class Skeleton : MonoBehaviour
    {
        [SerializeField] private float _health;
        [SerializeField] private float _damage;

        private void AddDamage(int damage)
        {
            _health -= damage;
            if(_health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {

        }
    }
}
