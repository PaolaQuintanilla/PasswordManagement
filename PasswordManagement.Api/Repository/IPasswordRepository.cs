using PasswordManagement.DataModel;
using System.Security.Principal;

namespace PasswordManagement.Api.Repository
{
    public interface IPasswordRepository
    {
        List<PasswordModel> GetPasswords();

        PasswordModel CreatePassword(PasswordModel password);

        void UpdatePassword(PasswordModel password, int id);

        PasswordModel DeletePassword(int? id);
    }
}
