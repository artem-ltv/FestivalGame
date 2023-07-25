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

        public void AddSpider(Spider spider)
        {
            _spiders.Add(spider);
        }

        private void DisableEnemies()
        {
            foreach(var skeleton in _skeletons)
            {
                if(skeleton.gameObject.TryGetComponent(out SkeletonMovement skeletonMovement))
                {
                    skeletonMovement.SetAbilityMove(false);
                }
            }

            foreach(var spider in _spiders)
            {
                if(spider != null)
                {
                    if(spider.gameObject.TryGetComponent(out SpiderMovement spiderMovement))
                    {
                        spiderMovement.SetAbilityMove(false);
                    }
                }
            }
        }
    }
}
