﻿using Microsoft.AspNetCore.Components;

namespace Smart.Design.Blazor;

public partial class SmartToolbarItem
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}