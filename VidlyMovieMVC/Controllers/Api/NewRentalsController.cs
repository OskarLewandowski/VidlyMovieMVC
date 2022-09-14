using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyMovieMVC.Dtos;

namespace VidlyMovieMVC.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {

            return Ok();
        }
    }
}
