using CodeBase.Scriptable.PlayerStats;
using UnityEngine;

namespace CodeBase.Services.PlayerData
{
    public interface IPlayerDataService
    {
        public Transform PlayerTransform { get; }
        public PlayerStats PlayerStats { get; }
    }
}