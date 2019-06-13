using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
namespace mvcCookieAuthSample
{
    public class Config
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> { new Client() {
                 ClientId="mvc",
                 ClientSecrets = { new Secret("secrect".Sha256()) },
                 AllowedGrantTypes = GrantTypes.Implicit,
                 AllowedScopes = {"api1" }
            } };
        }

        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource> { new ApiResource("api1", "API Application"), new ApiResource("api2", "API2 Application") };
        }

        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser> { new TestUser {
                SubjectId ="10000",
                Username="gww",
                Password="password"
            } };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };
        }
    }
}
