using CQRSWithMediatR.Commands;
using CQRSWithMediatR.Repository;
using MediatR;

namespace CQRSWithMediatR.Handlers
{
    public class DeleteEmployeeRequestHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        readonly EmployeeWriteRepository _employeeRepository;
        public DeleteEmployeeRequestHandler(EmployeeWriteRepository _employeeRepository) 
        { 
            this._employeeRepository = _employeeRepository;
        }
        public Task Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            _employeeRepository.DeleteEmployee(request.Id);
            return Task.CompletedTask;
        }
    }
}
