using UnityEngine;

namespace Festival
{
    public class Spider : Enemy
    {
        public override void AddDamage(int damage)
        {
            base.AddDamage(damage);
        }

        protected override void Die()
        {
            Debug.Log("Die Spider");
        }
    }
}
