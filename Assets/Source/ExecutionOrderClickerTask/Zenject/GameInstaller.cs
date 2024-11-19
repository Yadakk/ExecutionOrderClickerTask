using TMPro;
using UnityEngine;
using Zenject;

namespace ExecutionOrderClickerTask.GameAssembly.Zenject
{
    using ScoreSystem;
    using Clicks;
    using Input;

    public class GameInstaller : MonoInstaller
    {
        [SerializeField]
        private ScoreConfig scoreConfig;

        public override void InstallBindings()
        {
            BindMechanics();
            BindInput();
        }

        private void BindMechanics()
        {
            Container.Bind<RaycastClicker>().FromInstance(new(Camera.main)).AsSingle();
            Container.Bind<ScoreConfig>().FromInstance(scoreConfig).AsSingle();
            Container.Bind<Score>().AsSingle();
        }

        private void BindInput()
        {
            Container.Bind<PlayerInputAsset>().AsSingle();
            Container.Bind<PlayerInputListener>().AsSingle();
            Container.Bind<PlayerInputInvoker>().AsSingle().NonLazy();
        }
    }
}
