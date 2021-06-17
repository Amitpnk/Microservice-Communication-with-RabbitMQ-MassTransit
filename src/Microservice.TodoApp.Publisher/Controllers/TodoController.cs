using CrossCuttingLayer;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Microservice.TodoApp.Publisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IBus _bus;

        public TodoController(IBus bus)
        {
            _bus = bus;
        }
        [HttpPost]
        public async Task<IActionResult> CreateTicket(Todo todoModel)
        {
            if (todoModel != null)
            {
                Uri uri = new Uri(RabbitMqConsts.RabbitMqUri);
                var endPoint = await _bus.GetSendEndpoint(uri);
                await endPoint.Send(todoModel);
                return Ok();
            }
            return BadRequest();
        }
    }
}