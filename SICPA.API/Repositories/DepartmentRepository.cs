using SICPA.API.Data;
using SICPA.API.Interfaces;
using SICPA.API.Entities;

namespace SICPA.API.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
