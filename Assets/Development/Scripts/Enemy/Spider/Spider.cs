using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(Damager))]
    public class Spider : Enemy
    {
        private Damager _damager;

        private void Awake()
        {
            _damager = GetComponent<Damager>();
            _damager.SetDamage(Damage);
        }

        private void OnEnable()
        {
            _damager.Damaging += Die;
        }

        private void OnDisable()
        {
            _damager.Damaging -= Die;
        }

        public override void AddDamage(int damage)
        {
            base.AddDamage(damage);
        }

        protected override void Die()
        {
            Destroy(gameObject);
        }
    }
}
