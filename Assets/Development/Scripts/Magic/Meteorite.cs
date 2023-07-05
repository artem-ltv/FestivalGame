using UnityEngine;
using DG.Tweening;

namespace Festival
{
    public class Meteorite : MonoBehaviour
    {
        [SerializeField] private float _fallTime;
        [SerializeField] private ParticleSystem _explosionEffect;

        private float _fallEndPoint;

        public void Initialize(float fallEndPoint)
        {
            _fallEndPoint = fallEndPoint;
        }

        public void Fall()
        {
            transform.DOMoveY(transform.position.y - _fallEndPoint, _fallTime).SetEase(Ease.Linear);
        }

        public void Explode()
        {
            Instantiate(_explosionEffect, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
