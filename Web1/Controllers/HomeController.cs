using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ContactModel model = GetData().Contacts; //pievieno atsauci uz modeļiem

            return View(model); 
        }

        public ActionResult Catalog()
        {
            List<ItemModel> items = GetData().Items;

            return View(items);
        }

        public ActionResult Buy(string name)
        {
            ItemModel item = null;
            foreach(ItemModel m in GetData().Items)
            {
                if(m.Name == name)
                {
                    item = m;
                    break;
                }
            }

            if (Session["preces"] == null)//dati glabājas, kamēr tiek aizvērts pārlūks
            {
                Session["preces"] = new List<ItemModel>();
            }
            (Session["preces"] as List<ItemModel>).Add(item);

            return RedirectToAction("Catalog");
        }

        public static ShopModel GetData()
        {
            return new ShopModel()
            {
                Name = "Renda",
                Contacts = new ContactModel()
                {
                    Email = "rforstmane@gmail.com",
                    Phone = "22221111",
                    Location = new AdressModel()
                    {
                        Country = "Latvija",
                        City = "Riga",
                        Street = "Brivibas",
                        HouseNo = "99",
                        ApartmentNo = 0
                    }
                },
                Items = new List<ItemModel>()
                {
                    new ItemModel()
                    {
                        // nosaukums + cena 
                        Name = "Dators",
                        Price = new PriceModel()
                        {
                            Amount = 800,
                            Currency = "$"
                        }
                    },
                    new ItemModel()
                    {
                        Name = "TV",
                        Price = new PriceModel()
                        {
                            Amount = 1500,
                            Currency = "$"
                        }
                    }
                }
            };
        }
    }
}