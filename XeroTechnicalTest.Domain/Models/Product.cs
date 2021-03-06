using XeroTechnicalTest.Domain.Services.DTO;

namespace XeroTechnicalTest.Domain.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal DeliveryPrice { get; set; }

        public Product Update(UpdateProduct dto)
        {
            Name = dto.Name;
            Description = dto.Description;
            Price = dto.Price;
            DeliveryPrice = dto.DeliveryPrice;
            return this;
        }
    }
    
}