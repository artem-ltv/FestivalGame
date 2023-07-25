using System.Collections;
using UnityEngine;

namespace Festival
{
    public class SpiderSpawner : MonoBehaviour
    {
        [SerializeField] private Spider _spider;
        [SerializeField] private Player _player;
        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private EnemiesCollection _enemiesCollection;
        [SerializeField] private float _delayBeforeSpawn;

        private Coroutine _spawn;
        private PlayerHealth _playerHealth;

        private void OnEnable()
        {
            if(_player.TryGetComponent(out PlayerHealth playerHealth))
            {
                _playerHealth = playerHealth;
                _playerHealth.Dying += StopSpawn;
            }
        }

        private void OnDisable()
        {
            if(_playerHealth != null)
            {
                _playerHealth.Dying -= StopSpawn;
            }
        }

        private void Start()
        {
            _spawn = StartCoroutine(Spawn(_delayBeforeSpawn));
        }

        private IEnumerator Spawn(float delay)
        {
            var newForSecond = new WaitForSeconds(delay);

            while (true)
            {
                for(int i = 0; i<_spawnPoints.Length; i++)
                {
                    Spider newSpider = Instantiate(_spider, _spawnPoints[i].position, Quaternion.identity);
                    _enemiesCollection.AddSpider(newSpider);
                    if(newSpider.TryGetComponent(out SpiderMovement spiderMovement))
                    {
                        spiderMovement.SetPlayer(_player);
                    }
                    yield return newForSecond;
                }
            }
        }

        private void StopSpawn()
        {
            StopCoroutine(_spawn);
        }
    }
}
