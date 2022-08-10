using SICPA.DataAccess.Data;
using SICPA.DataAccess.Interfaces;
using SICPA.Models.Entities;

namespace SICPA.DataAccess.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}