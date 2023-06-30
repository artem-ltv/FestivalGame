using UnityEngine;

namespace Festival
{
    public class SkeletonAnimatorController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private string _walkParameter = "Walk";
        private string _attackParameter = "Attack";
        private string _deathParameter = "Death";

        public void Walk(bool isWalk)
        {
            _animator.SetBool(_walkParameter, isWalk);
        }

        public void Attack(bool isAttack)
        {
            _animator.SetBool(_attackParameter, isAttack);
        }

        public void Die()
        {
            _animator.SetTrigger(_deathParameter);
        }
    }
}
