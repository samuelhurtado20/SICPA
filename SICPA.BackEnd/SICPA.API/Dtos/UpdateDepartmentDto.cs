using SICPA.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace SICPA.API.Dtos
{
    public class UpdateDepartmentDto
    {
        public int Id { get; set; }
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
