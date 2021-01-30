﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }


    }
}


//public=bu classa diğer katmanlar da ulaşabilsin anlamına gelir.
//internal=sadece entities erişebilir anlamına gelir. Default olarak kullanılır. 