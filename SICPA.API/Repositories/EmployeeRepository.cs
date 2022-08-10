using SICPA.API.Data;
using SICPA.API.Interfaces;
using SICPA.API.Entities;

namespace SICPA.API.Repositories
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