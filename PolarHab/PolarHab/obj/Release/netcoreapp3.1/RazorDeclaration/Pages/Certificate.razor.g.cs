#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7e04a6c7d0345564128c651ca77c4c9da8225c4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PolarHab.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using PolarHab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using PolarHab.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/certificate")]
    public partial class Certificate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor"
       
    public string StudentName { get; set; }
    public bool allCompleted = false;
    private async void CanvasUwu()
    {
        await JSRuntime.InvokeVoidAsync("AddCanvas");
    }
    private async void InputChange(KeyboardEventArgs e)
    {
        this.StateHasChanged();
    }
    public async void EXPSystem()
    {
        var result = await JSRuntime.InvokeAsync<string>("blazorExtensions.ReadCookie");
        var cookies = result.Split("; ");
        if(((double)cookies.ToList().Where(x => x.Contains("quizCompleted") || x.Contains("activityCompleted")).ToList().Count / 12) >= 1)
        {
            allCompleted = true;
        }
        this.StateHasChanged();
    }
    protected override async Task OnInitializedAsync()
    {
        EXPSystem();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
