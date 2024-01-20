using SMSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMSystem.Core
{
    public class UsersRoles
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public bool Value { get; set; }

        // Navigations
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
