using Microsoft.AspNetCore.Mvc;
using NorthWin.WebAPI.Authentication;
using Northwind.Models;
using Northwind.UnitOfWork;

namespace NorthWin.WebAPI.Controllers
{
    public class TokenControllerController : Controller
    {
        private ITokenProvider _tokenProvider;
        private IUnitOfWork _unitOfwork;

        public TokenControllerController(ITokenProvider tokenProvider, IUnitOfWork unitOfWork)
        {
            _tokenProvider = tokenProvider;
            _unitOfwork = unitOfWork;
        }

        public JsonWebToken Post(User userLogin)
    }
}