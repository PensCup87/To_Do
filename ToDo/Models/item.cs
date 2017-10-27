using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class item
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public DateTime ItemDueDate { get; set; }
        public string ItemDetails { get; set; }
        public bool ItemIsDone { get; set; }

    }
}