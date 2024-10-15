using TMPro;
using UnityEngine;
using Zenject;

namespace ExecutionOrderClickerTask.GameAssembly
{
    public class GameInstaller : MonoInstaller
    {
        [Header("Score")]
        [SerializeField]
        private int initialScore = 5;

        public override void InstallBindings()
        {
            BindMechanics();
            BindInput();
        }

        private void BindMechanics()
        {
            Container.Bind<Score>().FromInstance(new(initialScore)).AsSingle();
            Container.Bind<RaycastClicker>().FromInstance(new(Camera.main)).AsSingle();
        }

        private void BindInput()
        {
            Container.Bind<PlayerInputAsset>().AsSingle();
            Container.Bind<PlayerInputListener>().AsSingle();
            Container.Bind<PlayerInputInvoker>().AsSingle().NonLazy();
        }
    }
}
