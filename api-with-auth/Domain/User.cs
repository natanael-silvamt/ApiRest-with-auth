using System;
using System.Collections.Generic;

namespace api_with_auth.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public List<UserPermission> UserPermissions { get; private set; } = new();
    }
}
