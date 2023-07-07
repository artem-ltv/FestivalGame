using UnityEngine;

namespace Festival
{
    public class SkeletonDamager : MonoBehaviour
    {
        private int _damage;

        public void SetDamage(int damage)
        {
            _damage = damage;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Player player))
            {
                if (player.TryGetComponent(out PlayerHealth playerHealth))
                {
                    playerHealth.AddDamage(_damage);
                }
            }
        }
    }
}
