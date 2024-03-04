using CQRSWithMediatR.Model;
using MediatR;

namespace CQRSWithMediatR.Commands
{
    public class CreateEmployeeCommand:IRequest<int>
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
}
