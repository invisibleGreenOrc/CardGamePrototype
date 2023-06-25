using CodeBase.GameSystem;
using Reflex.Core;
using UnityEngine;

namespace CodeBase.Infrastructure.DI
{
    public class GameInstaller : MonoBehaviour, IInstaller
    {
        [SerializeField]
        private Game _game;

        public void InstallBindings(ContainerDescriptor descriptor)
        {
            descriptor.AddInstance(_game);
        }

        public void OnContainerBuilt(Container container)
        {

        }
    }
}