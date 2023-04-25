namespace SemestriProject.Data.Common
{
    public abstract class OrderEntityData : UniqueEntityData
    {
        public string Name { get; set; }
        public string AddressRow { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public int Quantity { get; set; }
        public string PackageType { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Value { get; set; }
        public string GoodsDescription { get; set; }
        public bool DangerousGoods { get; set; }
        public bool TemperatureSensitive { get; set; }
        public string CustomerComments { get; set; }
        public bool AcceptTerms { get; set; }
    }

}
