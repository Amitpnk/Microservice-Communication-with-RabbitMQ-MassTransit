using CrossCuttingLayer;
using GreenPipes;
using MassTransit;
using System;

namespace Microservice.TodoApp.Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Notification";

            //var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            //{
            //    cfg.ReceiveEndpoint("todoQueue", e =>
            //    {
            //        e.PrefetchCount = 16;
            //        e.UseMessageRetry(r => r.Interval(2, 100));
            //        e.Consumer<TodoConsumerNotification>();
            //        //e.UseMessageRetry(r => r.Immediate(5));
            //    });
            //});

            var bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(RabbitMqConsts.RabbitMqRootUri), h =>
                {
                    h.Username(RabbitMqConsts.UserName);
                    h.Password(RabbitMqConsts.Password);
                });
                cfg.ReceiveEndpoint("todoQueue", ep =>
                {
                    ep.PrefetchCount = 16;
                    ep.UseMessageRetry(r => r.Interval(2, 100));
                    ep.Consumer<TodoConsumerNotification>();
                });

            });

            bus.StartAsync();
            Console.WriteLine("Listening for Todo registered events.. Press enter to exit");
            Console.ReadLine();
            bus.StopAsync();
        }
    }
}
