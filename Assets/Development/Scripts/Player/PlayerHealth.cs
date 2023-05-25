using TMPro;
using UnityEngine;

namespace Festival
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private HealingMagic _healingMagic;
        [SerializeField] private TMP_Text _healthUI;

        private int _maxHealth = 100;

        private void OnEnable()
        {
            _healingMagic.Healing += AddHealth;
        }

        private void OnDisable()
        {
            _healingMagic.Healing -= AddHealth;
        }

        private void Start()
        {
            UpdateHealthUI();
        }

        private void AddDamage(int damage)
        {
            _health -= damage;
            if(_health <= 0)
            {
                _health = 0;
                Die();
            }

            UpdateHealthUI();
        }

        private void AddHealth(int health)
        {
            _health += health;
            if(_health >= _maxHealth)
            {
                _health = _maxHealth;
            }

            UpdateHealthUI();
        }

        private void Die()
        {
            Debug.Log("Player died");
        }

        private void UpdateHealthUI()
        {
            _healthUI.text = _health.ToString();
        }
    }
}
