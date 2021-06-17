using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCuttingLayer
{
    public class RabbitMqConsts
    {
        public const string RabbitMqUri = "rabbitmq://localhost/todoqueue/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterTodoServiceQueue = "registerdemand.service";
        public const string NotificationServiceQueue = "notification.service";
        public const string ThirdPartyServiceQueue = "thirdparty.service";
    }
}
