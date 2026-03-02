using System;
using System.Diagnostics;

namespace GradeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Grade System ===\n");

            Console.Write("Enter username: ");
            string? username = Console.ReadLine();

            Console.Write("Enter password: ");
            string? password = Console.ReadLine();

            // ✅ Null / empty validation (IMPORTANT)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("\nUsername or password cannot be empty.");
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
                return;
            }

            // Safe call (no warning now)
            bool isAuthenticated = AuthService.Login(username, password);

            if (isAuthenticated)
            {
                Console.WriteLine($"\nLogin Successful! Welcome, {username}");
                string baseDir = AppContext.BaseDirectory;
                string projectRoot = Path.GetFullPath(
                    Path.Combine(baseDir, @"..\..\..\")
                );

                // HTML path (outside bin)
                string htmlPath = Path.Combine(projectRoot, "Index.html");

                if (File.Exists(htmlPath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = htmlPath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    Console.WriteLine("dashboard.html not found!");
                    Console.WriteLine(htmlPath);
                }
            }
            else
            {
                Console.WriteLine("\nInvalid username or password. Try again.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
