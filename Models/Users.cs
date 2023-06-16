using System.ComponentModel.DataAnnotations;

namespace MyHomepage.Models
{
    public class UsersModel
    {
        public string Username { get; set; }

        [DataType(DataType.Password)] public string Password { get; set; }
    }
}