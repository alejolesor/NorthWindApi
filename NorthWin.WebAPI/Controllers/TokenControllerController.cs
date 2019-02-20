using Microsoft.AspNetCore.Mvc;
using NorthWin.WebAPI.Authentication;
using Northwind.Models;
using Northwind.UnitOfWork;
using System;

namespace NorthWin.WebAPI.Controllers
{
    [Route("api/Token")]
    public class TokenControllerController : Controller
    {
        private ITokenProvider _tokenProvider;
        private IUnitOfWork _unitOfwork;

        public TokenControllerController(ITokenProvider tokenProvider, IUnitOfWork unitOfWork)
        {
            _tokenProvider = tokenProvider;
            _unitOfwork = unitOfWork;
        }
        [HttpPost]
        public JsonWebToken Post([FromBody]User userLogin)
        {
            var user = _unitOfwork.User.ValidateUser(userLogin.Email, userLogin.Password);
            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }
            var token = new JsonWebToken
            {
                Acces_Token = _tokenProvider.CreateToken(user, DateTime.UtcNow.AddHours(8)),
                Expires_in = 480//Minutes
            };
            return token;
        }
    }
}