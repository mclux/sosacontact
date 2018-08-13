using SosaContact.Api.Models;
using SosaContact.Api.Providers;
using SosaContact.Core.Entities;
using SosaContact.Core.Interfaces;
using SosaContact.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;

namespace SosaContact.Api.Controllers
{
    public class UserController : ApiController
    {
        UserRepository userRepo;
        AuthTokenRepository tokenRepo;
        public UserController()
        {
            userRepo = new UserRepository();
            tokenRepo = new AuthTokenRepository();
        }

        [HttpPost]
        public SosaContactResponse Register(User user)
        {
            SosaContactResponse response = new SosaContactResponse();
            if(user.Username.Trim().Length<1 || user.Password.Trim().Length<1)
            {
                response.ResponseType = "ERROR";
                response.Message = "Username and password are required!";
            }
            else
            {
                if(userRepo.GetUserByUsername(user.Username)!=null)
                {
                    response.ResponseType = "ERROR";
                    response.Message = "Username already exist!";
                }
                else
                {
                    MD5 md5Hash = MD5.Create();
                    user.Created = DateTime.Now;
                    user.Password = PasswordManager.GetMd5Hash(md5Hash,user.Password);
                    if (userRepo.AddUser(user))
                    {
                        response.ResponseType = "SUCCESS";
                        response.Message = "Account Created!";
                        response.Response = user;
                    }
                    else
                    {
                        response.ResponseType = "ERROR";
                        response.Message = "Could not create account!";
                    }
                }                
            }
            return response;
        }

        [HttpPost]
        public SosaContactResponse Login(LoginVM input)
        {
            SosaContactResponse response = new SosaContactResponse();

            if (input.Username.Trim().Length < 1 || input.Password.Trim().Length < 1)
            {
                response.ResponseType = "ERROR";
                response.Message = "Username and password are required!";
            }
            else
            {
                User user = userRepo.GetUserByUsername(input.Username);
                if(user==null)
                {
                    response.ResponseType = "ERROR";
                    response.Message = "Invalid credentials!";
                }
                else
                {
                    MD5 md5Hash = MD5.Create();
                    string hash = PasswordManager.GetMd5Hash(md5Hash, input.Password);
                    if(PasswordManager.VerifyMd5Hash(md5Hash,input.Password,hash))
                    {
                        AuthToken tk = new AuthToken {UserID=user.UserID };
                        response.ResponseType = "SUCCESS";
                        response.Response = new LoginResponseVM {
                            AuthToken = tokenRepo.CreateToken(tk).Token,
                            UserID=user.UserID
                        };
                    }
                    else
                    {
                        response.ResponseType = "ERROR";
                        response.Message = "Invalid credentials!";
                    }
                }
            }
            return response;
        }
    }
}
