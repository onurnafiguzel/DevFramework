using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace DevFramework.Core.CrossCuttingConcerns.Security.Web
{
    public class SecurityUtilities
    {
        public Identity FormsAuthTicketToIdentity(FormsAuthenticationTicket ticket)
        {
            var identity = new Identity
            {
                Id = SetId(ticket),
                Name = SetName(ticket),
                Email = SetEmail(ticket),
                Roles = SetRoles(ticket),
                FirstName = SetFirstName(ticket),
                LastName = SetLastName(ticket),
                AuthenticationType = SetAuthType(ticket),
                IsAuthenticated = SetIsAuthenticated(ticket)
            };
            return identity;
        }

        private bool SetIsAuthenticated(FormsAuthenticationTicket ticket)
        {
            throw new NotImplementedException();
        }

        private string SetAuthType(FormsAuthenticationTicket ticket)
        {
            throw new NotImplementedException();
        }

        private string SetLastName(FormsAuthenticationTicket ticket)
        {
            throw new NotImplementedException();
        }

        private string SetFirstName(FormsAuthenticationTicket ticket)
        {
            throw new NotImplementedException();
        }

        private string SetEmail(FormsAuthenticationTicket ticket)
        {
            throw new NotImplementedException();
        }

        private string[] SetRoles(FormsAuthenticationTicket ticket)
        {
            throw new NotImplementedException();
        }

        private string SetName(FormsAuthenticationTicket ticket)
        {
            throw new NotImplementedException();
        }

        private Guid SetId(FormsAuthenticationTicket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
