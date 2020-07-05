﻿using SeliseExam.DTO;
using SeliseExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeliseExam.JWTToken
{
    public interface IJwtGenerator
    {
        public LoginResponseDTO CreateToken(AppUser user, string[] role);
    }
}
