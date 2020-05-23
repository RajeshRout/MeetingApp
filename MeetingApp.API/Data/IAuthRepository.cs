using System.Threading.Tasks;
using MeetingApp.API.Models;

namespace MeetingApp.API.Data
{
    public interface IAuthRepository
    {
         Task <User> Register (User user, string password);
         Task <User> Login (string userName, string password);
         Task <bool> UserExists (string userName);
    }
}

/* Notes on IAuthRepository:
1. We define the what all methods this interface will have, 3 in this case.
2. Methods defined here are used in controller, therefore added in ConfigureService/Startup.cs
3. How methods work are defined in AuthRepository
4. We have 3 methods in this interface: 1-Registring the user/ 2- Logging 
   the user/ 3- Check if the user exists as the name must be unique
   4.1- Register method will be provided with user/ password and 
   this method will return User;
   4.2- Login method will be provided with userName/ password and 
   this method will return User;
   4.1- UserExists method will be provided with userName and this 
   method will return true/false i.e if the user exists or not.
*/