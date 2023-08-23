using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private int _pointsToAchieve;
        [SerializeField] private TextMeshProUGUI _text;

        internal int ScoreCount;

        private void Start()
        {
            ScoreCount = 0;
            _text.text = "0";
        }
        
        public void AddPoints()
        {
            ScoreCount += _pointsToAchieve;
            _text.text = ScoreCount.ToString();
        }
    }
}

