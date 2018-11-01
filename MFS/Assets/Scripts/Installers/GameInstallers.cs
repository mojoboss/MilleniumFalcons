using UnityEngine;
using Zenject;

public class GameInstallers : MonoInstaller<GameInstallers>
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<GameController>().AsSingle().NonLazy();
        Container.Bind<GameState>().AsSingle().NonLazy();
        Container.Bind<OfflineGameService>().AsSingle().NonLazy();
    }
}