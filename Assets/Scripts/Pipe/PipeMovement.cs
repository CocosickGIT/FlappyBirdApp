
using UnityEngine;

namespace Pipe
{
    public class PipeMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        
        private Transform _transform;

        private void Start()
        {
            _transform = transform;
        }

        void Update()
        {
            _transform.position += Vector3.left * (_speed * Time.deltaTime);
        }
    }
}
