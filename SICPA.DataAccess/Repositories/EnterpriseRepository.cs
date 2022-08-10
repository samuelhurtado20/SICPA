using SICPA.DataAccess.Data;
using SICPA.DataAccess.Interfaces;
using SICPA.Models.Entities;

namespace SICPA.DataAccess.Repositories
{
    public class EnterpriseRepository : Repository<Enterprise>, IEnterpriseRepository
    {
        private readonly ApplicationDbContext _context;
        public EnterpriseRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}