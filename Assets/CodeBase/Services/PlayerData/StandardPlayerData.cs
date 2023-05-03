using CodeBase.Scriptable.PlayerStats;
using UnityEngine;

namespace CodeBase.Services.PlayerData
{
    public class StandardPlayerData : IPlayerDataService
    {
        private Transform _playerTransform;
        private PlayerStats _playerStats;

        public Transform PlayerTransform => _playerTransform;
        public PlayerStats PlayerStats => _playerStats;

        public StandardPlayerData(Transform playerTransform, PlayerStats playerStats)
        {
            _playerTransform = playerTransform;
            _playerStats = playerStats;
        }
    }
}