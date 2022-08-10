using Microsoft.AspNetCore.Mvc;
using SICPA.API.Interfaces;

namespace SICPA.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnterpriseController : Controller
    {
        private readonly IUnitOfWork _uow;

        public EnterpriseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns>All customers</returns>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Elements not found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var customers = _uow.Enterprise.Get();
                if (customers.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(customers);
            }
            catch (Exception ex)
            {
                return base.StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Get a single customer by Guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single customer</returns>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Element not found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("GetSingle")]
        public IActionResult GetSingle(int id)
        {
            try
            {
                var customer = _uow.Enterprise.Get(id);
                if (customer == null)
                {
                    return NotFound();
                }

                return Ok(customer);
            }
            catch (Exception ex)
            {
                return base.StatusCode(500, ex.Message);
            }
        }
    }
}
