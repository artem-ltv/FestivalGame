using UnityEngine;
using UnityEngine.AI;

namespace Festival
{
    [RequireComponent(typeof(NavMeshAgent))]
    public abstract class EnemyMovement : MonoBehaviour
    {
        [SerializeField] protected Player Player;

        protected NavMeshAgent NavMeshAgent;

        private void Start()
        {
            NavMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            Move();
        }

        protected abstract void Move();
    }
}
