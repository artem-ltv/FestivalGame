using UnityEngine;
using DG.Tweening;

namespace Festival
{
    public class Meteorite : MonoBehaviour
    {
        [SerializeField] private float _fallTime;

        private float _spawnHeight;

        public void Initialize(float spawnHeight)
        {
            _spawnHeight = spawnHeight;
        }

        public void Fall()
        {
            transform.DOMoveY(transform.position.y - _spawnHeight, _fallTime).SetEase(Ease.Linear);
        }

        public void Collapse()
        {
            Destroy(gameObject);
        }
    }
}
