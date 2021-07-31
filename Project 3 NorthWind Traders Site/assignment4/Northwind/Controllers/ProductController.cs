using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Northwind.Controllers
{
	public class ProductController : Controller
	{
		private string baseUrl = "https://localhost:44336/api/";
		private string appJson = "application/json";
		private int defaultCategoryId = 1;

		// GET: ProductController
		public async Task<IActionResult> Index(int CategoryId)
		{
			if (CategoryId == 0)
			{
				CategoryId = defaultCategoryId;
			}

			var products = new List<Product>();
			try
			{
				var categories = new List<Category>();
                categories = await GetCategoriesAsync();
                if (categories != null)
                {
                    List<SelectListItem> categoryNameList = new List<SelectListItem>();
                    foreach (Category category in categories)
                    {
                        categoryNameList.Add(new SelectListItem(category.CategoryName, category.CategoryId.ToString()));
                    }
                    foreach (SelectListItem item in categoryNameList)
                    {
                        if (item.Value == CategoryId.ToString())
                        {
                            ViewBag.selectedName = item.Text;
                        }
                    }

                    ViewBag.CategoryName = categoryNameList;
                }
                products = await GetProductsAsync(CategoryId);

            }
            catch (Exception ex)
            {
                return View("Error",
                    new ErrorViewModel
                    {
                        RequestId = HttpContext.TraceIdentifier,
                        Description = ex.Message
                    });
            }
            //  ViewBag.search = search;
            return View(products);
        }

        // GET: ProductsController/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int id, string CatergoryName)
        {
            var product = new Product();
            try
            {
                product = await GetProductAsync(id);
                ViewBag.selectedName = CatergoryName;
            }
            catch (Exception ex)
            {
                return View("Error",
                   new ErrorViewModel
                   {
                       RequestId = HttpContext.TraceIdentifier,
                       Description = ex.Message
                   });
            }
            return View(product);
        }
        private async Task<List<Category>> GetCategoriesAsync()
        {
            var category = new List<Category>();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(appJson));
                client.BaseAddress = new Uri(baseUrl);

                var response = await client.GetAsync($"Categories");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    category = JsonSerializer.Deserialize<List<Category>>(json);
                }
            }



            return category;
        }
        private async Task<List<Product>> GetProductsAsync(int cartegoryId)
        {
            var products = new List<Product>();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(appJson));
                client.BaseAddress = new Uri(baseUrl);

                var response = await client.GetAsync($"Products/ByCategory/{cartegoryId}");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    products = JsonSerializer.Deserialize<List<Product>>(json);
                }
            }


            return products;
        }
        private async Task<Product> GetProductAsync(int productId)
        {
            var product = new Product();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(appJson));
                client.BaseAddress = new Uri(baseUrl);

                var response = await client.GetAsync($"Product/{productId}");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    product = JsonSerializer.Deserialize<Product>(json);
                }
            }

            return product;
        }

    }
}
