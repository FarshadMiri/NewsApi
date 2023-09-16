using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using News.service;
using NewsApi.Models;
using Newtonsoft.Json;

namespace NewsApi.Helper
{
    public  class ApiHelper
    {
        public  async Task<RootModel> Get()
        {
            RootModel root = new RootModel();

            // این بخش  برای تبدیل  تاریخ به فرمت دلخواه و قرار دادن ان در پارامتر  
            var data = new Date().ConvertSystemShamsiToGregorian().ToString("yyyy/MM/dd");

            HttpClient client = new HttpClient();
            
           //وارد کردن تاریخ به صورت دستی  
            HttpResponseMessage message = await client.GetAsync("https://newsapi.org/v2/everything?q=tesla&from=2023/09/13&sortBy=publishedAt&apiKey=e9e28400d0ed48de92955b480b480339");

            // با استفاده از تاریخ روز
            //  به دلیل رایگان بودن وب سرویس دریافت اخبار تسلا  نمی توان اخبار به روز را دریافت کرد.
            //HttpResponseMessage message = await client.GetAsync("https://newsapi.org/v2/everything?q=tesla&from=" + data + "&sortBy=publishedAt&apiKey=e9e28400d0ed48de92955b480b480339");

            if (message.IsSuccessStatusCode)
            {
                var jstring = await message.Content.ReadAsStringAsync();
                root = JsonConvert.DeserializeObject<RootModel>(jstring);
                return root;

            }
            else
            {
                return null;
            }
        }
    }
}
