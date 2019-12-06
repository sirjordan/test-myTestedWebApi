using MyTestedWebApiTest2.Models;
using MyTestedWebApiTest2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyTestedWebApiTest2.Controllers
{
	[Route("api/cards")]
	public class CardsController : ApiController
	{
		private ICardsService _cardsService;

		public CardsController(ICardsService cardsService)
		{
			_cardsService = cardsService;
		}

		[Route("all")]
		public async Task<IHttpActionResult> GetAllCards(CardRequestModel cardsRequest)
		{
			if (cardsRequest == null || !ModelState.IsValid)
			{
				return BadRequest("Requires object with list of providerIds");
			}

			var cards = await _cardsService.GetAllCards();

			return Ok(cards);
		}
	}
}
