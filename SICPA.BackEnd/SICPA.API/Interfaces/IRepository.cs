namespace SICPA.API.Interfaces
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void Delete(IEnumerable<T> entities);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);

        /// <summary>
        /// Get all without filter
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get();

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T? Get(int id);
    }
}
