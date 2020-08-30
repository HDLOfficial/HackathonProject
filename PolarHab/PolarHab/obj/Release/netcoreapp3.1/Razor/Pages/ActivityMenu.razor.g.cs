#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0b5f669b25e73325fe0a4b8bc3d87606e14135"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/menu")]
    public partial class ActivityMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    header {\r\n        padding: 80px;\r\n        text-align: center;\r\n        background: #86a3c3;\r\n        color: white;\r\n        border-radius: 15px 15px 0px 0px;\r\n    }\r\n    /* nav bar */\r\n    nav {\r\n        background-color: #333;\r\n        margin-bottom: 25px;\r\n        border-radius: 0px 0px 15px 15px;\r\n    }\r\n        /* list of pages */\r\n        nav ul {\r\n            margin: 0;\r\n            padding: 0;\r\n            list-style: none;\r\n            text-align: center;\r\n        }\r\n        /* nav list items */\r\n        nav li {\r\n            display: inline-block;\r\n            margin-left: 70px;\r\n            padding-top: 20px;\r\n            padding-bottom: 20px;\r\n            position: relative;\r\n            transition: letter-spacing 0.5s;\r\n            font-family:\'Century Gothic\',Tahoma\r\n        }\r\n        /* nav text */\r\n        nav a {\r\n            color: white;\r\n            text-decoration: none;\r\n            font-family: \'Century Gothic\',Tahoma;\r\n            font-size: 20px;\r\n            transition: letter-spacing 0.5s;\r\n        }\r\n            /* nav active */\r\n            nav a:hover {\r\n                letter-spacing: 1px;\r\n                transition: all ease-in-out 250ms;\r\n                color: white;\r\n                text-decoration: none;\r\n            }\r\n            /* nav top line */\r\n            nav a::before {\r\n                content: \'\';\r\n                display: block;\r\n                height: 5px;\r\n                background-color: white;\r\n                position: absolute;\r\n                width: 0%;\r\n                top: 0;\r\n                transition: all ease-in-out 250ms;\r\n            }\r\n            /* nav top line active */\r\n            nav a:hover::before {\r\n                width: 95%;\r\n            }\r\n\r\n    .activity {\r\n        background-color: #f1f1f1;\r\n        transition: background-color 0.5s;\r\n    }\r\n\r\n        .activity:hover {\r\n            background-color: #e1e1e1;\r\n        }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<header>\r\n<h1 style=\"font-family: \'Century Gothic\',Tahoma\">All Activities</h1>\r\n</header>\r\n");
            __builder.AddMarkupContent(2, @"<nav>
    <ul>
        <li><a href=""/"">Home</a></li>
            <li><a href=""/menu"">Activities</a></li>
            <li><a href=""/climate"">About Climate Change</a></li>
            <li><a href=""/videos"">More Videos</a></li>
            <li><a href=""/timeline"">Timeline</a></li>
            <li><a href=""/bearnames"">The Bears</a></li>
            <li><a href=""/about"">About</a></li>
    </ul>
</nav>

");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "user-select:none");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, @"<div class=""shadow"" style=""width:80%;padding:20px;border-radius:8px"">
        <span class=""header"" style=""font-size:30px;font-family:'Century Gothic',Tahoma;font-weight:700"">
            Multiple Choice Exploration
        </span>
        <br>
        <span style=""text-wrap:normal;font-family:'Century Gothic',Tahoma"">
            Learn some cool facts about polar bears with mini questions!
        </span>
    </div>
    <br>
");
#nullable restore
#line 102 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
     for(int i = 0;i < (int)Math.Ceiling((double)quizQuestions.Count/3); i++)
    {
    if((quizQuestions.Count - (i*3)) > 2)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "onclick", "location.href=\'/guided-exploration/" + (
#nullable restore
#line 107 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                           quizQuestions.ToArray()[(i*3)].QuestionKey

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.AddAttribute(12, "class", "shadow-sm activity");
            __builder.AddAttribute(13, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(17, "class", "nonhover");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.AddContent(19, 
#nullable restore
#line 109 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                 quizQuestions.ToArray()[(i*3)].QuestionName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 109 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                                                        activityCookies.Contains("quizCompleted-"+quizQuestions.ToArray()[(i*3)].CookieTag+"=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "onclick", "location.href=\'/guided-exploration/" + (
#nullable restore
#line 112 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                           quizQuestions.ToArray()[(i*3)+1].QuestionKey

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.AddAttribute(29, "class", "shadow-sm activity");
            __builder.AddAttribute(30, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(34, "class", "nonhover");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddContent(36, 
#nullable restore
#line 114 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                 quizQuestions.ToArray()[(i*3)+1].QuestionName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, " ");
            __builder.OpenElement(38, "span");
            __builder.AddAttribute(39, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 114 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                                                          activityCookies.Contains("quizCompleted-"+quizQuestions.ToArray()[(i*3)+1].CookieTag+"=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "onclick", "location.href=\'/guided-exploration/" + (
#nullable restore
#line 117 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                           quizQuestions.ToArray()[(i*3)+2].QuestionKey

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.AddAttribute(46, "class", "shadow-sm activity");
            __builder.AddAttribute(47, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(51, "class", "nonhover");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.AddContent(53, 
#nullable restore
#line 119 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                 quizQuestions.ToArray()[(i*3)+2].QuestionName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, " ");
            __builder.OpenElement(55, "span");
            __builder.AddAttribute(56, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 119 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                                                          activityCookies.Contains("quizCompleted-"+quizQuestions.ToArray()[(i*3)+2].CookieTag+"=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 123 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
    }else if((quizQuestions.Count - (i*3)) > 1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "    ");
            __builder.OpenElement(63, "div");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "onclick", "location.href=\'/guided-exploration/" + (
#nullable restore
#line 126 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                           quizQuestions.ToArray()[(i*3)].QuestionKey

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.AddAttribute(67, "class", "shadow-sm activity");
            __builder.AddAttribute(68, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(72, "class", "nonhover");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.AddContent(74, 
#nullable restore
#line 128 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                 quizQuestions.ToArray()[(i*3)].QuestionName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(75, " ");
            __builder.OpenElement(76, "span");
            __builder.AddAttribute(77, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 128 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                                                        activityCookies.Contains("quizCompleted-"+quizQuestions.ToArray()[(i*3)].CookieTag+"=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "onclick", "location.href=\'/guided-exploration/" + (
#nullable restore
#line 131 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                           quizQuestions.ToArray()[(i*3)+1].QuestionKey

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.AddAttribute(84, "class", "shadow-sm activity");
            __builder.AddAttribute(85, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.OpenElement(87, "span");
            __builder.AddAttribute(88, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(89, "class", "nonhover");
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.AddContent(91, 
#nullable restore
#line 133 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                 quizQuestions.ToArray()[(i*3)+1].QuestionName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " ");
            __builder.OpenElement(93, "span");
            __builder.AddAttribute(94, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 133 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                                                          activityCookies.Contains("quizCompleted-"+quizQuestions.ToArray()[(i*3)+1].CookieTag+"=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(95, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 137 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "    ");
            __builder.OpenElement(101, "div");
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "onclick", "location.href=\'/guided-exploration" + (
#nullable restore
#line 141 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                          quizQuestions.ToArray()[(i*3)].QuestionKey

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.AddAttribute(105, "class", "shadow-sm activity");
            __builder.AddAttribute(106, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "span");
            __builder.AddAttribute(109, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(110, "class", "nonhover");
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.AddContent(112, 
#nullable restore
#line 143 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                 quizQuestions.ToArray()[(i*3)].QuestionName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(113, " ");
            __builder.OpenElement(114, "span");
            __builder.AddAttribute(115, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 143 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                                                        activityCookies.Contains("quizCompleted-"+quizQuestions.ToArray()[(i*3)].CookieTag+"=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(116, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 147 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
    }

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(121, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(122, @"<div class=""shadow"" style=""width:80%;padding:20px;border-radius:8px"">
        <span style=""font-size:30px;font-family:'Century Gothic',Tahoma;font-weight:700"">
            Interactive Activities
        </span>
        <br>
        <span style=""text-wrap:normal;font-family:'Century Gothic',Tahoma"">
            See the 4 polar bears of the Canadian Polar Bear Habitat while testing your memory and skills.
        </span>
    </div>
    <br>
    ");
            __builder.OpenElement(123, "div");
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "onclick", "location.href=\'/matching\'");
            __builder.AddAttribute(127, "class", "shadow-sm activity");
            __builder.AddAttribute(128, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(129, "\r\n            ");
            __builder.OpenElement(130, "span");
            __builder.AddAttribute(131, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(132, "class", "nonhover");
            __builder.AddMarkupContent(133, "\r\n                Memory Matching ");
            __builder.OpenElement(134, "span");
            __builder.AddAttribute(135, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 165 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                           activityCookies.Contains("activityCompleted-matching=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(136, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n        ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "onclick", "location.href=\'/findoutquiz\'");
            __builder.AddAttribute(142, "class", "shadow-sm activity");
            __builder.AddAttribute(143, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(144, "\r\n            ");
            __builder.OpenElement(145, "span");
            __builder.AddAttribute(146, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(147, "class", "nonhover");
            __builder.AddMarkupContent(148, "\r\n                Which Bear are you? ");
            __builder.OpenElement(149, "span");
            __builder.AddAttribute(150, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 170 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                               activityCookies.Contains("activityCompleted-findout=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(151, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(156, @"<div class=""shadow"" style=""width:80%;padding:20px;border-radius:8px"">
        <span style=""font-size:30px;font-family:'Century Gothic',Tahoma;font-weight:700"">
            Downloadable Content
        </span>
        <br>
        <span style=""text-wrap:normal;font-family:'Century Gothic',Tahoma"">
            Print these out and learn about the wonders of polar bears!
        </span>
    </div>
    <br>
    ");
            __builder.OpenElement(157, "div");
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "onclick", "location.href=\'/wordsearch\'");
            __builder.AddAttribute(161, "class", "shadow-sm activity");
            __builder.AddAttribute(162, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(163, "\r\n            ");
            __builder.OpenElement(164, "span");
            __builder.AddAttribute(165, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(166, "class", "nonhover");
            __builder.AddMarkupContent(167, "\r\n                Word Search ");
            __builder.OpenElement(168, "span");
            __builder.AddAttribute(169, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 189 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                       activityCookies.Contains("activityCompleted-wordsearch=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(170, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n        ");
            __builder.OpenElement(174, "div");
            __builder.AddAttribute(175, "onclick", "location.href=\'/coloringpages\'");
            __builder.AddAttribute(176, "class", "shadow-sm activity");
            __builder.AddAttribute(177, "style", "padding:10px;width:20%;text-align:center;cursor:pointer;border-radius:8px;display:inline-block;margin:10px");
            __builder.AddMarkupContent(178, "\r\n            ");
            __builder.OpenElement(179, "span");
            __builder.AddAttribute(180, "style", "text-wrap:normal;font-family:\'Century Gothic\',Tahoma");
            __builder.AddAttribute(181, "class", "nonhover");
            __builder.AddMarkupContent(182, "\r\n                Coloring Pages ");
            __builder.OpenElement(183, "span");
            __builder.AddAttribute(184, "style", "background-color:mediumseagreen;font-size:10px;margin:5px;border-radius:4px;color:white;padding:5px;display:" + (
#nullable restore
#line 194 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
                                                                                                                                                          activityCookies.Contains("activityCompleted-coloringpages=true")? "inline" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(185, "Completed");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n    <br>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityMenu.razor"
       
    private string[] activityCookies = new string[1] { "uwu" };
    public List<PolarHab.DbAssets.Question> quizQuestions = new List<DbAssets.Question>();
    public async void GetCookies()
    {
    var result = await JSRuntime.InvokeAsync<string>("blazorExtensions.ReadCookie", "quizCompleted-food", "true", 5);
    var cookies = result.Split("; ");
    activityCookies = cookies;
    Console.WriteLine(cookies);
    this.StateHasChanged();
    }
    protected override async Task OnInitializedAsync()
    {
    using(var db = new PolarHab.DbAssets.ActivityContext())
    {
    quizQuestions = db.Questions.ToList();
    }
    GetCookies();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
