using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(SkeletonAnimatorController))]
    public class SkeletonController : EnemyController
    {
        private SkeletonAnimatorController _animatorController;

        private void Start()
        {
            _animatorController = GetComponent<SkeletonAnimatorController>();
        }

        protected override void FollowPlayer()
        {
            base.FollowPlayer();
            _animatorController.Walk(true);
        }

        protected override void AttackPlayer()
        {
            _animatorController.Attack(true);
        }
    }
}
