using System.Collections.Generic;
using YarnViewer.Roles.Dto;

namespace YarnViewer.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}