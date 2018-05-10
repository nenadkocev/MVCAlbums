using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace primerKolokviumska2.Models
{
    public class AddUserToRoleModel
    {
        public string Email { get; set; }
        public string SelectedRole { get; set; }
        public List<string> roles { get; set; }

        public AddUserToRoleModel()
        {
            roles = new List<string> { UserRole.Administrator, UserRole.Editor, UserRole.User };
        }
    }
}