﻿using System.Text.Json.Serialization;

namespace JWT.Domain.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public List<Role> Roles { get; set; }


    }
}
