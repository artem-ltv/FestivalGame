using UnityEngine;
using UnityEngine.UI;

namespace Festival
{
    public class MagicPanel : MonoBehaviour
    {
        [SerializeField] private Button _createMeteorite;
        [SerializeField] private MouseAiming _aiming;

        private void Start()
        {
            _createMeteorite.onClick.AddListener(OnClickButtonMeteorite);
        }

        private void OnClickButtonMeteorite()
        {
            _aiming.SetVisibility(true);
        }
    }
}
