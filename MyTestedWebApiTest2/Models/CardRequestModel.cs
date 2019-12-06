using System;
using System.ComponentModel.DataAnnotations;

namespace MyTestedWebApiTest2.Models
{
	public class CardRequestModel
	{
		[Required]
		public Guid[] ProviderIds { get; set; }
	}
}