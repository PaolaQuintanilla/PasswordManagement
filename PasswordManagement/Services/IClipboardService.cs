namespace PasswordManagement.Services
{
    public interface IClipboardService
    {
        Task CopyToClipboard(string text);
    }
}
