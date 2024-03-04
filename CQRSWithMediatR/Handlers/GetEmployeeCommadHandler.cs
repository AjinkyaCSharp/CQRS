using CQRSWithMediatR.Model;
using CQRSWithMediatR.Queries;
using CQRSWithMediatR.Repository;
using MediatR;

namespace CQRSWithMediatR.Handlers
{
    public class GetEmployeeCommadHandler : IRequestHandler<GetEmployeeCommad, Employee?>
    {
        readonly EmployeeReadRepository _employeeRepository;
        public GetEmployeeCommadHandler(EmployeeReadRepository _employeeRepository)
        {
            this._employeeRepository = _employeeRepository;
        }

        public Task<Employee?> Handle(GetEmployeeCommad request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_employeeRepository.GetEmplyee(request.Id));
        }
    }
}
