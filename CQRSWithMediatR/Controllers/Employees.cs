using CQRSWithMediatR.Commands;
using CQRSWithMediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWithMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employees : ControllerBase
    {
        private readonly IMediator mediator;
        public Employees(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public IActionResult Get([FromQuery]int? Id)
        {
            if (Id == null)
                return Ok(mediator.Send(new GetAllEmployeesCommand()));
            return Ok(mediator.Send(new GetEmployeeCommad { Id = Id.Value }));
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateEmployeeCommand createEmployeeCommand)
        {
            return Ok(mediator.Send(createEmployeeCommand));
        }
        [HttpDelete]
        public IActionResult Delete([FromQuery] int Id)
        {
            mediator.Send(new DeleteEmployeeCommand { Id=Id});
            return Ok();
        }
    }
}
