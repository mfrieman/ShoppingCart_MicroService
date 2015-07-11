using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCart.MicroService.Models;
namespace ShoppingCart.MicroService.Controllers
{
    public class ShoppingCartController : ApiController
    {
        // GET: api/ShoppingCart
        public ShoppingCartDTO Get()
        {
            return ShoppingCartRepository.GetCart();
        }
                
                
  
        // GET: api/ShoppingCart/5
        public string Get(int id)
        {
            return "value";
        }






    }
}
