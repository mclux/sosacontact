using SosaContact.Api.Models;
using SosaContact.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SosaContact.Api.Controllers
{
    public class ContactTypesController : ApiController
    {
        ContactTypeRepository contactTypeRepo;

        public ContactTypesController()
        {
            contactTypeRepo = new ContactTypeRepository();
        }

        [HttpGet]
        public SosaContactResponse GetContactTypes()
        {
            SosaContactResponse resp = new SosaContactResponse();
            var contTypes= contactTypeRepo.GetContactTypes();
            resp.Response = GetContactTypes();
            return resp;
        }
    }
}
