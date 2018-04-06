﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace ManOfTheMatch.ApiController
{
    public class ClubsController : UmbracoAuthorizedApiController
    {
        // Custom api get
        [HttpGet]
        public IEnumerable<string> GetAllProducts()
        {
            return new[] { "Table", "Chair", "Desk", "Computer", "Beer fridge" };
            /*
            var rootNodes = Umbraco.TypedContentAtRoot();
            var eventsNode = rootNodes.FirstOrDefault(x => x.DocumentTypeAlias == "eventsList");

            var events = eventsNode.Children.OfType<Sponsor>();

            Json<IEnumerable<Event>>(events.ToList());
            */
        }
            
        // GET: api/Clubs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Clubs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Clubs
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clubs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clubs/5
        public void Delete(int id)
        {
        }
    }
}
