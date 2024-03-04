using CQRSWithMediatR.Commands;
using CQRSWithMediatR.Model;
using CQRSWithMediatR.Repository;
using MediatR;
using System.Security.Cryptography;

namespace CQRSWithMediatR.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly EmployeeWriteRepository _employeeRepository;
        public CreateEmployeeCommandHandler(EmployeeWriteRepository _employeeRepository)
        {
            this._employeeRepository = _employeeRepository;
        }
        public Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            if(!cancellationToken.IsCancellationRequested)
            {
                int employeeId = RandomNumberGenerator.GetInt32(int.MaxValue);
                _employeeRepository.AddEmployee(
                   new Employee
                   {
                       Id = employeeId,
                       Name = request.Name,
                       Designation = request.Designation,
                       Salary = request.Salary,
                   }
               );
               return Task.FromResult(employeeId);
            }
            throw new TaskCanceledException();
        }
    }
}
