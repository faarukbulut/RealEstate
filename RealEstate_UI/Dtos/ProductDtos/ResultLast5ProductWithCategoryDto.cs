namespace RealEstate_UI.Dtos.ProductDtos
{
    public class ResultLast5ProductWithCategoryDto
    {
        public int productID { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public int productCategory { get; set; }
        public string categoryName { get; set; }
        public DateTime advertisementDate { get; set; }
    }
}
