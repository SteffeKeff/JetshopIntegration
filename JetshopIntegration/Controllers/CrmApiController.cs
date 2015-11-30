using JetshopIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JetshopIntegration.Controllers
{
    [RoutePrefix("Jetshop")]
    public class CrmApiController : ApiController
    {
        [Route("Validate")]
        [HttpGet]
        public IHttpActionResult ValidateCredentials()
        {
            return Ok("Works");
            //try
            //{
            //    crmService = new CrmService(credentials);
            //    var organizations = crmService.GetOrganizations();
            //    crmService.Logout();

            //    return Ok(organizations);
            //}
            //catch (Exception ex) when (ex is MessageSecurityException || ex is ArgumentNullException)
            //{
            //    return Unauthorized();
            //}
            //catch (NullReferenceException)
            //{
            //    return BadRequest();
            //}
        }
    }
}
