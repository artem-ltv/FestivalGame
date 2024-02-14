using UnityEngine;
using TMPro;

namespace Festival
{
    public class HealthDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text _healthDisplay;  
        [SerializeField] private PlayerHealth _playerHealth;

        private void OnEnable()
        {
            _playerHealth.ChangedEvent += OnChanged;
        }

        private void OnDisable()
        {
            _playerHealth.ChangedEvent -= OnChanged;
        }

        private void OnChanged(int health)
        {
            _healthDisplay.SetText(health.ToString());
        }
    }
}
