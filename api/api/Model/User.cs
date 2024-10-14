﻿using System.Text.Json.Serialization;

namespace api.Model
{
    public class User : TEntity
    {

        public Guid Id { get; set; }  
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
