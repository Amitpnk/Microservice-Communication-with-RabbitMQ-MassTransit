using CrossCuttingLayer;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.TodoApp.Consumers
{
    public class TodoConsumer : IConsumer<Todo>
    {
        public async Task Consume(ConsumeContext<Todo> context)
        {
            var data = context.Message;
            //Validate the Ticket Data
            //Store to Database
            //Notify the user via Email / SMS
        }
    }
}
