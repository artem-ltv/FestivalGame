using UnityEngine;
using UnityEngine.AI;

namespace Festival
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class SkeletonMovement : EnemyMovement
    {
        [SerializeField] private float _distanceForFollow;
        [SerializeField] private float _distanceForAttack;
        [SerializeField] private SkeletonAnimatorController _animatorController;


        protected override void Move()
        {
            float distanceFromPlayer = Vector3.Distance(transform.position, Player.transform.position);

            if (distanceFromPlayer > _distanceForFollow)
            {
                NavMeshAgent.enabled = false;
                _animatorController.ActivateWalk(false);
                _animatorController.ActivateAttack(false);
            }

            if (distanceFromPlayer <= _distanceForAttack)
            {
                NavMeshAgent.enabled = false;
                _animatorController.ActivateAttack(true);
            }

            else if (distanceFromPlayer < _distanceForFollow)
            {
                NavMeshAgent.enabled = true;
                _animatorController.ActivateAttack(false);
                _animatorController.ActivateWalk(true);
                NavMeshAgent.SetDestination(Player.transform.position);
            }
        }

        public override void Stop()
        {
            _animatorController.ActivateAttack(false);
            _animatorController.ActivateWalk(false);
        }
    }
}
