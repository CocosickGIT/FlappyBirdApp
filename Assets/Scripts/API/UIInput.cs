using UnityEngine;

namespace API
{
    public class UIInput : MonoBehaviour
    {
        [SerializeField] private GameObject _startScreen;
        [SerializeField] private GameObject _gameOverScreen;
        [SerializeField] private SceneManager _sceneManager;

        void Update()
        {
            foreach (var touch in Input.touches)
            {
                if ((Input.GetKeyDown(KeyCode.Space) || touch.phase == TouchPhase.Began) &&
                    _startScreen.activeInHierarchy)
                    _sceneManager.StartGame();

                if ((Input.GetKeyDown(KeyCode.Space) || touch.phase == TouchPhase.Began) &&
                    _gameOverScreen.activeInHierarchy)
                    _sceneManager.RestartGame();
            }
            if (Input.GetKeyDown(KeyCode.Space) && _startScreen.activeInHierarchy)
                _sceneManager.StartGame();

            if (Input.GetKeyDown(KeyCode.Space) && _gameOverScreen.activeInHierarchy)
                _sceneManager.RestartGame();
        }
    }
}
