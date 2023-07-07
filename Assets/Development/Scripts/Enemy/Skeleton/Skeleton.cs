using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(SkeletonAnimatorController))]
    [RequireComponent(typeof(SkeletonMovement))]
    public class Skeleton : Enemy
    {
        [SerializeField] private SkeletonDamager _damager;

        private SkeletonAnimatorController _animatorController;
        private SkeletonMovement _movement;
        private Collider _collider;

        private void Start()
        {
            _collider = GetComponent<Collider>();
            _animatorController = GetComponent<SkeletonAnimatorController>();
            _movement = GetComponent<SkeletonMovement>();
            _damager.SetDamage(Damage);
        }

        public override void AddDamage(int damage)
        {
            base.AddDamage(damage);
            Debug.Log($"Health Skeleton: {Health}");
        }

        protected override void Die()
        {
            _movement.Stop();
            DisableComponents();
            _animatorController.ActivateDeath();
        }

        private void DisableComponents()
        {
            _collider.enabled = false;
            _movement.enabled = false;
            _damager.enabled = false;
        }
    }
}
