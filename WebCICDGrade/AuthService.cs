using System;
using System.Collections.Generic;

namespace GradeSystem
{
    public static class AuthService
    {
        // Simulated DB with multiple users
        private static readonly Dictionary<string, string> Users = new()
        {
            { "admin", "admin123" },
            { "user1", "pass1" },
            { "user2", "pass2" }
        };

        public static bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            return Users.TryGetValue(username, out string? storedPass) &&
       storedPass == password;
        }
    }
}
