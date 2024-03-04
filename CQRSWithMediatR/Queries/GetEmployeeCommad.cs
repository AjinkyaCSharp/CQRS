using CQRSWithMediatR.Model;
using MediatR;

namespace CQRSWithMediatR.Queries
{
    public class GetEmployeeCommad:IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
