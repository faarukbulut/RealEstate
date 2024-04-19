using Dapper;
using RealEstate_Api.Dtos.MessageDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.MessageRepositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultInboxMessageDto>> GetInboxLast3MessageListByReceiver(int id)
        {
            string query = "Select Top(3) MessageId,Name,Subject,Detail,SendDate,IsRead From Message Inner Join AppUser On Message.Receiver=AppUser.UserId Where Receiver=@receiverId Order By MessageId Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@receiverId", id);

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<ResultInboxMessageDto>(query, parameters);
                return value.ToList();
            }
        }
    }
}
