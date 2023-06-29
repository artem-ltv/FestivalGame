using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(EnemyMovement))]
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private float _minDistanceFromPlayer;

        private EnemyMovement _enemyMovement;

        private void Start()
        {
            _enemyMovement = GetComponent<EnemyMovement>();
        }

        private void Update()
        {
            if(Vector3.Distance(transform.position, _player.transform.position) < _minDistanceFromPlayer)
            {
                _enemyMovement.Follow(_player);
            }
        }
    }
}
