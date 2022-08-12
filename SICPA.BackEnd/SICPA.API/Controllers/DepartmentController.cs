using Microsoft.AspNetCore.Mvc;
using SICPA.API.Dtos;
using SICPA.API.Entities;
using SICPA.API.Interfaces;

namespace SICPA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _uow;

        public DepartmentController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        /// <summary>
        /// Get all Departments
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Elements not found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _uow.Department.Get();
                if (!result.Any())
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
        /// Get a single Department by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Element not found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            try
            {
                var result = _uow.Department.Get(id);
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
        /// Save new Department
        /// </summary>
        /// <returns></returns>
        /// <response code="201">Successful operation</response>
        /// <response code="500">Internal server error</response>
        [HttpPost]
        public IActionResult Post(CreateDepartmentDto data)
        {
            try
            {
                Department entity = data.ToEntity();
                _uow.Department.Create(entity);
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
        /// Update Department
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Successful operation</response>
        /// <response code="500">Internal server error</response>
        [HttpPut]
        public IActionResult Put(UpdateDepartmentDto data)
        {
            try
            {
                Department entity = _uow.Department.Get(data.Id);
                entity.Phone = data.Phone;
                entity.Description = data.Description;
                entity.Name = data.Name;
                entity.EnterpriseId = data.EnterpriseId;
                _uow.Department.Update(entity);
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
        /// Delete Department by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Successful operation</response>
        /// <response code="500">Internal server error</response>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                _uow.Department.Delete(id);
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
