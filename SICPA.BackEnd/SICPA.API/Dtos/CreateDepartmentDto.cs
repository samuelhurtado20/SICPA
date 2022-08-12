using SICPA.API.Entities;

namespace SICPA.API.Dtos
{
    public class CreateDepartmentDto
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int EnterpriseId { get; set; }

        public Department ToEntity()
        {
            Department entity = new()
            {
                Name = Name,
                Description = Description,
                Phone = Phone,
                Status = true,
                EnterpriseId = EnterpriseId,
                ModifiedDate = DateTime.UtcNow,
                ModifiedBy = "",
                CreatedDate = DateTime.UtcNow,
                CreatedBy = ""
            };

            return entity;
        }
    }
}
