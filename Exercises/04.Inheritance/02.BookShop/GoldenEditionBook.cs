﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {

        }

        public override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }

            set => base.Price = value;
        }
    }
}
