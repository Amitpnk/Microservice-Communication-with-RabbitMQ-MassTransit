using CrossCuttingLayer;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.TodoApp.Notification
{
    public class TodoConsumerNotification : IConsumer<Todo>
    {
        public async Task Consume(ConsumeContext<Todo> context)
        {
            await Console.Out.WriteLineAsync($"Notification sent: todo id {context.Message.Id}");
        }
    }
}