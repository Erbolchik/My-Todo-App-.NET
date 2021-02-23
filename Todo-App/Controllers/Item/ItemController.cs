using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo_App.Services;
using Todo_App.Models;

namespace Todo_App.Controllers.Item
{
    [Route("api/item")]
    public class ItemController : ApiController
    {
        private readonly ItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        //[HttpGet]
        //public List<Models.Item> GetItem()
        //{
        //    return _itemService.Get();
        //}

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
