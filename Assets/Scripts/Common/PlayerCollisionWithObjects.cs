using System;
using API;
using UI;
using UnityEngine;
using UnityEngine.Serialization;

namespace Common
{
    public class PlayerCollisionWithObjects : MonoBehaviour
    {
        [SerializeField] private GameObject _soundFin;
        [SerializeField] private GameObject _soundPoint;
        [SerializeField] private SceneManager _sceneManager;
        [SerializeField] private ScoreCounter _counter;
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("CheckPoint"))
            {
                _counter.AddPoints();
                Instantiate(_soundPoint,transform);
            }
            
            
            if (col.CompareTag("Finish"))
            {
                _sceneManager.EndGame();
                Instantiate(_soundFin,transform);
            }
        }
    }
}
