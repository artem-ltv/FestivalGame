using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(EnemyMovement))]
    [RequireComponent(typeof(EnemyAttacker))]
    public abstract class EnemyController : MonoBehaviour
    {
        [SerializeField] protected Player Player;
        [SerializeField] protected float MinDistanceFromPlayer;
        [SerializeField] protected float DistanceForAttack;
        [SerializeField] private EnemyMovement _enemyMovement;

        private EnemyAttacker _enemyAttacker;

        private void Start()
        {
            _enemyAttacker = GetComponent<EnemyAttacker>();
            _enemyMovement = GetComponent<EnemyMovement>();
        }

        private void Update()
        {
            float distanceBetweenPlayer = Vector3.Distance(transform.position, Player.transform.position);

            if (distanceBetweenPlayer < MinDistanceFromPlayer && distanceBetweenPlayer > DistanceForAttack)
            {
                FollowPlayer();
            }

            if(distanceBetweenPlayer <= DistanceForAttack)
            {
                AttackPlayer();
            }
        }

        protected virtual void FollowPlayer()
        {
            _enemyMovement.Follow(Player);
        }

        protected virtual void AttackPlayer()
        {
            _enemyMovement.Stop();
            _enemyAttacker.Attack();
        }
    }
}
