using CodeBase.Scriptable.PlayerStats;
using CodeBase.Services.Input;
using CodeBase.Services.PlayerData;
using UnityEngine;
using Zenject;

namespace CodeBase.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Transform playerTransform;
        [SerializeField] private PlayerStats playerStats;

        public override void InstallBindings()
        {
            var playerData = new StandardPlayerData(playerTransform, playerStats);
            
            Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
            Container.Bind<IPlayerDataService>().FromInstance(playerData).AsSingle();
        }
    }
}