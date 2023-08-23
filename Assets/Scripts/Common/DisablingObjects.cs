using System;
using UnityEngine;

namespace Common
{
    public class DisablingObjects : MonoBehaviour
    {
        [SerializeField] private float _timeToDestroy;

        private float _timer;
        private void Update()
        {
            _timer += Time.deltaTime;

            if (_timer <= _timeToDestroy) return;
            
            _timer = 0;
            Destroy(gameObject);

        }
    }
}
