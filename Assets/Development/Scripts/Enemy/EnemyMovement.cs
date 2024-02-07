using UnityEngine;
using UnityEngine.AI;

namespace Festival
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private Transform _player;

        private NavMeshAgent _navMeshAgent;

        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            _navMeshAgent.SetDestination(_player.position);
        }
    }
}
