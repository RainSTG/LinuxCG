using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Машина: {1}{0}ОС: {2}{0}Пользователь: {3}{0}", Environment.NewLine, Environment.MachineName, Environment.OSVersion, Environment.UserName);