using SICPA.DataAccess.Data;
using SICPA.DataAccess.Interfaces;
using SICPA.Models.Entities;

namespace SICPA.DataAccess.Repositories
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
