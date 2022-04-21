using System.Collections.Generic;
using FinalProject.Roles.Dto;

namespace FinalProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}