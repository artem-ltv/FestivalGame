using UnityEngine;

namespace Festival
{
    public class PlayerAnimatorController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private string _runAnimation = "Run";

        public void ActivateRun(float value)
        {
            _animator.SetFloat(_runAnimation, value);
        }
    }
}
