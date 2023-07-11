using UnityEngine;
using UnityEngine.AI;

namespace Festival
{
    [RequireComponent(typeof(NavMeshAgent))]
    public abstract class EnemyMovement : MonoBehaviour
    {
        [SerializeField] protected Player Player;

        protected NavMeshAgent NavMeshAgent;
        protected bool CanMove = true;

        private void Start()
        {
            NavMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            if (CanMove)
            {
                Move();
            }
        }

        protected abstract void Move();
        public virtual void Stop() 
        {
            NavMeshAgent.enabled = false;
        }

        public void SetAbilityMove(bool canMove)
        {
            CanMove = canMove;
            if(canMove == false)
            {
                Stop();
            }
        }
    }
}
