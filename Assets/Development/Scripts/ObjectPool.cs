using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Festival
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameObject _container;
        [SerializeField] private int _capacity;

        private List<Meteorite> _pool = new List<Meteorite>();

        protected void Initialize(Meteorite prefab)
        {
            for(int i = 0; i < _capacity; i++)
            {
                Meteorite spawned = Instantiate(prefab, _container.transform);
                spawned.gameObject.SetActive(false);

                _pool.Add(spawned);
            }

        }

        protected bool TryGetObject(out Meteorite result)
        {
            result = _pool.FirstOrDefault(p => p.gameObject.activeSelf == false);

            return result != null;
        }
    }
}
