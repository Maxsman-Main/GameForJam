using CodeBase.Services.Input;
using Zenject;

namespace CodeBase.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
        }
    }
}