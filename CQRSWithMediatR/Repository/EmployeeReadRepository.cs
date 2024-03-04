using CQRSWithMediatR.Model;

namespace CQRSWithMediatR.Repository
{
    public class EmployeeReadRepository
    {
        private List<Employee> _employees;
        public EmployeeReadRepository()
        {
            _employees = new List<Employee>();
        }
        public Employee? GetEmplyee(int Id)
        {
            return _employees.Find(x => x.Id == Id);
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
        public void SyncDb(IEnumerable<Employee> employees)
        {
            _employees.AddRange(employees);
        }
    }
}
