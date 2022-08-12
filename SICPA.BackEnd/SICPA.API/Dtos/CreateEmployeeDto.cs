using SICPA.API.Entities;

namespace SICPA.API.Dtos
{
    public class CreateEmployeeDto
    {
        public int Age { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Surname { get; set; }

        public Employee ToEntity()
        {
            Employee entity = new()
            {
                Name = Name,
                Age = Age,
                Email = Email,
                Status = true,
                Position = Position,
                Surname = Surname,
                ModifiedDate = DateTime.UtcNow,
                ModifiedBy = "",
                CreatedDate = DateTime.UtcNow,
                CreatedBy = ""
            };

            return entity;
        }
    }
}
