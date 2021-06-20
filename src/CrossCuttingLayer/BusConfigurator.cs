using MassTransit;
using MassTransit.RabbitMqTransport;
using System;

namespace CrossCuttingLayer
{
    public static class BusConfigurator
    {
        public static IBusControl ConfigureBus(Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> registrationAction = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(RabbitMqConsts.RabbitMqRootUri), h =>
                   {
                       h.Username(RabbitMqConsts.UserName);
                       h.Password(RabbitMqConsts.Password);
                   });

            });
        }
    }

}

