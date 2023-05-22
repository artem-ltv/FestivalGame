using UnityEngine;
using DG.Tweening;

namespace Festival
{
    public class Meteorite : MonoBehaviour
    {
        [SerializeField] private float _fallTime;

        private float _fallEndPoint;

        public void Fall()
        {
            transform.DOMoveY(transform.position.y - _fallEndPoint, _fallTime);
        }

        public void Initialize(float fallEndPoint)
        {
            _fallEndPoint = fallEndPoint;
        }
    }
}
