using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCuttingLayer
{
    public class RabbitMqConsts
    {
        public const string RabbitMqRootUri = "rabbitmq://localhost";
        public const string RabbitMqUri = "rabbitmq://localhost/todoQueue";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterTodoServiceQueue = "registertodo.service";
        public const string NotificationServiceQueue = "notification.service";
        public const string ThirdPartyServiceQueue = "thirdparty.service";
    }
}
