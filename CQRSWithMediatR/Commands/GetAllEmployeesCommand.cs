using CQRSWithMediatR.Model;
using MediatR;
using System.Collections.Generic;

namespace CQRSWithMediatR.Commands
{
    public class GetAllEmployeesCommand:IRequest<IEnumerable<Employee>>
    {
    }
}
