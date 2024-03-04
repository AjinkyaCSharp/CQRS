using CQRSWithMediatR.Commands;
using CQRSWithMediatR.Model;
using CQRSWithMediatR.Repository;
using MediatR;

namespace CQRSWithMediatR.Handlers
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesCommand,IEnumerable<Employee>>
    {
        private readonly EmployeeReadRepository _employeeRepository;
        public GetAllEmployeesHandler(EmployeeReadRepository _employeeRepository)
        {
            this._employeeRepository = _employeeRepository;
        }

        public Task<IEnumerable<Employee>> Handle(GetAllEmployeesCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_employeeRepository.GetEmployees());
        }
    }
}
