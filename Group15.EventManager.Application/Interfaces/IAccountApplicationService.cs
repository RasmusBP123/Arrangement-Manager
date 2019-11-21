﻿using Group15.EventManager.Application.ViewModels.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface IAccountApplicationService
    {
        Task<IdentityResult> CreateAccount(RegisterModel registerModel);
        Task<SignInResult> PasswordSignIn(LoginModel loginModel);
        Task DeleteAccount(Guid accountId);
    }
}