#pragma checksum "D:\sem5\WDDN\WDDN\gaana\Areas\Identity\Pages\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd66dd71c1e09d14fa27a3b4cd09e183a5f99cd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Login), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd66dd71c1e09d14fa27a3b4cd09e183a5f99cd2", @"/Areas/Identity/Pages/Account/Login.cshtml")]
    public class Areas_Identity_Pages_Account_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""breadcumb-area bg-img bg-overlay"" style=""background-image: url(/img/bg-img/breadcumb3.jpg);"">
    <div class=""bradcumbContent"">
        <p>See what’s new</p>
        <h2>Login</h2>
    </div>
</section>
<!-- ##### Breadcumb Area End ##### -->
<!-- ##### Login Area Start ##### -->
<section class=""login-area section-padding-100"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-lg-8"">
                <div class=""login-content"">
                    <h3>Welcome Back</h3>
                    <!-- Login Form -->
                    <div class=""login-form"">
                        <form action=""#"" method=""post"">
                            <div class=""form-group"">
                                <label for=""exampleInputEmail1"">Email address</label>
                                <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Enter E-mail"">
                   ");
            WriteLiteral(@"             <small id=""emailHelp"" class=""form-text text-muted""><i class=""fa fa-lock mr-2""></i>We'll never share your email with anyone else.</small>
                            </div>
                            <div class=""form-group"">
                                <label for=""exampleInputPassword1"">Password</label>
                                <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
                            </div>
                            <button type=""submit"" class=""btn oneMusic-btn mt-30"">Login</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gaana.Areas.Identity.Pages.Account.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<gaana.Areas.Identity.Pages.Account.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<gaana.Areas.Identity.Pages.Account.LoginModel>)PageContext?.ViewData;
        public gaana.Areas.Identity.Pages.Account.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
