using System;

namespace api_with_auth.Domain
{
    public class UserPermission
    {
        private User? _user;
        private Permission? _permission;

        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }

        public Guid PermissionId { get; private set; }

    }
}
