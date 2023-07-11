using UnityEngine;

namespace Festival
{
    public class PlayerAnimatorController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private string _runAnimation = "Run";
        private string _deathAnimation = "Die";

        public void ActivateRun(float value)
        {
            _animator.SetFloat(_runAnimation, value);
        }

        public void ActivateDeath()
        {
            _animator.SetTrigger(_deathAnimation);
        }
    }
}
