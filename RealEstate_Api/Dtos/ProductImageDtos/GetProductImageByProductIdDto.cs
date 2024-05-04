namespace RealEstate_Api.Dtos.ProductImageDtos
{
    public class GetProductImageByProductIdDto
    {
        public int ProductImageID { get; set; }
        public int ProductID { get; set; }
        public string ImageUrl { get; set; }
    }
}
