using SosaContact.Core.Entities;
using SosaContact.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SosaContact.Infrastructure.Repositories
{
    public class AuthTokenRepository:IAuthTokenRepository
    {
        SosaContactContext context = new SosaContactContext();
        public AuthToken CreateToken(AuthToken token)
        {
            int tokenValue;
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[4];
                rng.GetBytes(data);
                 tokenValue= BitConverter.ToInt32(data, 0);
            }
            token.Token = tokenValue.ToString();
            token.Created = DateTime.Now;
            token.IsValid = true;

            context.AuthTokens.Add(token);
            context.SaveChanges();
            return token;
        }
        public AuthToken GetToken(string token)
        {
            return context.AuthTokens.FirstOrDefault(p=>p.Token==token);
        }
    }
}
