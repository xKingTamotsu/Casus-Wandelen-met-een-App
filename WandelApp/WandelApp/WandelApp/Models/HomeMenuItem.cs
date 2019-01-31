using System;
using System.Collections.Generic;
using System.Text;

namespace WandelApp.Models
{
    public enum MenuItemType
    {
        home,
        viewRoutes,
        makeRoute
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
