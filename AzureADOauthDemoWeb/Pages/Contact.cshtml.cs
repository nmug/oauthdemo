using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureADOauthDemoWeb.Pages
{
    [Authorize]
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            //Debug.WriteLine(ClaimsPrincipal.Current.Identity.Name);


            foreach (var claim in User.Claims)
            {
                Debug.WriteLine(claim.Type + ", " + claim.Value);
            }

            Message = "Your contact page.";
        }
    }
}
