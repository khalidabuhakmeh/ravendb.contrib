﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;

namespace Raven.Contrib.AspNet.Auth
{
    public class InvalidPasswordResetTokenException : AuthenticationException
    {
        public InvalidPasswordResetTokenException(string token)
            : base("Invalid password reset token: " + token)
        {
            
        }
    }
}
