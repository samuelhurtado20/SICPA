using SICPA.API.Data;
using SICPA.API.Interfaces;
using SICPA.API.Entities;

namespace SICPA.API.Repositories
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