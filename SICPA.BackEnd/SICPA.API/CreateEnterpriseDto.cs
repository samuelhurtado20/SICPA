using SICPA.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace SICPA.API
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
                Address = this.Address,
                Name = this.Name,
                Phone = this.Phone,
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
