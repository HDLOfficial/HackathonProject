#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ClimateChangeInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9516b751c116758f03f5c36b41990ad57aba65fd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/climate")]
    public partial class ClimateChangeInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<html lang=\"en\">\r\n<head>\r\n<style>\r\n    /* nav bar */\r\n    nav {\r\n        background-color: #333;\r\n        border-radius: 0px 0px 15px 15px;\r\n    }\r\n        /* list of pages */\r\n        nav ul {\r\n            margin: 0;\r\n            padding: 0;\r\n            list-style: none;\r\n            text-align: center;\r\n        }\r\n        /* nav list items */\r\n        nav li {\r\n            display: inline-block;\r\n            margin-left: 70px;\r\n            padding-top: 20px;\r\n            padding-bottom: 20px;\r\n            position: relative;\r\n            transition: letter-spacing 0.5s;\r\n            font-family: \'Century Gothic\',Tahoma\r\n        }\r\n        /* nav text */\r\n        nav a {\r\n            color: white;\r\n            text-decoration: none;\r\n            font-family: \'Century Gothic\',Tahoma;\r\n            font-size: 20px;\r\n            transition: letter-spacing 0.5s;\r\n        }\r\n            /* nav active */\r\n            nav a:hover {\r\n                letter-spacing: 1px;\r\n                transition: all ease-in-out 250ms;\r\n                color: white;\r\n                text-decoration: none;\r\n            }\r\n            /* nav top line */\r\n            nav a::before {\r\n                content: \'\';\r\n                display: block;\r\n                height: 5px;\r\n                background-color: white;\r\n                position: absolute;\r\n                width: 0%;\r\n                top: 0;\r\n                transition: all ease-in-out 250ms;\r\n            }\r\n            /* nav top line active */\r\n            nav a:hover::before {\r\n                width: 95%;\r\n            }\r\nbody {\r\n\tfont-family: \'Century Gothic\',Tahoma; \r\n\tmargin: 0\r\n}\r\n\r\n.header {\r\n\tpadding:80px;\r\n\ttext-align: center;\r\n\tbackground: #86a3c3;\r\n\tcolor: white;\r\n    border-radius: 15px 15px 0px 0px;\r\n}\r\n\r\n.header h1{\r\n\tfont-size: 40px;\r\n}\r\n\r\n.main {\r\n\t-ms-flex: 80%;\r\n\tflex:80%;\r\n\tbackground: white;\r\n}\r\n\r\n.footer{\r\n\tpadding: 20px;\r\n\ttext-align: center;\r\n\tbackground-color: #7268a6; \r\n\tcolor: \"white\";\r\n}\r\n\r\na:link, a:visited{\r\n\tcolor: white;\r\n}\r\n\r\na:hover, a:active{\r\n\tcolor: white;\r\n}\r\n\r\n</style>\r\n</head>\r\n<body>\r\n\r\n    <div class=\"header\">\r\n        <h1>Climate Change</h1>\r\n    </div>\r\n\r\n    <nav>\r\n        <ul>\r\n            <li><a href=\"/\">Home</a></li>\r\n            <li><a href=\"/menu\">Activities</a></li>\r\n            <li><a href=\"/climate\">About Climate Change</a></li>\r\n            <li><a href=\"/videos\">More Videos</a></li>\r\n            <li><a href=\"/timeline\">Timeline</a></li>\r\n            <li><a href=\"/about\">The Bears</a></li>\r\n            <li><a href=\"/bearnames\">About</a></li>\r\n        </ul>\r\n    </nav>\r\n\r\n    <div class=\"main\">\r\n        <br>\r\n        <br>\r\n        <h5>Let\'s start by talking about Greenhouse Gases:</h5>\r\n        <br>\r\n        <p>\r\n            Earth gets most of its heat from the sun. The sun emits heat waves through radiation that hit the Earth’s surface and make it warmer. Normally, these heat waves would just bounce off the atmosphere of the Earth and go back into space, but gases in the earth’s ozone layer called greenhouse gases insulate the Earth and trap the heat. Earth already has a natural greenhouse layer, but lately human activities have been changing this natural greenhouse. A common greenhouse gas is CO2 or carbon dioxide. In the last couple centuries, humans have been burning coal, oil, and natural gases for energy. In this process, large amounts of carbon dioxide are released into the atmosphere. This is causing Earth’s natural greenhouse to become filled with more and more carbon dioxide with little to no way to reduce the amount. This is especially problematic due to deforestation. The amount of carbon dioxide is too much for plants to convert back into oxygen as they go through photosynthesis. This leads to more radiation getting trapped in the Earth’s atmosphere, causing temperatures to rise. This process is called global warming. Global warming is a huge issue today. Many habitats in colder areas are getting destroyed. This leads to shifts in the balance of the ecosystem which affect every single organism living in said ecosystem.\r\n        </p>\r\n        <br>\r\n        <img src=\"https://upload.wikimedia.org/wikipedia/commons/0/04/Greenhouse-effect-t2.svg\" width=\"600px\" height=\"300px\">\r\n        <br>\r\n        <hr>\r\n        <br>\r\n        <h5>Some Impacts of this on the World: </h5>\r\n        <br>\r\n        <p>\r\n            Climate change doesn’t only affect the Arctic. It also negatively affects many other parts of the world. Climate change causes sea levels to rise, which is destructive to  inland coastal habitats through erosion, flooding, and contamination, destroying many fish, bird, and plant habitats. Another way climate change is harming Earth is through shrinking/melting of mountain glaciers. This adds to rising sea levels and has devastating effects in melting areas through very large amounts of erosion. Melting glaciers also causes more frequent hurricanes and typhoons. Melting glacier ice can even affect weather patterns, as when ice melts, it creates darker patches in the ocean that make areas around the poles warmer, which disrupts nearby ocean circulation, causing many coastal storms.\r\n        </p>\r\n        <p>\r\n            In general, the change in flowers and vegetation will not affect the polar bears but it will affect climate change. Arctic vegetation is usually low, small, and close to the ground as the frozen soil usually doesn’t contain much nutrients. As the soil starts to thaw it releases both more nutrients and greenhouse gases. The nutrients in the soil lead to plants growing faster and taller. Unfortunately, researchers believe that this will only cause more trouble. Taller plants actually help speed up global warming as they trap snow, which then act as insulators, making it harder for the soil to freeze. This leads to the soil thawing. The Arctic permafrost contains large amounts of organic carbon in the form of peat. As the soil thaws, the organic matter decomposes producing carbon dioxide and methane (another greenhouse gas). Scientists are especially worried due to the fact that the Artic’s permafrost contains 30-50% of the world’s soil carbon. If the permafrost continues to melt, this can lead to disastrous consequences for our planet.\r\n        </p>\r\n        <br>\r\n        <img src=\"https://imagecache.jpl.nasa.gov/images/edu/activities/omg_ice-640x350.jpg\" width=\"600px\" height=\"300px\">\r\n        <br>\r\n        <hr>\r\n        <br>\r\n        <h5>Poor Polar Bears and How You can Help: </h5>\r\n        <br>\r\n        <p>\r\n            Polar bear’s primary habitat is sea ice. It’s also used as a platform to hunt seals. All 19 subpopulations of polar bears have experienced at least some level of ice loss. According to recent data, Arctic temperatures are rising at least twice as much as the global average. The sea ice cover is also decreasing by as much as 4 percent every decade.\r\n\r\n            This is very important due to the fact that polar bears use this ice as a platform to hunt seals. Seals make up the majority of a polar bear’s diet. Studies show that a polar bear can eat up to 43 ringed seals yearly. A seal around 120 lbs can provide a polar bear energy for 8 days. From this, it’s easy to infer that the early reduction in sea ice makes it harder for polar bears to catch seals in the later seasons. Due to this, polar bears have less time to catch and store fat. This can lead to lower fat storages which can lead to failed pregnancies or the cubs or mother dying very early.\r\n\r\n            Unusually warm weather can also lead to the female’s dens to collapse. The cubs are then subjected to conditions they aren’t yet ready for. This can lead to contamination and higher risk of disease.\r\n        </p>\r\n        <br>\r\n        <img src=\"images/Inukshuk Pool.jpg\" height=\"400px\" width=\"600px\">\r\n        <br>\r\n        <hr>\r\n        <br>\r\n    </div>\r\n\r\n    <div class=\"footer\">\r\n        <h2> Here are a few links to websites that you can use to help out! </h2>\r\n        <a href=\"https://canadianpolarbearhabitat.com/ways-to-help/\">Canadian Polar Bear Website</a>\r\n        <br>\r\n        <a href=\"https://climatekids.nasa.gov/climate-change-meaning/\">NASA Learn More</a>\r\n        <br>\r\n        <a href=\"https://www.carbonbrief.org/polar-bears-and-climate-change-what-does-the-science-say#:~:text=There%20are%20other%20impacts%20of,birth%20and%20protect%20their%20young.\">Carbonbrief.org</a>\r\n        <br>\r\n        <a href=\"https://support.worldwildlife.org/site/Donation2?df_id=14597&14597.donation=form1&s_src=AWE1811OQ18710A01688RX&msclkid=0fa9b9d0799c1bcdabeae69a015c208c&utm_source=bing&utm_medium=cpc&utm_campaign=Wildlife%20Save%20-%20Species&utm_term=donate%20to%20help%20polar%20bears&utm_content=Save%20and%20Protect%20Polar%20Bears\">Donate to World Wildlife Foundation</a>\r\n        <br>\r\n        <a href=\"https://svs.gsfc.nasa.gov/20114#:~:text=The%20\'greenhouse%20effect\'%20is%20the,heat%20from%20escaping%20into%20space\">NASA Greenhouse Gases</a>\r\n        <br>\r\n        <a href=\"https://www.ecowatch.com/arctic-plant-growth-climate-change-2608352963.html#:~:text=Climate%20change%20is%20giving%20Arctic,taller%20at%20all%20locations%20studied\">Ecowatch</a>\r\n        <br>\r\n        <a href=\"https://arcticwwf.org/species/polar-bear/\">Artic WWF</a>\r\n    </div>\r\n</body>\r\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
