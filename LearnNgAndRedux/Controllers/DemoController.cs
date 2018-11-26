using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LNAR.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnNgAndRedux.Controllers
{
    public class DemoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public Product[] GetPrducts()
        {
            return new Product[]
            {
                new Product()
                {
                    Id=12,
                    Title="第一个商品",
                    Price=(decimal)1.99,
                    Rating=(float)3.5,
                    Desc="第一个测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },
                new Product()
                {
                    Id=1,
                    Title="第2个商品",
                    Price=(decimal)2.99,
                    Rating=(float)5,
                    Desc="第2个测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },
                new Product()
                {
                    Id=12,
                    Title="第3个商品",
                    Price=(decimal)1.99,
                    Rating=(float)3.5,
                    Desc="第3个测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },
                new Product()
                {
                    Id=12,
                    Title="第4个商品",
                    Price=(decimal)1.99,
                    Rating=(float)3.5,
                    Desc="第4个测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },
                new Product()
                {
                    Id=122,
                    Title="第5个商品",
                    Price=(decimal)1.99,
                    Rating=(float)3.5,
                    Desc="第5个测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },
                new Product()
                {
                    Id=124,
                    Title="第6个商品",
                    Price=(decimal)6.99,
                    Rating=(float)3.5,
                    Desc="第6个测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },
                new Product()
                {
                    Id=124,
                    Title="第7个商品",
                    Price=(decimal)1.99,
                    Rating=(float)3.5,
                    Desc="第7个测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },
                new Product()
                {
                    Id=126,
                    Title="第8个商品",
                    Price=(decimal)1.99,
                    Rating=(float)3.5,
                    Desc="第一8测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },
                new Product()
                {
                    Id=12,
                    Title="第9个商品",
                    Price=(decimal)1.99,
                    Rating=(float)3.5,
                    Desc="第9个测试",
                    Categories=new string[]
                    {
                        "电子书","测试"
                    }

                },

            };
        }
    }
}