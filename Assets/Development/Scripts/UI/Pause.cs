using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Festival
{
    public class Pause : MonoBehaviour
    {
        [SerializeField] private GameObject _panel;
        [SerializeField] private Button _continue;
        [SerializeField] private Button _mainMenu;

        private void OnEnable()
        {
            _continue.Add(Continue);
            _mainMenu.Add(GoToMainMenu);
        }

        private void OnDisable()
        {
            _continue.Remove(Continue);
            _mainMenu.Remove(GoToMainMenu);
        }

        public void Show()
        {
            _panel.SetActive(true);
            Time.timeScale = 0f;
        }

        private void Continue()
        {
            _panel.SetActive(false);
            Time.timeScale = 1f;
        }

        private void GoToMainMenu()
        {
            //
        }
    }
}
