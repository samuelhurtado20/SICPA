using SICPA.API.Entities;

namespace SICPA.API.Dtos
{
    public class UpdateEnterpriseDto
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Enterprise ToEntity()
        {
            Enterprise entity = new()
            {
                Id = Id,
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
