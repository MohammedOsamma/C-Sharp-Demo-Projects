
using System.Text;

namespace Password_Manager
{
    internal class Program
    {
        private static readonly Dictionary<string, string> _passwordEntries = new();
        static void Main(string[] args)
        {
            ReadPasswords();
            while (true)
            {
                Console.WriteLine("Please enter an option :");
                Console.WriteLine("1.List all password ");
                Console.WriteLine("2.Add /Change password ");
                Console.WriteLine("3.Get Password ");
                Console.WriteLine("4.Delete password ");
                
                var selectedOption = Console.ReadLine();

                if (selectedOption == "1")
                    ListAllPassword();
                else if (selectedOption == "2")
                    AddOrChangePassword();
                else if (selectedOption == "3")
                    GetPassword();
                else if (selectedOption == "4")
                    DeletePassword();
                else
                    Console.WriteLine("Invaild Option");

                Console.WriteLine("--------------------------------------------------");

             }
        }

        private static void DeletePassword()
        {
            Console.WriteLine("Please enter the Website / App name :");
            var appName = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
            {
                _passwordEntries.Remove(appName);
                SavePasswords();
            }
            else
                Console.WriteLine("Password not found.");
        }

        private static void GetPassword()
        {
            Console.WriteLine("Please enter the Website / App name :");
            var appName = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
                Console.WriteLine($"Your password is : {_passwordEntries[appName]}");
            else
                Console.WriteLine("Password not found . ");

        }

        private static void AddOrChangePassword()
        {
            Console.WriteLine("Please enter the Website / App name :");
            var appName = Console.ReadLine();
            Console.WriteLine("Please enter the Password :");
            var password = Console.ReadLine();  

            if (_passwordEntries.ContainsKey(appName))
                _passwordEntries[appName] = password;
                
            else 
                _passwordEntries.Add(appName, password);         
        
            
            SavePasswords();
        }

        private static void ListAllPassword()
        {
            foreach (var entry in _passwordEntries)
            {
                Console.WriteLine($"{entry.Key} = {entry.Value}");
            }
        }

        private static void ReadPasswords()
        {
            if (File.Exists("Passwords.txt"))
            {
                var passwordLine = File.ReadAllText("Passwords.txt");
                
                foreach (var line in passwordLine.Split(Environment.NewLine)) {
                
                    if (!string.IsNullOrEmpty(line))
                    {
                        var equalIndex =line.IndexOf('=');  
                        var appName = line.Substring(0, equalIndex);
                        var password = line.Substring(equalIndex + 1);
                        _passwordEntries.Add(appName,EncryptionUtilty.Decrypt(password));

                    }
                }
            }
            
        }
        private static void SavePasswords()
        {
            var sb = new StringBuilder();
            foreach (var entry in _passwordEntries)
                sb.AppendLine($"{entry.Key}={EncryptionUtilty.Encrypt(entry.Value)}");

            File.WriteAllText("Passwords.txt",sb.ToString());

        }
    }
}
