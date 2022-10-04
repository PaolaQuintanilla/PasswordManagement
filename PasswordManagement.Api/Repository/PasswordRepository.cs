using PasswordManagement.Api.Controllers;
using PasswordManagement.DataModel;

namespace PasswordManagement.Api.Repository
{
    public class PasswordRepository : IPasswordRepository
    {
        public PasswordModel CreatePassword(PasswordModel password)
        {
            PasswordController.passwords.Add(password);
            return password;
        }

        public PasswordModel DeletePassword(int? id)
        {

            foreach (var item in PasswordController.passwords)
            {
                if (item.Id == id)
                {
                    PasswordController.passwords.Remove(item);
                    return item;
                }
            }
            return null;
        }

        public List<PasswordModel> GetPasswords()
        {
            return PasswordController.passwords;
        }

        public void UpdatePassword(PasswordModel password, int id)
        {
            foreach (var item in PasswordController.passwords)
            {
                if (item.Id == id)
                {
                    item.Name = password.Name;
                    item.UserName = password.UserName;
                    item.Password = password.Password;
                    item.URL = password.URL;

                    return;
                }
            }
        }
    }
}
