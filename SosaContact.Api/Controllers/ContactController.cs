using SosaContact.Api.Models;
using SosaContact.Core.Entities;
using SosaContact.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SosaContact.Api.Controllers
{
    public class ContactController : ApiController
    {
        ContactNameRepository contactRepo;
        public ContactController()
        {
            contactRepo = new ContactNameRepository();
        }

        [HttpGet]
        public SosaContactResponse GetContacts(int userId)
        {
            var contacts = contactRepo.GetContactsByUserId(userId);

            SosaContactResponse response = new SosaContactResponse();
            response.ResponseType = "SUCCESS";
            response.Response = contacts;
            return response;
        }

        [HttpPost]
        public SosaContactResponse CreateContact(ContactName contact)
        {
            SosaContactResponse response = new SosaContactResponse();

            if(contact.CName.Trim().Length<1)
            {
                response.ResponseType = "ERROR";
                response.Message = "Contact name required!";
            }
            else
            {
                foreach(var contDetails in contact.ContactDetails)
                {
                    contDetails.Created = DateTime.Now;
                }
                if(contactRepo.AddContact(contact)!=null)
                {
                    response.ResponseType = "SUCCESS";
                    response.Response = contact;
                }
                else
                {
                    response.ResponseType = "ERROR";
                    response.Message = "Sorry, could not create contact.";
                }
            }

            return response;
        }
        
    }
}
