using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    public class WingAnimation : MonoBehaviour

    {
        [SerializeField] private float _animationTime;
        [SerializeField] private Sprite[] _wings;
        [SerializeField] private SpriteRenderer _sprite;

        private Queue<Sprite> _anim;
        private float _timer;

        private void Start()
        {
            _anim = new Queue<Sprite>();

            foreach (var sprite in _wings)
                _anim.Enqueue(sprite);
        }

        void Update()
        {
            _timer += Time.deltaTime;

            if (!(_timer >= _animationTime)) return;
            
            SpriteScroll();
            _timer = 0;

        }

        private void SpriteScroll()
        {
            _sprite.sprite = _anim.Dequeue();
            _anim.Enqueue(_sprite.sprite);
        }
    }
}
