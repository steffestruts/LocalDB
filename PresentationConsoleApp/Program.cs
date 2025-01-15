using Data.Entities;
using Data.Interfaces;
using Data.Repositories;
using System.Runtime.InteropServices;

IUserRepository userRepository = new UserRepository();

#region Create User Dialog 

var userEntity = new UserEntity();

Console.Write("Förnamn: ");
userEntity.FirstName = Console.ReadLine()!;

Console.Write("Efternamn: ");
userEntity.LastName = Console.ReadLine()!;

Console.Write("E-post: ");
userEntity.Email = Console.ReadLine()!;

Console.Write("Telefon: ");
userEntity.PhoneNumber = Console.ReadLine();

var result = userRepository.Create(userEntity);
if (result)
{
    Console.WriteLine("User created successfully");
}
else
{
    Console.WriteLine("Failed to create user");
}

Console.ReadKey();
Console.Clear();

#endregion

#region Show All Users 

var users = userRepository.GetAll();

foreach (var user in users)
{
    Console.WriteLine($"#{user.Id}, {user.FirstName} {user.LastName} <{user.Email}>");
}

Console.ReadKey();

#endregion