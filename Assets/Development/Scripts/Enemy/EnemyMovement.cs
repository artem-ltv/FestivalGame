using UnityEngine;
using UnityEngine.AI;

namespace Festival
{
    [RequireComponent(typeof(NavMeshAgent))]
    public abstract class EnemyMovement : MonoBehaviour
    {
        protected NavMeshAgent _navMeshAgent;

        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }
        
        public void Follow(Player player)
        {
            _navMeshAgent.enabled = true;
            _navMeshAgent.SetDestination(player.transform.position);
        }

        public void Stop()
        {
            _navMeshAgent.enabled = false;
        }
    }
}
