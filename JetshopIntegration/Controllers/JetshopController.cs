using JetshopIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


            //
            // JetshopCredentials.cs i "Models"-mappen är ONÖDIG just nu...
            //


namespace JetshopIntegration.Controllers
{
    [RoutePrefix("Jetshop")]
    public class JetshopController : ApiController
    {
        [Route("Products")]
        [HttpGet]
        public IHttpActionResult GetProducts([FromUri] string domain)
        {
            string URL = $"http://{domain}/Services/Rest/v1/json/products";
            var json = "";
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(URL);
            }

            return Ok(json);
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
