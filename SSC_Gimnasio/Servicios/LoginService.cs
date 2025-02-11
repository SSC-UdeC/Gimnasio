using System.Collections.Generic;
using System.Threading.Tasks;

public class LoginService
{
    private readonly Dictionary<string, string> users = new()
    {
        { "Aldo", "lalo2003" },
        { "Pedro", "Damian2025" },
        { "manager", "adminpass" }
    };

    public bool IsAuthenticated { get; private set; }
    public string AuthenticatedUser { get; private set; }

    public Task<bool> LoginAsync(string username, string password)
    {
        if (users.TryGetValue(username, out var storedPassword) && storedPassword == password)
        {
            IsAuthenticated = true;
            AuthenticatedUser = username;
            return Task.FromResult(true);
        }

        return Task.FromResult(false);
    }

    public Task LogoutAsync()
    {
        IsAuthenticated = false;
        AuthenticatedUser = string.Empty;
        return Task.CompletedTask;
    }
}
