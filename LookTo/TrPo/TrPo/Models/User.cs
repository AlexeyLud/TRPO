using System.Collections.Generic;

namespace TrPo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }

    public class Translation
    {
        public int Id { get; set; }
        public string Name { get; set; } //а зачем название???
        public string Code { get; set; }
        public string Condition { get; set; }
    }

    public class BroadcastList
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; } // planned or viewed
    }
}
