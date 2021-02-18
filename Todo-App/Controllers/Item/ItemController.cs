using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo_App.Controllers.Item
{
    [Route("api/item")]
    public class ItemController : ApiController
    {
        [HttpGet("{id}")]
        public string GetItem()
        {
            return "hello world";
        }

        public void GetItems()
        {

        }

        public void SaveItem()
        {

        }

        public void UpdateItem()
        {

        }

        public void DeleteItem()
        {

        }
    }
}
