using UnityEngine;

namespace API
{
    public class SceneManager : MonoBehaviour
    {
        
        [SerializeField] private GameObject _gameOverCanvas;
        [SerializeField] private GameObject _startCanvas;


        private void Start()
        {
            _gameOverCanvas.SetActive(false);
            _startCanvas.SetActive(true);
            GameStop();
        }

        public void EndGame()
        {
            _gameOverCanvas.SetActive(true);
            GameStop();
        }

        public void StartGame()
        {
            _startCanvas.SetActive(false);
            ContinueGame();
        }

        public void RestartGame()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        
        private void GameStop()
        {
            Time.timeScale = 0;
        }
        private void ContinueGame()
        {
            Time.timeScale = 1;
        }
    
    }
}
