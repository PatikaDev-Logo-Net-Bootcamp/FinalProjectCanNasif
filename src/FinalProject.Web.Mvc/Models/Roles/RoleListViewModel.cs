using System.Collections.Generic;
using FinalProject.Roles.Dto;

namespace FinalProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
