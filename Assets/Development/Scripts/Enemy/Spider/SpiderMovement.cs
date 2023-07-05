using UnityEngine;

namespace Festival
{
    public class SpiderMovement : EnemyMovement
    {
        protected override void Move()
        {
            NavMeshAgent.SetDestination(Player.transform.position);
        }
    }
}
