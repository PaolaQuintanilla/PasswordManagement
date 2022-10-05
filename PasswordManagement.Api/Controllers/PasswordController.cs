using Microsoft.AspNetCore.Mvc;
using PasswordManagement.Api.Repository;
using PasswordManagement.DataModel;
using System.Security.Principal;

namespace PasswordManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : Controller
    {
        public static List<PasswordModel> passwords = new List<PasswordModel>()
        {
            new PasswordModel() { Id = 1, Name = "Gmail", UserName = "JosePerez", Password = "password123", URL = "https://accounts.google.com/" },
            new PasswordModel() { Id = 2, Name = "Teams", UserName = "Jose.Perez", Password = "password123", URL = "https://teams.microsoft.com/go#" },
            new PasswordModel() { Id = 3, Name = "Github", UserName = "Jose.Perez", Password = "password234", URL = "https://github.google.com/" },
            new PasswordModel() { Id = 4, Name = "Gitlab", UserName = "Jose.Perez", Password = "password453", URL = "https://gitlab.com/" },
            new PasswordModel() { Id = 5, Name = "Classroom", UserName = "JosePerez", Password = "password123", URL = "https://classrom.google.com/" },
            new PasswordModel() { Id = 6, Name = "Facebook", UserName = "Jose123", Password = "password454", URL = "https://Facebook.com/" }
        };

        private readonly IPasswordRepository passwordRepository;

        public PasswordController(IPasswordRepository _passwordRepository)
        {
            passwordRepository = _passwordRepository;
        }

        [HttpGet]
        [Route("getPasswords")]
        public async Task<ActionResult<List<PasswordModel>>> getPasswords()
        {
            return passwordRepository.GetPasswords();
        }

        [HttpPost("Create")]
        public async Task<ActionResult<PasswordModel>> createPasswords([FromBody] PasswordModel password)
        {
            passwordRepository.CreatePassword(password);
            return password;
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdatePassword([FromBody] PasswordModel password, int id)
        {
            passwordRepository.UpdatePassword(password, id);
            return Ok("Account updated successfully.");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            PasswordModel result = passwordRepository.DeletePassword(id);
            return Ok("Account deleted successfully");
        }
    }
}
