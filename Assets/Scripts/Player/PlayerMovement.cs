using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private GameObject _wingSound;
        
        [Space]
        [SerializeField] private float _velocity;
        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                PlayerMove();
            
            foreach (var touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                    PlayerMove();
            }
        }

        private void PlayerMove()
        {
            _rb.AddForce(Vector2.up * _velocity, ForceMode2D.Impulse);
            Instantiate(_wingSound, transform);
        }
    }
}
