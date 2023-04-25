using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SemestriProject.Facade.Common
{
    public abstract class OrderEntityView : UniqueEntityView
    {
        [Required]
        [DisplayName("Identification code/register code")]
        public override string Id { get; set; }
        [Required]
        [DisplayName("Custumer/Company name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Address row")]
        public string AddressRow { get; set; }
        [Required]
        [DisplayName("Post code")]
        public string PostCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [DisplayName("Contact name")] 
        public string ContactName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [DisplayName("E-mail")]
        public string EMail { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [DisplayName("Package Type")]
        public string PackageType { get; set; }
        [Required]
        [DisplayName("Weight (kg)")]
        public double Weight { get; set; }
        [Required]
        [DisplayName("Volume (m³)")]
        public double Volume { get; set; }
        [Required]
        [DisplayName("Length (cm)")]
        public double Length { get; set; }
        [Required]
        [DisplayName("Width (cm)")]
        public double Width { get; set; }
        [Required]
        [DisplayName("Height (cm)")]
        public double Height { get; set; }
        [Required]
        [DisplayName("Value (€)")]
        public double Value { get; set; }
        [Required]
        [DisplayName("Goods Description")]
        public string GoodsDescription { get; set; }

        [DisplayName("Dangerous Goods")]
        public bool DangerousGoods { get; set; }

        [DisplayName("Temperature Sensitive")]
        public bool TemperatureSensitive { get; set; }
        
        [DisplayName("Customer Comments")]
        public string CustomerComments { get; set; }
        [Required]
        [DisplayName("Accept Terms")]
        public bool AcceptTerms { get; set; }
    }
}
