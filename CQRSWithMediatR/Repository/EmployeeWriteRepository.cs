using CQRSWithMediatR.Model;

namespace CQRSWithMediatR.Repository
{
    public class EmployeeWriteRepository
    {
        private readonly List<Employee> _employees;
        public EmployeeWriteRepository()
        {
            _employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public void UpdateEmployee(Employee employee) 
        { 
            _employees.Remove(employee);
            AddEmployee(employee);
        }
        public void DeleteEmployee(int Id)
        {
            var index= _employees.FindIndex(x => x.Id == Id);
            _employees.RemoveAt(index);
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
