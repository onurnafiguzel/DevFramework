﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace DevFramework.Northwind.WebApi.MessageHandlers
{
    public class AuthenticationHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                var token = request.Headers.GetValues("Authorization").FirstOrDefault();
                if (token != null)
                {
                    byte[] data = Convert.FromBase64String(token);
                    string decodedString = Encoding.UTF8.GetString(data);
                    string[] tokenValues = decodedString.Split(':');

                // https://www.base64encode.org adresinden "onur:12345 yaz, postman'e Authorization'ın value bölümüne ekle öyle send yap
                    if (tokenValues[0] == "onur" & tokenValues[1] == "12345")
                    {
                        IPrincipal principal = new GenericPrincipal(new GenericIdentity(tokenValues[0]), new[] { "Admin" });
                        Thread.CurrentPrincipal = principal; //Back-end'deki Identity set olur.
                        HttpContext.Current.User = principal; // Asp.Net için daha doğrusu Web API için.
                    }
                }
            }
            catch
            {
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}