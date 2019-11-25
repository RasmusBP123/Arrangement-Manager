using AutoMapper;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Models.Auth;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class AccountApplicationService : IAccountApplicationService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountRepository _accountRepository;

        public AccountApplicationService(IMapper mapper, IUnitOfWork unitOfWork ,IAccountRepository accountRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _accountRepository = accountRepository;
        }

        public async Task<IdentityResult> CreateAccount(RegisterModel registerModel)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = registerModel.Email,
                Email = registerModel.Email,
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                City = registerModel.City,
                Address = registerModel.Address,
                PhoneNumber = registerModel.PhoneNumber,
            };

            var result = await _accountRepository.CreateAccount(applicationUser, registerModel.Password);
            _unitOfWork.Commit();

            return result;
        }

        public async Task DeleteAccount(ClaimsPrincipal userClaim)
        {
            await _accountRepository.DeleteAccount(userClaim);
        }

        public async Task<UserModel> GetLoggedInUser(ClaimsPrincipal claimsPrincipal)
        {
            var applicationUser = await _accountRepository.GetLoggedInUser(claimsPrincipal);
            var userModel = _mapper.Map<UserModel>(applicationUser);
            return userModel;
        }

        public async Task<SignInResult> PasswordSignIn(LoginModel loginModel)
        {
            var result = await _accountRepository.PasswordSignIn(loginModel.Email, loginModel.Password);
            return result;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
