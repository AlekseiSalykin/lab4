using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace Maps.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Privacy()
		{
			return View();
		}
		public async Task<string> GetData()
		{
			var clientHandler = new HttpClientHandler();
			clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
			var client = new HttpClient(clientHandler);
			client.BaseAddress = new Uri("https://localhost:7096/City");
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			var response = await client.GetAsync("/City");
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
	}
}