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

        private float _effectDuration = 2f;

        public void Heal()
        {
            StartCoroutine(ShowEffect());
            Healing?.Invoke(_additionalHealth);
        }

        private IEnumerator ShowEffect()
        {
            _effect.Play();
            yield return new WaitForSeconds(_effectDuration);
            _effect.Stop();
        }
    }
}
