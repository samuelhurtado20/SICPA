using SICPA.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace SICPA.API.Dtos
{
    public class CreateEnterpriseDto
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Enterprise ToEntity()
        {
            Enterprise entity = new()
            {
                Address = Address,
                Name = Name,
                Phone = Phone,
                Status = true,
                ModifiedDate = DateTime.UtcNow,
                ModifiedBy = "",
                CreatedDate = DateTime.UtcNow,
                CreatedBy = ""
            };

            return entity;
        }
    }
}
