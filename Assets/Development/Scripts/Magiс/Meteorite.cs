using UnityEngine;

namespace Festival
{
    public class Meteorite : MonoBehaviour
    {
        [SerializeField] private float _fallSpeed;

        private float _spawnHeight;

        public void Initialize(float spawnHeight)
        {
            _spawnHeight = spawnHeight;
        }

        public void Fall()
        {
            //
        }
    }
}
