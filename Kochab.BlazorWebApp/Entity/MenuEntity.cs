using System.ComponentModel;
using FreeSql;
using FreeSql.DataAnnotations;

namespace Kochab.BlazorWebApp.Entity;

[Description("菜单表")]
public class MenuEntity : BaseEntity<MenuEntity, int>
{
    [Description("菜单名")]
    public string? MenuName { get; set; }
    [Description("Url")]
    public string? Url { get; set; }
    [Description("图标")]
    public string? Icon { get; set; }
    public int ParentId { get; set; }
    
    [Navigate(nameof(ParentId))]
    public MenuEntity? Parent { get; set; }
    
    [Navigate(nameof(ParentId))]
    public List<MenuEntity>? Children { get; set; }
    
    [Navigate(ManyToMany = typeof(RoleMenuEntity))]
    public List<RoleEntity>? Roles { get; set; }
}