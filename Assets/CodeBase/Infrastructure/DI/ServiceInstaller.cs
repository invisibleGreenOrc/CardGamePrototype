using CodeBase.Services;
using Reflex.Core;
using UnityEngine;

namespace CodeBase.Infrastructure.DI
{
    public class ServiceInstaller : MonoBehaviour, IInstaller
    {
        public void InstallBindings(ContainerDescriptor descriptor)
        {
            descriptor.AddSingleton(typeof(BattlefieldService), typeof(IBattlefieldService));
            descriptor.AddSingleton(typeof(StaticDataService), typeof(IStaticDataService));
        }

        public void OnContainerBuilt(Container container)
        {
            
        }
    }
}
