using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Repositories.UserRepository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_commerce_website.Services.ProfileService
{
    public class ProfileService : IProfileService
    {
        private IUserRepository _userRepository;
        private IConfiguration _configuration;

        public ProfileService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public string Login(string userName, string userPassword)
        {
            var result = _userRepository
                .Read().Where(i => i.Name == userName && i.Password == userPassword).FirstOrDefault();

            if (result != default)
            {
                return GenerateToken(userName);
            }
            else
            {
                return "";
            }
        }

        public string Signup(User user)
        {
            var check = _userRepository
                .Read().Where(i => i.Name == user.Name).FirstOrDefault();

            if (check != default)
            {
                return "";
            }
            else
            {
                _userRepository.Create(user);
                return GenerateToken(user.Name);
            }
        }

        private string GenerateToken(string UserName)
        {
            var securityKey =
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Key").Value));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, UserName)
            };

            var token = new JwtSecurityToken(
                _configuration.GetSection("Jwt:Issuer").Value,
                _configuration.GetSection("Jwt:Audience").Value,
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
