using BusinessLogic.library;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    class OrderInformation
    {
        private string ItemId { get; set; }
        private string CartId { get; set; }
        private int Quantity { get; set; }
        private System.DateTime DateCreated { get; set; }
        private int ProductId { get; set; }

    }
}
