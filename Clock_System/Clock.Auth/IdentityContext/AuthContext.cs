﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clock.Auth.IdentityContext
{    
        public class AuthContext : IdentityDbContext
        {
            public AuthContext(DbContextOptions<AuthContext> options) : base(options)
            {
            }
        }
    }
