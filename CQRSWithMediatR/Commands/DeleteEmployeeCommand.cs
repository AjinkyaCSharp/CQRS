using MediatR;

namespace CQRSWithMediatR.Commands
{
    public class DeleteEmployeeCommand:IRequest
    {
        public int Id { get; set; }
    }
}
