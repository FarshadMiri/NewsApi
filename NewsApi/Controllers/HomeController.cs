using Microsoft.AspNetCore.Mvc;
using News.domain;
using News.service;
using NewsApi.Helper;
using NewsApi.Models;
using System.Diagnostics;
using System.Globalization;

namespace NewsApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRootService _rootService { get; }
        private IArticleService _articleService { get; }

        //   هنوز به پایگاه داده برای انجام عملیات و استفاده از سرویس های ایجاد شده برای ذحیره دیتا آماده نیست 

        public HomeController(ILogger<HomeController> logger, IRootService rootService, IArticleService articleService)
        {
            _logger = logger;
            _rootService = rootService;
            _articleService = articleService;
        }
        // گرفتن داده ها از helper
        //و نشان دادن در 
        //index
       
        [HttpGet]
        public IActionResult Index()
        {
            var ApiHelper = new ApiHelper().Get().Result;
            return View(ApiHelper.articles);

        }





        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}