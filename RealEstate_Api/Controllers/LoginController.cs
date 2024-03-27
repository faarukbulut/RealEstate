using Dapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.LoginDtos;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Tools;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(ResultLoginDto resultLoginDto)
        {
            string query = "Select * From Users Where Username=@username and Password=@password";

            var parameters = new DynamicParameters();
            parameters.Add("@username", resultLoginDto.Username);
            parameters.Add("@password", resultLoginDto.Password);

            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<ResultLoginDto>(query, parameters);

                if(values != null)
                {
                    GetCheckAppUserModel model = new GetCheckAppUserModel();
                    model.Username = values.Username;
                    model.Id = values.UserID;
                    var token = JwtTokenGenerator.GenerateToken(model);
                    return Ok(token);
                }
                else
                {
                    return BadRequest("Başarısız");
                }
            }
        }
    }
}
