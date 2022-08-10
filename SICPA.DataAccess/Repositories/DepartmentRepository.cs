using SICPA.DataAccess.Data;
using SICPA.DataAccess.Interfaces;
using SICPA.Models.Entities;

namespace SICPA.DataAccess.Repositories
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
