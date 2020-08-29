using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.Auth.Aplication.Resources
{
    public class Validator
    {
        public  bool CustomLifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken tokenToValidate, TokenValidationParameters @param)
        {
            if (expires != null)
            {
                return expires > DateTime.UtcNow;
            }
            return false;
        }
    }
}
