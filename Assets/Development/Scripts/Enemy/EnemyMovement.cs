using UnityEngine;
using UnityEngine.AI;

namespace Festival
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private float _distanceForFollow;
        [SerializeField] private float _distanceForAttack;

        [SerializeField] private SkeletonAnimatorController _animatorController;

        private NavMeshAgent _navMeshAgent;

        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();            
        }

        private void Update()
        {
            float distanceFromPlayer = Vector3.Distance(transform.position, _player.transform.position);

            if (distanceFromPlayer > _distanceForFollow)
            {
                _navMeshAgent.enabled = false;
                _animatorController.ActivateWalk(false);
                _animatorController.ActivateAttack(false);
            }

            if (distanceFromPlayer <= _distanceForAttack)
            {
                _navMeshAgent.enabled = false;
                _animatorController.ActivateAttack(true);
            }

            else if (distanceFromPlayer < _distanceForFollow)
            {
                _navMeshAgent.enabled = true;
                _animatorController.ActivateAttack(false);
                _animatorController.ActivateWalk(true);
                _navMeshAgent.SetDestination(_player.transform.position);
            }
        }
    }
}
