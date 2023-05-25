using UnityEngine;
using UnityEngine.Events;

namespace Festival
{
    public class HealingMagic : MonoBehaviour
    {
        public UnityAction<int> Healing;

        [SerializeField] private int _additionalHealth;
        [SerializeField] private ParticleSystem _effect;
        [SerializeField] private Transform _effectPoint;

        public void Heal()
        {
            Instantiate(_effect, _effectPoint);
            Healing?.Invoke(_additionalHealth);
        }
    }
}
