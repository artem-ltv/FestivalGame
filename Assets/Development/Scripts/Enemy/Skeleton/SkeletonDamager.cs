using UnityEngine;

namespace Festival
{
    public class SkeletonDamager : MonoBehaviour
    {
        [SerializeField] private int _damage;

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
