using Microsoft.AspNetCore.Mvc;
using SICPA.API.Entities;
using SICPA.API.Interfaces;

namespace SICPA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnterpriseController : Controller
    {
        private readonly IUnitOfWork _uow;

        public EnterpriseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        /// <summary>
        /// Get all enterprises
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
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Get a single enterprise by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single customer</returns>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Element not found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            try
            {
                var result = _uow.Enterprise.Get(id);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Save new enterprise
        /// </summary>
        /// <returns>Enterprise</returns>
        /// <response code="201">Successful operation</response>
        /// <response code="500">Internal server error</response>
        [HttpPost]
        public IActionResult Post(CreateEnterpriseDto data)
        {
            try
            {
                Enterprise entity = data.ToEntity();
                _uow.Enterprise.Create(entity);
                _uow.Save();
                return StatusCode(StatusCodes.Status201Created, data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Update enterprise
        /// </summary>
        /// <returns>Enterprise</returns>
        /// <response code="200">Successful operation</response>
        /// <response code="500">Internal server error</response>
        [HttpPut]
        public IActionResult Put(Enterprise data)
        {
            try
            {
                Enterprise entity = _uow.Enterprise.Get(data.Id);
                entity.Phone = data.Phone;
                entity.Address = data.Address;
                entity.Name = data.Name;
                _uow.Enterprise.Update(entity);
                _uow.Save();
                return Ok(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Delete enterprise by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single customer</returns>
        /// <response code="200">Successful operation</response>
        /// <response code="500">Internal server error</response>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                _uow.Enterprise.Delete(id);
                _uow.Save();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
