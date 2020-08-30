#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Timeline.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5bd3e3b4d9bc0f183950d4554a87e17b6fc9c00"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/timeline")]
    public partial class Timeline : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.AddMarkupContent(1, "<html>\r\n<head>\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n<style>\r\n\r\n* {\r\n  box-sizing: border-box;\r\n  }\r\n\r\nbody {\r\n  background-color: #D8E0BB;\r\n  font-family: \'Century Gothic\';\r\n}\r\n\r\n/* The actual timeline (the vertical ruler) */\r\n.timeline {\r\n  position: relative;\r\n  max-width: 1200px;\r\n  margin: 0 auto;\r\n}\r\n\r\n/* The actual timeline (the vertical ruler) */\r\n.timeline::after {\r\n  content: \'\';\r\n  position: absolute;\r\n  width: 12px;\r\n  background-color: #86A3C3;\r\n  top: 0;\r\n  bottom: 0;\r\n  left: 50%;\r\n  margin-left: -3px;\r\n}\r\n\r\n/* Container around content */\r\n.container {\r\n  padding: 10px 40px;\r\n  position: relative;\r\n  background-color: inherit;\r\n  width: 50%;\r\n}\r\n\r\n/* The circles on the timeline */\r\n.container::after {\r\n  content: \'\';\r\n  position: absolute;\r\n  width: 25px;\r\n  height: 25px;\r\n  right: -17px;\r\n  background-color: white;\r\n  border: 4px solid #6B3074;\r\n  top: 15px;\r\n  border-radius: 50%;\r\n  z-index: 1;\r\n}\r\n\r\n/* Place the container to the left */\r\n.left {\r\n  left: -25.1%;\r\n}\r\n\r\n/* Place the container to the right */\r\n.right {\r\n  left: 25.5%;\r\n}\r\n\r\n/* Add arrows to the left container (pointing right) */\r\n.left::before {\r\n  content: \" \";\r\n  height: 0;\r\n  position: absolute;\r\n  top: 22px;\r\n  width: 0;\r\n  z-index: 1;\r\n  right: 30px;\r\n  border: medium solid white;\r\n  border-width: 10px 0 10px 10px;\r\n  border-color:transparent transparent transparent white;\r\n}\r\n\r\n/* Add arrows to the right container (pointing left) */\r\n.right::before {\r\n  content: \" \";\r\n  height: 0;\r\n  position: absolute;\r\n  top: 22px;\r\n  width: 0;\r\n  z-index: 1;\r\n  left: 30px;\r\n  border: medium solid white;\r\n  border-width: 10px 10px 10px 0;\r\n  border-color: transparent transparent transparent white;\r\n}\r\n\r\n/* Fix the circle for containers on the right side */\r\n.right::after {\r\n  left: -16px;\r\n}\r\n\r\n/* The actual content */\r\n.content {\r\n  padding: 20px 30px;\r\n  background-color: white;\r\n  position: relative;\r\n  border-radius: 6px;\r\n}\r\n\r\n/* Media queries - Responsive timeline on screens less than 600px wide */\r\n@media screen and (max-width: 600px) {\r\n  /* Place the timelime to the left */\r\n  .timeline::after {\r\n  left: 31px;\r\n  }\r\n  \r\n  /* Full-width containers */\r\n  .container {\r\n  width: 100%;\r\n  padding-left: 70px;\r\n  padding-right: 25px;\r\n  }\r\n  \r\n  /* Make sure that all arrows are pointing leftwards */\r\n  .container::before {\r\n  left: 60px;\r\n  border: medium solid white;\r\n  border-width: 10px 10px 10px 0;\r\n  border-color: transparent white transparent transparent;\r\n  }\r\n\r\n  /* Make sure all circles are at the same spot */\r\n  .left::after, .right::after {\r\n  left: 15px;\r\n  }\r\n  \r\n  /* Make all right containers behave like the left ones */\r\n  .right {\r\n  left: 0%;\r\n  }\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<div class=\"timeline\">\r\n  <div class=\"container left\">\r\n    <div class=\"content\">\r\n      <h2>Spring- March, April, May, June</h2>\r\n      <p>Between April and late June, the snow starts to melt and the snow starts to gradually become longer and longer. Adult male polar bears start looking for mates; adult males usually reach sexual maturity between the ages of 6 and 10. Females reach secual maturity between the ages of 4 and 6, but female polar bears usually give birth every three years. This leads to a greater number of males than females participating during mating season. Adult males usually stay with the female for a couple of days before leaving. While mating happens during the spring season, the fertilized egg does not actually implant until fall. This is due to a process called delayed implantation. Fertilized eggs will only implant if the female has sufficient fat to sustain both herself and her cubs during denning season.\r\n</p>\r\n    </div>\r\n  </div>\r\n  <div class=\"container right\">\r\n    <div class=\"content\">\r\n      <h2>Fall/Early Winter- Sept, Oct, Nov</h2>\r\n      <p> This period of time is called denning season. A pregnant female will start building a maternity den for her cubs after feeding through summer and fall. She will give birth and nurse her cubs here. Pregnant polar bears usually create dens in snow drifts in coastal and river bluffs, hills near sea ice, or in banks of snow along the frozen sea. The pregnant polar bear will then create a small snow cave in her desired location. It’s usually only big enough for her to turn around. She will then wait for the snow to completely cover the entrance. \r\n</p>\r\n    </div>\r\n  </div>\r\n  <div class=\"container left\">\r\n    <div class=\"content\">\r\n      <h2>Winter- Dec, Jan, Feb</h2>\r\n      <p>Most cubs are born during December. A pregnant mother will usually give birth to 1, 2, or 3 cubs. Twins are the most common. She will not usually eat or drink anything during this time. All of her time and energy will be put into her cubs. Newborn cubs are completely dependent on their mother as they are usually blind, toothless, and are only covered with a short covering of fur. The mothers will nurse for up to 20 weeks. During this time the cubs will grow rapidly. </p>\r\n    </div>\r\n  </div>\r\n  <div class=\"container right\">\r\n    <div class=\"content\">\r\n      <h2>Early Spring- Mar, Apr </h2>\r\n      <p>The mother and her cubs usually emerge from their dens sometime during March or April. By this time, the cubs are able to defend themselves against almost anything that may try to harm them. The family of polar bears now make their way towards the sea ice. The mother now starts teaching her cubs hope to survive in the Arctic. Cubs usually spend 2 ½ years with their mother before they part ways. The cubs grow up and the cycle continues as the mother participates in mating season once again.</p>\r\n    </div>\r\n  </div>\r\n  <div class=\"container left\">\r\n    <div class=\"content\">\r\n      <h2>Summer- Jul, Aug, Sept</h2>\r\n      <p>This time is the least busy time of the year for the Polar Bears. Their main objective is just to feed and survive. </p>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n</body>\r\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
