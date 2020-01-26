using FunBooksAndVideos.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunBooksAndVideos.Models
{
    public class Item
    {
        #region Contructor
        public Item()
        { 
            
        }
        #endregion

        #region Get/Set properties
        public String Title { get; set; }

        public Decimal TotalPrice { get; set; }

        public ItemType ItemType { get; set; }

        public String ItemId { get; set; }
        #endregion
    }
}
