#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "366ab73fe64d7c14ae02245c607d8c2047a5cf99"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/adopt")]
    public partial class AdoptAPolarBear : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .centered {
        position: absolute;
        top: 49%;
        left: 50%;
        transform: translate(-50%, -50%);
    }
    .typetag {
        position: absolute;
        transform: translate(-50%, -50%);
    }
    .date {
        position: absolute;
        top: 57.5%;
        left: 38.5%;
        transform: translate(-50%, -50%);
    }

    .container {
        position: relative;
        text-align: center;
        color: black;
    }
</style>


");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "text-align:center;margin-top:10px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "input-group mb-3");
            __builder.AddAttribute(6, "style", "text-align:center;width:900px;display:inline-block");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<div class=\"input-group-prepend\" style=\"display:inline-block\">\r\n        <span class=\"input-group-text\" id=\"basic-addon1\" style=\"width:100px;text-align:center\">Bear Name</span>\r\n        </div>\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "maxlength", "17");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                                                             InputChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "placeholder", "Imaex Ample");
            __builder.AddAttribute(15, "aria-label", "Name");
            __builder.AddAttribute(16, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(17, "style", "display:inline-block;width:796px");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                                      BearName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => BearName = __value, BearName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "text-align:center;margin-top:10px");
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "input-group mb-3");
            __builder.AddAttribute(28, "style", "text-align:center; width:900px;display:inline-block");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.AddMarkupContent(30, "<div class=\"input-group-prepend\" style=\"display:inline-block\">\r\n        <span class=\"input-group-text\" id=\"basic-addon1\" style=\"width:100px;text-align:center\">Bear Age</span>\r\n        </div>\r\n        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "number");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                                               InputChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "placeholder", "0");
            __builder.AddAttribute(36, "aria-label", "Name");
            __builder.AddAttribute(37, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(38, "style", "display:inline-block;width:796px");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                         BearAge

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => BearAge = __value, BearAge, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "text-align:center");
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "table");
            __builder.AddAttribute(48, "style", "width:900px;display:inline-block");
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.AddMarkupContent(50, "<tr style=\"width:100%\">\r\n            <th style=\"width:300px\">Favorite Food</th>\r\n            <th style=\"width:300px\">Favorite Sight</th>\r\n            <th style=\"width:300px\">Favorite Activity</th>\r\n        </tr>\r\n        ");
            __builder.OpenElement(51, "tr");
            __builder.AddAttribute(52, "style", "width:100%");
            __builder.AddMarkupContent(53, "\r\n           ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "style", "width:300px");
            __builder.AddMarkupContent(56, "\r\n               ");
            __builder.OpenElement(57, "select");
            __builder.AddAttribute(58, "class", "custom-select");
            __builder.AddAttribute(59, "style", "margin:10px");
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                                            FavFood

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "\r\n                   ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", "Watermelons");
            __builder.AddContent(64, "Watermelons");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                   ");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "Moose Meat");
            __builder.AddContent(68, "Moose Meat");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                   ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "Seal Blubber");
            __builder.AddContent(72, "Seal Blubber");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                   ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "Berries");
            __builder.AddContent(76, "Berries");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n           ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "style", "width:300px");
            __builder.AddMarkupContent(82, "\r\n               ");
            __builder.OpenElement(83, "select");
            __builder.AddAttribute(84, "class", "custom-select");
            __builder.AddAttribute(85, "style", "margin:10px");
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                                            FavSight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "\r\n                   ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", "The Mountains");
            __builder.AddContent(90, "The Mountains");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                   ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", "The Ocean");
            __builder.AddContent(94, "The Ocean");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                   ");
            __builder.OpenElement(96, "option");
            __builder.AddAttribute(97, "value", "The City");
            __builder.AddContent(98, "The City");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                   ");
            __builder.OpenElement(100, "option");
            __builder.AddAttribute(101, "value", "The Open Road");
            __builder.AddContent(102, "The Open Road");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n           ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, " \r\n            ");
            __builder.OpenElement(106, "td");
            __builder.AddAttribute(107, "style", "width:300px");
            __builder.AddMarkupContent(108, "\r\n               ");
            __builder.OpenElement(109, "select");
            __builder.AddAttribute(110, "class", "custom-select");
            __builder.AddAttribute(111, "style", "margin:10px");
            __builder.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                                            FavActivity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(113, "\r\n                   ");
            __builder.OpenElement(114, "option");
            __builder.AddAttribute(115, "value", "Swimming");
            __builder.AddContent(116, "Swimming");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                   ");
            __builder.OpenElement(118, "option");
            __builder.AddAttribute(119, "value", "Sleeping");
            __builder.AddContent(120, "Sleeping");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                   ");
            __builder.OpenElement(122, "option");
            __builder.AddAttribute(123, "value", "Eating");
            __builder.AddContent(124, "Eating");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                   ");
            __builder.OpenElement(126, "option");
            __builder.AddAttribute(127, "value", "Playing");
            __builder.AddContent(128, "Playing");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                   ");
            __builder.OpenElement(130, "option");
            __builder.AddAttribute(131, "value", "Hunting");
            __builder.AddContent(132, "Hunting");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n           ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, " \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "style", "text-align:center;margin-top:20px");
            __builder.AddMarkupContent(141, "\r\n    ");
            __builder.AddMarkupContent(142, @"<div class=""container"" style=""display:inline-block;padding:0px;margin:0px"">
        <div id=""capture"" style=""background-color:black;width:1000px;display:inline-block;text-align:center"">
            <img src=""images/AdoptCertificate.png"" style=""display:inline-block;width:1000px"">
            <span class=""centered"" style=""font-size:40px;font-family:'Century Gothic',Tahoma;text-align:left"">DSAJKSDJKJK</span>
        </div>
            
    </div>
    ");
            __builder.OpenElement(143, "button");
            __builder.AddAttribute(144, "class", "btn btn-primary");
            __builder.AddAttribute(145, "style", "display:inline-block;width:1000px;margin-bottom:10px");
            __builder.AddAttribute(146, "disabled", 
#nullable restore
#line 89 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                                                                             BearName != null? (BearName.Length>0? false:true):true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
                                                                                                                                                                                CanvasUwu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(148, "Download Page");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\AdoptAPolarBear.razor"
       
    public string BearName { get; set; }
    public int BearAge { get; set; }
    public string FavoriteFood = "Watermelons";
    public string FavoriteSight = "The Mountains";
    public string FavoriteActivity = "Swimming";
    protected void FavFood(ChangeEventArgs e)
    {
        FavoriteFood = e.Value.ToString();
    }
    protected void FavSight(ChangeEventArgs e)
    {
        FavoriteSight = e.Value.ToString();
    }
    protected void FavActivity(ChangeEventArgs e)
    {
        FavoriteActivity = e.Value.ToString();
    }
    private async void InputChange(KeyboardEventArgs e)
    {
        this.StateHasChanged();
    } 
    private async void CanvasUwu()
    {
        await JSRuntime.InvokeVoidAsync("AddCanvas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
