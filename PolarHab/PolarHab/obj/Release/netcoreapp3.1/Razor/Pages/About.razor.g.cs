#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73caa058150fab67c50c2084153551051c3e551a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.AddMarkupContent(1, "<html lang=\"en\">\r\n<head>\r\n<title>Page Title</title>\r\n<meta charset=\"UTF-8\">\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n<style>\r\n* {\r\n  box-sizing: border-box;\r\n}\r\n    /* nav bar */\r\n    nav {\r\n        background-color: #333;\r\n        border-radius: 0px 0px 15px 15px;\r\n    }\r\n        /* list of pages */\r\n        nav ul {\r\n            margin: 0;\r\n            padding: 0;\r\n            list-style: none;\r\n            text-align: center;\r\n        }\r\n        /* nav list items */\r\n        nav li {\r\n            display: inline-block;\r\n            margin-left: 70px;\r\n            padding-top: 20px;\r\n            padding-bottom: 20px;\r\n            position: relative;\r\n            transition: letter-spacing 0.5s;\r\n            font-family:\r\n\r\n        }\r\n        /* nav text */\r\n        nav a {\r\n            color: white;\r\n            text-decoration: none;\r\n            font-family: \'Century Gothic\',Tahoma;\r\n            font-size: 20px;\r\n            transition: letter-spacing 0.5s;\r\n        }\r\n            /* nav active */\r\n            nav a:hover {\r\n                letter-spacing: 1px;\r\n                transition: all ease-in-out 250ms;\r\n                color: white;\r\n                text-decoration: none;\r\n            }\r\n            /* nav top line */\r\n            nav a::before {\r\n                content: \'\';\r\n                display: block;\r\n                height: 5px;\r\n                background-color: white;\r\n                position: absolute;\r\n                width: 0%;\r\n                top: 0;\r\n                transition: all ease-in-out 250ms;\r\n            }\r\n            /* nav top line active */\r\n            nav a:hover::before {\r\n                width: 95%;\r\n            }\r\n/* Style the body */\r\nbody {\r\n  font-family: url();\r\n  margin: 0;\r\n}\r\n\r\n/* Header/logo Title */\r\n.header {\r\n  padding: 80px;\r\n  text-align: center;\r\n  background: #86a3c3;\r\n  color: white;\r\n  border-radius: 15px 15px 0px 0px;\r\n}\r\n\r\n/* Increase the font size of the heading */\r\n.header h1 {\r\n  font-size: 40px;\r\n}\r\n\r\n.navbar {\r\n  overflow: hidden;\r\n  background-color: #333;\r\n  position: sticky;\r\n  position: -webkit-sticky;\r\n  top: 0;\r\n}\r\n\r\n/* Style the navigation bar links */\r\n.navbar a {\r\n  float: left;\r\n  display: block;\r\n  color: white;\r\n  text-align: center;\r\n  padding: 14px 20px;\r\n  text-decoration: none;\r\n}\r\n\r\n\r\n/* Main column */\r\n.main {   \r\n  -ms-flex: 70%; /* IE10 */\r\n  flex: 70%;\r\n  background-color: white;\r\n}\r\n\r\n\r\n</style>\r\n</head>\r\n<body>\r\n\r\n    <div class=\"header\">\r\n        <h1>About PolarHab</h1>\r\n    </div>\r\n\r\n    <nav>\r\n        <ul>\r\n             <li><a href=\"/\">Home</a></li>\r\n            <li><a href=\"/menu\">Activities</a></li>\r\n            <li><a href=\"/climate\">About Climate Change</a></li>\r\n            <li><a href=\"/videos\">More Videos</a></li>\r\n            <li><a href=\"/timeline\">Timeline</a></li>\r\n            <li><a href=\"/bearnames\">The Bears</a></li>\r\n            <li><a href=\"/about\">About</a></li>\r\n        </ul>\r\n    </nav>\r\n\r\n    <div class=\"main\">\r\n        <br>\r\n        <br>\r\n        <h2>About This Website</h2>\r\n        <h5>Created for the KURIUSHACKS Hackathon by David Reeves, Anwesha Pathak, Hashir Mian, and Vasudha Marur</h5>\r\n        <p>This website was made as a solution to the prompt given by the Canadian Polar Bear Habitats. It has various interactive activites and games that can be enjoyed by people of all ages. Additionally, it also has a lot of educational material to help people learn more about the Polar Bears.</p>\r\n        <br>\r\n        <hr>\r\n        <br>\r\n        <h2>Works Cited</h2>\r\n        <h5>A List of Sources Used</h5>\r\n        <br>\r\n        <p><b>Images</b></p>\r\n        <p>Dropbox for the Canadian Polar Bear Habitat: https://www.dropbox.com/sh/b0icoazpjnk3cp6/AAB25v8v5xm-iPaFNJp8gZERa/Photos?dl=0&subfolder_nav_tracking=1 </p>\r\n        <p>Polar Bear Image(Main Page): https://wallup.net/white-bear-tracks-snow-polar/ </p>\r\n        <p>One of Our Coloring Images: https://www.coloring-pages-kids.com/coloring-pages/animal-coloring-pages/zoo-animals-coloring-pages/zoo-animals-coloring-pages-images/zoo-animal-coloring-page-12.php </p>\r\n        <p>https://www.illustrationsof.com/1161628-royalty-free-polar-bear-clipart-illustration </p>\r\n        <p>https://www.jpl.nasa.gov/edu/teach/activity/whats-causing-sea-level-rise-land-ice-vs-sea-ice/</p>\r\n        <p>https://commons.wikimedia.org/wiki/File:Greenhouse-effect-t2.svg</p>\r\n        <br>\r\n        <hr>\r\n        <br>\r\n        <p><b>Informational Section</b></p>\r\n        <p>https://polarbearsinternational.org/polar-bears/life-cycle/</p>\r\n        <p>https://churchillpolarbears.org/about-polar-bears/polar-bear-life-cycle/</p>\r\n        <p>https://www.natgeokids.com/uk/discover/animals/general-animals/polar-bear-facts/ </p>\r\n        <p>https://www.wwf.org.uk/learn/fascinating-facts/polar-bears</p>\r\n        <p>https://www.livescience.com/27436-polar-bear-facts.html</p>\r\n        <p>https://seaworld.org/animals/all-about/polar-bear/senses/ </p>\r\n        <p>https://www.nationalgeographic.com/animals/mammals/b/brown-bear/</p>\r\n        <br>\r\n        <hr>\r\n    </div>\r\n\r\n</body>\r\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591