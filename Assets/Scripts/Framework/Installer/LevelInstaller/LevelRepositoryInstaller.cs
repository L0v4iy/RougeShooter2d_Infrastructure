using Common.Framework;
using Repositories;

namespace Framework.Installer.LevelInstaller
{
    public class LevelRepositoryInstaller : BaseSceneInstaller
    {
        protected override void InstallSceneBindings()
        {
            Container.Bind<PlayerRepository>().FromNew().AsSingle();

        }
    }
}