namespace DistilleryManagementSystem
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string UnitType { get; set; }
        public string Category { get; set; }


        public DateTime ExpirationDate { get; set; }
    }
}