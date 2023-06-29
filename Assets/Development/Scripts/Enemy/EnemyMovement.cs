using UnityEngine;
using UnityEngine.AI;

namespace Festival
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class EnemyMovement : MonoBehaviour
    {
        private NavMeshAgent _navMeshAgent;

        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }
        
        public void Follow(Player player)
        {
            _navMeshAgent.SetDestination(player.transform.position);
        }
    }
}
