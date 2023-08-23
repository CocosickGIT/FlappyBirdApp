using System;
using Unity.Mathematics;
using UnityEngine;

namespace Player
{
    public class PlayerSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private Vector3 _spawnPosition;

        private void Start()
        {
            Instantiate(_playerPrefab, _spawnPosition, quaternion.identity);
        }
    }
}
