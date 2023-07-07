using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(Meteorite))]
    public class MeteoriteCollisionHandler : MonoBehaviour
    {
        private Meteorite _meteorite;
        private int _damage;

        private void Start()
        {
            _meteorite = GetComponent<Meteorite>();
        }

        public void SetDamage(int damage)
        {
            _damage = damage;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out Enemy enemy))
            {
                enemy.AddDamage(_damage);
            }

            _meteorite.Explode();
        }

    }
}
