using RealEstate_Api.Dtos.MessageDtos;

namespace RealEstate_Api.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInboxMessageDto>> GetInboxLast3MessageListByReceiverAsync(int id);
    }
}
