#pragma checksum "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3335639a2945dcf80d7e93197bdeff16f709d982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Browse), @"mvc.1.0.view", @"/Views/Home/Browse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Browse.cshtml", typeof(AspNetCore.Views_Home_Browse))]
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
#line 1 "/Users/alexandershvyrev/Desktop/MyProject/Views/_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#line 2 "/Users/alexandershvyrev/Desktop/MyProject/Views/_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3335639a2945dcf80d7e93197bdeff16f709d982", @"/Views/Home/Browse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e083a8837ab2abdebcec4d90344b667fb6f4f2fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Browse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cloudscribe.Pagination.Models.PagedResult<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavInBrowse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form in-line"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "pagenumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Browse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "page-item active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-other-class", "page-item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-non-active-class", "page-item disabled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-current-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-other-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imageThumbnail-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 55, true);
            WriteLiteral("    <div class=\"jumbotron p-0 pb-5 pl-5 pr-5\">\n        ");
            EndContext();
            BeginContext(113, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3335639a2945dcf80d7e93197bdeff16f709d9827683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(143, 135, true);
            WriteLiteral("\n        <h3 style=\"text-align:center;\">Here are all the movies you can choose from!</h3>\n        <hr>\n    \n    Search for Movie: \n    ");
            EndContext();
            BeginContext(278, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3335639a2945dcf80d7e93197bdeff16f709d9829059", async() => {
                BeginContext(315, 139, true);
                WriteLiteral("\n    <input type=\"search\" id=\"searchfield\"class=\"form-control col-3 mr-2\">\n    <button class=\"btn btn-outline-primary\">Search</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(461, 27, true);
            WriteLiteral("\n\n    \n    \n    </div>\n    ");
            EndContext();
            BeginContext(488, 547, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3335639a2945dcf80d7e93197bdeff16f709d98210824", async() => {
                BeginContext(1019, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#line 17 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = Model.PageNumber;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = Model.TotalItems;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __cloudscribe_Web_Pagination_PagerTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __cloudscribe_Web_Pagination_PagerTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiOtherCssClass = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiNonActiveCssClass = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkCurrentCssClass = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkOtherCssClass = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1035, 106, true);
            WriteLiteral("\n    <div id=\"mytable\">...search database</div>\n    <div class=\"row justify-content-center text-primary\">\n");
            EndContext();
#line 31 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
         foreach (var m in Model.Data)
        {
            var ImagePath="~/images/" + (m.ImagePath ?? "skitterphoto.jpg");

#line default
#line hidden
            BeginContext(1267, 204, true);
            WriteLiteral("            <div class=\"card-group m-2 p-2\" style=\"width: 22.5rem;\">\n                <div class=\"card border-success mb-3 p-3\">\n                    <div class=\"card-title\" style=\"text-align:center;\" ><h4>");
            EndContext();
            BeginContext(1472, 7, false);
#line 36 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                                                                       Write(m.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1479, 83, true);
            WriteLiteral("</h4></div>\n                    <div class=\"card m-1 p-1\">\n                        ");
            EndContext();
            BeginContext(1562, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3335639a2945dcf80d7e93197bdeff16f709d98215864", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            BeginWriteTagHelperAttribute();
#line 38 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                                                               WriteLiteral(ImagePath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 38 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1652, 508, true);
            WriteLiteral(@"
                    </div>
                    <br>
                    
            <div id=""accordion"">

                <div class=""card"">
                    <div class=""card-header"">
                    <a class=""card-link"" data-toggle=""collapse"" href=""#collapseOne"">
                        Year
                    </a>
                    </div>
                    <div id=""collapseOne"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        ");
            EndContext();
            BeginContext(2161, 6, false);
#line 52 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                   Write(m.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2167, 493, true);
            WriteLiteral(@"
                    </div>
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                    <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseTwo"">
                        Director
                    </a>
                    </div>
                    <div id=""collapseTwo"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        ");
            EndContext();
            BeginContext(2661, 10, false);
#line 65 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                   Write(m.Director);

#line default
#line hidden
            EndContext();
            BeginContext(2671, 79, true);
            WriteLiteral("\n                    </div>\n                    </div>\n                </div>\n\n");
            EndContext();
#line 70 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                  
                    string Rating=$"{m.Rating}";
                

#line default
#line hidden
            BeginContext(2836, 417, true);
            WriteLiteral(@"
                <div class=""card"">
                    <div class=""card-header"">
                    <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseThree"">
                        Rating
                    </a>
                    </div>
                    <div id=""collapseThree"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        ");
            EndContext();
            BeginContext(3254, 21, false);
#line 82 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                   Write(Rating.Substring(0,3));

#line default
#line hidden
            EndContext();
            BeginContext(3275, 580, true);
            WriteLiteral(@"
                    </div>
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                    <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseFour"">
                        Cast:
                    </a>
                    </div>
                    <div id=""collapseFour"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <div class=""scroll"" style=""height:80px; overflow:auto;"">
                            <p>");
            EndContext();
            BeginContext(3856, 7, false);
#line 96 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                          Write(m.Stars);

#line default
#line hidden
            EndContext();
            BeginContext(3863, 622, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                    <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseFive"">
                        Description:
                    </a>
                    </div>
                    <div id=""collapseFive"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <div class=""scroll"" style=""height:80px; overflow:auto;"">
                            <p>");
            EndContext();
            BeginContext(4486, 13, false);
#line 111 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                          Write(m.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4499, 531, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                    <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseSix"">
                        Uploaded on
                    </a>
                    </div>
                    <div id=""collapseSix"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        ");
            EndContext();
            BeginContext(5031, 31, false);
#line 125 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                   Write(m.CreatedAt.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(5062, 115, true);
            WriteLiteral("\n                    </div>\n                    </div>\n                </div>\n            </div>\n            <br>\n\n");
            EndContext();
#line 132 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                     if(m.Creator.UserId == ViewBag.User.UserId)
                    {

#line default
#line hidden
            BeginContext(5264, 56, true);
            WriteLiteral("                        <a class=\"btn btn-outline-light\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5320, "\"", 5345, 2);
            WriteAttributeValue("", 5327, "/delete/", 5327, 8, true);
#line 134 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
WriteAttributeValue("", 5335, m.MovieId, 5335, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5346, 16, true);
            WriteLiteral(">Delete</a><br>\n");
            EndContext();
#line 135 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                    }
                    else
                    {
                        if(m.Actions.All(u => u.UserId != ViewBag.User.UserId))
                        {

#line default
#line hidden
            BeginContext(5537, 59, true);
            WriteLiteral("                            <a class=\"btn btn-outline-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5596, "\"", 5639, 4);
            WriteAttributeValue("", 5603, "/add/", 5603, 5, true);
#line 140 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
WriteAttributeValue("", 5608, m.MovieId, 5608, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 5618, "/", 5618, 1, true);
#line 140 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
WriteAttributeValue("", 5619, ViewBag.User.UserId, 5619, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5640, 22, true);
            WriteLiteral(">Add To Watchlist</a>\n");
            EndContext();
#line 141 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                        }
                    if(m.Actions.Any(s=>s.UserId == ViewBag.User.UserId))
                    {

#line default
#line hidden
            BeginContext(5784, 55, true);
            WriteLiteral("                        <a class=\"btn btn-outline-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5839, "\"", 5886, 4);
            WriteAttributeValue("", 5846, "/unwatch/", 5846, 9, true);
#line 144 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
WriteAttributeValue("", 5855, m.MovieId, 5855, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 5865, "/", 5865, 1, true);
#line 144 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
WriteAttributeValue("", 5866, ViewBag.User.UserId, 5866, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5887, 27, true);
            WriteLiteral(">Remove From Watchlist</a>\n");
            EndContext();
#line 145 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                    }

#line default
#line hidden
            BeginContext(5936, 27, true);
            WriteLiteral("                    <br>  \n");
            EndContext();
#line 147 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                    }

#line default
#line hidden
            BeginContext(5985, 59, true);
            WriteLiteral("                    <button class=\"btn btn-outline-warning\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6044, "\"", 6059, 1);
#line 148 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
WriteAttributeValue("", 6049, m.MovieId, 6049, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6060, 88, true);
            WriteLiteral(" onclick=\"toggleComments(this)\">Hide/Show Comments</button><br>\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6148, "\"", 6172, 2);
#line 149 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
WriteAttributeValue("", 6153, m.MovieId, 6153, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 6163, "/Comments", 6163, 9, true);
            EndWriteAttribute();
            BeginContext(6173, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 150 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                     foreach(var c in m.Comments)
                    {

#line default
#line hidden
            BeginContext(6247, 59, true);
            WriteLiteral("                        <p id=\"comments\" class=\"text-info\">");
            EndContext();
            BeginContext(6307, 9, false);
#line 152 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                                                      Write(c.Content);

#line default
#line hidden
            EndContext();
            BeginContext(6316, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 153 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
                    }

#line default
#line hidden
            BeginContext(6343, 107, true);
            WriteLiteral("                    </div>\n                    \n                </div>\n                \n            </div>\n");
            EndContext();
#line 159 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Browse.cshtml"
            
        }

#line default
#line hidden
            BeginContext(6473, 386, true);
            WriteLiteral(@"        
</div> 

<script>
    console.log(""hello"");
    
    $(document).ready(function()
    {

        $(""form"").submit(function(event)
        {
            event.preventDefault();
            var query = $(""#searchfield"").val();
            $.post(""/search"", {query: query}, function(data){
                $(""#mytable"").html(data);
            });
        })
    })

</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cloudscribe.Pagination.Models.PagedResult<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
