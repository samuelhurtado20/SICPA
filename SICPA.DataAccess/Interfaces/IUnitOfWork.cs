namespace SICPA.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEnterpriseRepository Enterprise { get; }
        IDepartmentRepository Department { get; }
        IEmployeeRepository Employee { get; }
        IDepartmentEmployeeRepository DepartmentEmployee { get; }
        void Save();
    }
}
