using System.ComponentModel;
using FreeSql.DataAnnotations;

namespace Kochab.BlazorWebApp.Entity;

[Description("角色菜单关系表")]
public class RoleMenuEntity
{
    [Column(IsPrimary = true)]
    public int RoleId { get; set; }

    [Column(IsPrimary = true)]
    public int MenuId { get; set; }
}