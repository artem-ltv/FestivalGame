using UnityEngine;
using DG.Tweening;

namespace Festival
{
    [RequireComponent(typeof(MeteoriteCollisionHandler))]
    public class Meteorite : MonoBehaviour
    {
        [SerializeField] private float _fallTime;
        [SerializeField] private ParticleSystem _explosionEffect;
        [SerializeField] private int _damage;

        private MeteoriteCollisionHandler _collisionHandler;
        private float _fallEndPoint;

        private void Start()
        {
            _collisionHandler = GetComponent<MeteoriteCollisionHandler>();
            _collisionHandler.SetDamage(_damage);
        }

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
