using UnityEngine;
using UnityEngine.UI;

namespace Festival
{
    public class MagicPanel : MonoBehaviour
    {
        [SerializeField] private Button _createMeteorite;
        [SerializeField] private Button _addHealth;

        [SerializeField] private MeteoriteMagic _meteoriteMagic;
        [SerializeField] private HealthMagic _healthMagic;

        private void OnEnable()
        {
            _createMeteorite.onClick.AddListener(OnClickButtonMeteorite);
            _addHealth.onClick.AddListener(OnClickButtonHealth);
        }

        private void OnDisable()
        {
            _createMeteorite.onClick.RemoveListener(OnClickButtonMeteorite);
            _addHealth.onClick.RemoveListener(OnClickButtonHealth);
        }

        private void OnClickButtonMeteorite()
        {
            _meteoriteMagic.Aim();
        }

        private void OnClickButtonHealth()
        {
            _healthMagic.AddHealthToPlayer();
        }
    }
}
