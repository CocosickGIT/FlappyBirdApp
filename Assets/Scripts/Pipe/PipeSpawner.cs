using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Pipe
{
    public class PipeSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private float _height;
        [SerializeField] private float _timeToSpawn;
    
        private float _timer;
        private Transform _transform;

        private void Start()
        {
            _transform = transform;
        }

        private void Update()
        {
            _timer += Time.deltaTime;
            if (_timer <= _timeToSpawn)return;
        
            var position = _transform.position;
            _timer = 0;
            Instantiate(_prefab, new Vector3(position.x,Random.Range(-_height,_height) + position.y,0), quaternion.identity);
        }

        private void CreateObject()
        {
            
        }

        private void ReleaseObject()
        {
            
        }

        private void PoolItem()
        {
            
        }
    }
}
