using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Festival
{
    [RequireComponent(typeof(PlayerAnimatorController))]
    public class PlayerHealth : MonoBehaviour
    {
        public UnityAction Dying;

        [SerializeField] private int _health;
        [SerializeField] private HealingMagic _healingMagic;
        [SerializeField] private TMP_Text _healthUI;

        private PlayerAnimatorController _animatorController;
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
            _animatorController = GetComponent<PlayerAnimatorController>();
        }

        public void AddDamage(int damage)
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
            _animatorController.ActivateDeath();
            Dying?.Invoke();
        }

        private void UpdateHealthUI()
        {
            _healthUI.text = _health.ToString();
        }
    }
}
