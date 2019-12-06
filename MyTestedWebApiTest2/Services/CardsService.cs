using MyTestedWebApiTest2.Models;
using System;
using System.Threading.Tasks;

namespace MyTestedWebApiTest2.Services
{
	public interface ICardsService
	{
		Task<CardInfo> GetAllCards();
	}

	public class CardsService : ICardsService
	{
		public Task<CardInfo> GetAllCards()
		{
			throw new NotImplementedException();
		}
	}
}
