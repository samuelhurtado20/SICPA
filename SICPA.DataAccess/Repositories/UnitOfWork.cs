using SICPA.DataAccess.Data;
using SICPA.DataAccess.Interfaces;

namespace SICPA.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IEnterpriseRepository Enterprise { get; private set; }
        public IDepartmentRepository Department { get; private set; }
        public IEmployeeRepository Employee { get; private set; }
        public IDepartmentEmployeeRepository DepartmentEmployee { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Enterprise = new EnterpriseRepository(_db);
            Department = new DepartmentRepository(_db);
            Employee = new EmployeeRepository(_db);
            DepartmentEmployee = new DepartmentEmployeeRepository(_db);
        }

        public void Save() => _db.SaveChanges();

        public void Dispose() => _db.Dispose();
    }
}
