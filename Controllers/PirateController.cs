using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace PirateTreasure.Controllers
{
    public class PirateController : ApiController
    {
        private PirateTreasure.Models.Treasure _treasure = new Models.Treasure();

        // GET api/Pirate/{numPirates}
        public HttpResponseMessage Get(double numberOfPirates)
        {
            if (numberOfPirates % 1 > 0)
                return Request.CreateResponse(HttpStatusCode.NotAcceptable,
                    "No decimals: Only whole integers allowed");
            if (numberOfPirates < 2)
                return Request.CreateResponse(HttpStatusCode.NotAcceptable,
                    "We are looking for a number that is greater than 1.");
            else
                return Request.CreateResponse(HttpStatusCode.OK,
                    _treasure.CalculateMinimumNumberOfCoins(numberOfPirates));
        }
    }
}