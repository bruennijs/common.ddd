using Autofac;
using Common.Ddd.Infrastructure.Event;
using Common.Ddd.Infrastructure.Event.Implementation;

namespace Common.Ddd
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DomainEventsBus>().As<IDomainEventBus>().SingleInstance();
        }
    }
}