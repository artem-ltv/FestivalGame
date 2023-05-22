using UnityEngine;

namespace Festival
{
    [RequireComponent(typeof(Meteorite))]
    public class MeteoriteCollisionHandler : MonoBehaviour
    {
        private Meteorite _meteorite;

        private void Start()
        {
            _meteorite = GetComponent<Meteorite>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            _meteorite.Explode();
        }
    }
}
