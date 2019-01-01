#pragma checksum "C:\Users\chialun\source\repos\LifeLog\LifeLog\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a10538689800f1f505661e04d8cfa0219b02961"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\chialun\source\repos\LifeLog\LifeLog\Views\_ViewImports.cshtml"
using LifeLog;

#line default
#line hidden
#line 2 "C:\Users\chialun\source\repos\LifeLog\LifeLog\Views\_ViewImports.cshtml"
using LifeLog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a10538689800f1f505661e04d8cfa0219b02961", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b306cc6bdae68f9b27b83a603eb0f923cfb34e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\chialun\source\repos\LifeLog\LifeLog\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 120, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\chialun\source\repos\LifeLog\LifeLog\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(214, 61, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong>\r\n        <code>");
            EndContext();
            BeginContext(276, 15, false);
#line 13 "C:\Users\chialun\source\repos\LifeLog\LifeLog\Views\Shared\Error.cshtml"
         Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(291, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 15 "C:\Users\chialun\source\repos\LifeLog\LifeLog\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(313, 3463, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to
    <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the
    <strong>Development</strong> environment by setting the
    <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to
    <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to
    <strong>Development</strong>
    and restarting the app.
</p>

{""query"":{""count"":1,
          ""created"":""2018-12-30T09:31:51Z"",
          ""lang"":""zh-TW"",
          ""results"":{""channel"":{""units"":{""distance"":""km"",""pressure"":""mb"",""speed"":""km/h"",""temperature"":""C""},""title"":""Yahoo! Weather - Taipei City, TW"",""link"":""http://us.rd.yahoo.com/dailynews/rss/weather/Country__Country/*https://weather.yahoo.com/country/state/c");
            WriteLiteral(@"ity-20070568/"",""description"":""Yahoo! Weather for Taipei City, TW"",""language"":""en-us"",""lastBuildDate"":""Sun, 30 Dec 2018 05:31 PM CST"",""ttl"":""60"",""location"":{""city"":""Taipei City"",""country"":""Taiwan"",""region"":"" TW""},""wind"":{""chill"":""59"",""direction"":""70"",""speed"":""33.80""},""atmosphere"":{""humidity"":""88"",""pressure"":""34067.08"",""rising"":""0"",""visibility"":""25.91""},""astronomy"":{""sunrise"":""6:38 am"",""sunset"":""5:15 pm""},""image"":{""title"":""Yahoo! Weather"",""width"":""142"",""height"":""18"",""link"":""http://weather.yahoo.com"",""url"":""http://l.yimg.com/a/i/brand/purplelogo//uh/us/news-wea.gif""},""item"":{""title"":""Conditions for Taipei City, TW at 04:00 PM CST"",""lat"":""25.037399"",""long"":""121.564003"",""link"":""http://us.rd.yahoo.com/dailynews/rss/weather/Country__Country/*https://weather.yahoo.com/country/state/city-20070568/"",""pubDate"":""Sun, 30 Dec 2018 04:00 PM CST"",""condition"":{""code"":""26"",""date"":""Sun, 30 Dec 2018 04:00 PM CST"",""temp"":""16"",""text"":""Cloudy""},""forecast"":[{""code"":""11"",""date"":""30 Dec 2018"",""day"":""Sun"",""high"":""16"",""low"":""13"",""text"":");
            WriteLiteral(@"""Showers""},{""code"":""11"",""date"":""31 Dec 2018"",""day"":""Mon"",""high"":""18"",""low"":""15"",""text"":""Showers""},{""code"":""11"",""date"":""01 Jan 2019"",""day"":""Tue"",""high"":""18"",""low"":""16"",""text"":""Showers""},{""code"":""11"",""date"":""02 Jan 2019"",""day"":""Wed"",""high"":""18"",""low"":""15"",""text"":""Showers""},{""code"":""11"",""date"":""03 Jan 2019"",""day"":""Thu"",""high"":""20"",""low"":""17"",""text"":""Showers""},{""code"":""12"",""date"":""04 Jan 2019"",""day"":""Fri"",""high"":""24"",""low"":""18"",""text"":""Rain""},{""code"":""39"",""date"":""05 Jan 2019"",""day"":""Sat"",""high"":""24"",""low"":""18"",""text"":""Scattered Showers""},{""code"":""11"",""date"":""06 Jan 2019"",""day"":""Sun"",""high"":""20"",""low"":""18"",""text"":""Showers""},{""code"":""11"",""date"":""07 Jan 2019"",""day"":""Mon"",""high"":""20"",""low"":""16"",""text"":""Showers""},{""code"":""30"",""date"":""08 Jan 2019"",""day"":""Tue"",""high"":""23"",""low"":""16"",""text"":""Partly Cloudy""}],""description"":""<![CDATA[
<img src=\""http://l.yimg.com/a/i/us/we/52/26.gif\"" />\n<BR />\n<b>Current Conditions:</b>\n<BR />Cloudy\n<BR />\n<BR />\n<b>Forecast:</b>\n<BR /> Sun - Showers. High: 16Low: 13\n<BR /> Mon -");
            WriteLiteral(@" Showers. High: 18Low: 15\n<BR /> Tue - Showers. High: 18Low: 16\n<BR /> Wed - Showers. High: 18Low: 15\n<BR /> Thu - Showers. High: 20Low: 17\n<BR />\n<BR />\n<a href=\""http://us.rd.yahoo.com/dailynews/rss/weather/Country__Country/*https://weather.yahoo.com/country/state/city-20070568/\"">Full Forecast at Yahoo! Weather</a>\n<BR />\n<BR />\n<BR />\n]]>"",""guid"":{""isPermaLink"":""false""}}}}}}");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591