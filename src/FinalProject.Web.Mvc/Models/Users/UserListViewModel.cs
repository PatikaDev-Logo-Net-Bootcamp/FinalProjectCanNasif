using System.Collections.Generic;
using FinalProject.Roles.Dto;

namespace FinalProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
