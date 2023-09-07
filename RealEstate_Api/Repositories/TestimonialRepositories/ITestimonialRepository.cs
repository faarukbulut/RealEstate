using RealEstate_Api.Dtos.TestimonialDtos;

namespace RealEstate_Api.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
