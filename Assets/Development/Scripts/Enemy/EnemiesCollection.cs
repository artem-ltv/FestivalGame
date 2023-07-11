using UnityEngine;
using System.Collections.Generic;

namespace Festival
{
    public class EnemiesCollection : MonoBehaviour
    {
        [SerializeField] private List<Skeleton> _skeletons;
        [SerializeField] private List<Spider> _spiders;
        [SerializeField] private PlayerHealth _playerHealth;

        private void OnEnable()
        {
            _playerHealth.Dying += DisableEnemies;
        }

        private void OnDisable()
        {
            _playerHealth.Dying -= DisableEnemies;
        }

        private void DisableEnemies()
        {
            foreach(var skeleton in _skeletons)
            {
                skeleton.gameObject.TryGetComponent(out SkeletonMovement movement);
                movement.SetAbilityMove(false);
            }
        }
    }
}
