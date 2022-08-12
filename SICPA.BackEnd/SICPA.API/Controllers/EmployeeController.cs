using Microsoft.AspNetCore.Mvc;
using SICPA.API.Dtos;
using SICPA.API.Entities;
using SICPA.API.Interfaces;

namespace SICPA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public EmployeeController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        /// <summary>
        /// Get all Employees
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
                var result = _uow.Employee.Get();
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
        /// Get a single Employee by id
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
                var result = _uow.Employee.Get(id);
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
        /// Save new Employee
        /// </summary>
        /// <returns></returns>
        /// <response code="201">Successful operation</response>
        /// <response code="500">Internal server error</response>
        [HttpPost]
        public IActionResult Post(CreateEmployeeDto data)
        {
            try
            {
                Employee entity = data.ToEntity();
                _uow.Employee.Create(entity);
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
        /// Update Employee
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Successful operation</response>
        /// <response code="500">Internal server error</response>
        [HttpPut]
        public IActionResult Put(UpdateEmployeeDto data)
        {
            try
            {
                Employee entity = _uow.Employee.Get(data.Id);
                entity.Name = data.Name;
                entity.Position = data.Position;
                entity.Age = data.Age;
                entity.Email = data.Email;
                entity.Surname = data.Surname;
                _uow.Employee.Update(entity);
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
        /// Delete Employee by id
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
                _uow.Employee.Delete(id);
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
