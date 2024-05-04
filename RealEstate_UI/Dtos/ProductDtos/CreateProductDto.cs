﻿namespace RealEstate_UI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string title { get; set; }
        public decimal price { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string coverImage { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public bool dealOfTheDay { get; set; }
        public DateTime advertisementDate { get; set; }
        public bool productStatus { get; set; }
        public int productCategory { get; set; }
        public int employeeID { get; set; }
    }
}
