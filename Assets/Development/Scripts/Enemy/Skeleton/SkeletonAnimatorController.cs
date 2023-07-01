using UnityEngine;

namespace Festival
{
    public class SkeletonAnimatorController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private string _walkAnimation = "Walk";
        private string _attackAnimaiton = "Attack";
        private string _deathAnimation = "Death";

        public void ActivateWalk(bool isEnable)
        {
            _animator.SetBool(_walkAnimation, isEnable);
        }

        public void ActivateAttack(bool isEnable)
        {
            _animator.SetBool(_attackAnimaiton, isEnable);
        }

        public void ActivateDeath()
        {
            _animator.SetTrigger(_deathAnimation);
        }
    }
}
