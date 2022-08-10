using SICPA.API.Data;
using SICPA.API.Interfaces;
using SICPA.API.Entities;

namespace SICPA.API.Repositories
{
    public class DepartmentEmployeeRepository : Repository<DepartmentEmployee>, IDepartmentEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        
        public DepartmentEmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
