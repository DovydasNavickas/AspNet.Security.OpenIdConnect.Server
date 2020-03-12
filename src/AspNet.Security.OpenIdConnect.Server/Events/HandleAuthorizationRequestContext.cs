/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenIdConnect.Server
 * for more information concerning the license and the contributors participating to this project.
 */

using AspNet.Security.OpenIdConnect.Primitives;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OpenIdConnect.Server
{
    /// <summary>
    /// Represents the context class associated with the
    /// <see cref="OpenIdConnectServerProvider.HandleAuthorizationRequest"/> event.
    /// </summary>
    public class HandleAuthorizationRequestContext : BaseValidatingTicketContext
    {
        /// <summary>
        /// Creates a new instance of the <see cref="HandleAuthorizationRequestContext"/> class.
        /// </summary>
        public HandleAuthorizationRequestContext(
            HttpContext context,
            AuthenticationScheme scheme,
            OpenIdConnectServerOptions options,
            OpenIdConnectRequest request)
            : base(context, scheme, options, request, null)
        {
            Validate();
        }
    }
}
