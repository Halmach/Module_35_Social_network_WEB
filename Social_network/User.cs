﻿using Microsoft.AspNetCore.Identity;

namespace Social_network
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string MiddleName { get; set; }  
        public DateTime BirthDate { get; set; } 
    }
}
