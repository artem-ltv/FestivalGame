using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Festival
{
    public class HealingMagic : MonoBehaviour
    {
        public UnityAction<int> Healing;

        [SerializeField] private int _additionalHealth;
        [SerializeField] private ParticleSystem _effect;

        private float _rechargeTime = 4f;
        private bool _isHealing = false;

        public void Heal()
        {
            if (!_isHealing)
            {
                _isHealing = true;
                _effect.Play();
                Healing?.Invoke(_additionalHealth);
                StartCoroutine(Recharge());
            }
        }

        private IEnumerator Recharge()
        {
            yield return new WaitForSeconds(_rechargeTime);
            _isHealing = false;
        }
    }
}
