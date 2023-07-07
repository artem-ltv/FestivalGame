using UnityEngine;

namespace Festival
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] protected int Health;
        [SerializeField] protected int Damage;

        public virtual void AddDamage(int damage) 
        {
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }
        protected abstract void Die();
    }
}
