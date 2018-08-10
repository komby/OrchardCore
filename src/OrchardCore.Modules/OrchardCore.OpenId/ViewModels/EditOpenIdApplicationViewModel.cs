using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace OrchardCore.OpenId.ViewModels
{
    public class EditOpenIdApplicationViewModel
    {
        [HiddenInput]
        public string Id { get; set; }
        [Required]
        public string ClientId { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Url]
        public string RedirectUris { get; set; }
        [Url]
        public string PostLogoutRedirectUris { get; set; }
        public string Type { get; set; }
        public string ConsentType { get; set; }
        public bool UpdateClientSecret { get; set; }
        public string ClientSecret { get; set; }
        public List<RoleEntry> RoleEntries { get; } = new List<RoleEntry>();
        public bool AllowPasswordFlow { get; set; }
        public bool AllowClientCredentialsFlow { get; set; }
        public bool AllowAuthorizationCodeFlow { get; set; }
        public bool AllowRefreshTokenFlow { get; set; }
        public bool AllowImplicitFlow { get; set; }
        public bool AllowLogoutEndpoint { get; set; }

        public class RoleEntry
        {
            public string Name { get; set; }
            public bool Selected { get; set; }
        }
    }
}
