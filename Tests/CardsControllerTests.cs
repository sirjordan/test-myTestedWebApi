using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTested.WebApi;
using MyTestedWebApiTest2.Controllers;
using MyTestedWebApiTest2.Models;
using MyTestedWebApiTest2.Services;

namespace Tests
{
	[TestClass]
	public class CardsControllerTests
	{
		[TestInitialize]
		public void Init()
		{
		}

		[TestMethod]
		public void AllCards_NullModel()
		{
			MyWebApi.Controller<CardsController>()
				.WithResolvedDependencyFor<ICardsService>(new CardsService())
				.Calling(c => c.GetAllCards(null))
				.ShouldReturn();
		}

		[TestMethod]
		public void AllCards_ValidateModel()
		{
			MyWebApi.Controller<CardsController>()
				.WithResolvedDependencyFor<ICardsService>(new CardsService())
				.Calling(c => c.GetAllCards(new CardRequestModel
				{
					// Required
					ProviderIds = null
				}))
				.ShouldHave()
				.InvalidModelState();
		}

		[TestMethod]
		public void AllCards_Route()
		{
		}

		[TestMethod]
		public void AllCards_CorrectResult()
		{
			// .ResultOfType<IEnumerable<CardInfo>>();
		}
	}
}
