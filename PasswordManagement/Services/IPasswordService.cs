using PasswordManagement.DataModel;

namespace PasswordManagement.Services
{
    public interface IPasswordService
    {
        Task<List<PasswordModel>> GetPasswords();
        Task<PasswordModel> CreatePassword(PasswordModel password);
        Task<String> UpdatePassword(PasswordModel password);
        Task<String> DeletePassword(int id);
    }
}
