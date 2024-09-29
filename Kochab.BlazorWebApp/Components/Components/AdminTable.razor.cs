using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;

namespace Kochab.BlazorWebApp.Components.Components;

[CascadingTypeParameter(nameof(TItem))]
public partial class AdminTable<TItem> where TItem : class, new()
{
    [NotNull]
    [Parameter]
    public RenderFragment<TItem>? TableColumns { get; set; }
}