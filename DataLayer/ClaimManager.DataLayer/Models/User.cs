﻿namespace ClaimManager.DataLayer.Models
{
    public class User
    {
        public int UserId { get; set; }
        
        public string UserName { get; set; }
        
        public string DisplayName { get; set; }
        
        public string Password { get; set; }
        
        public bool Active { get; set; }
    }
}