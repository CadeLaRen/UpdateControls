/**********************************************************************
 * 
 * Update Controls .NET
 * Copyright 2008 Mallard Software Designs
 * Licensed under LGPL
 * 
 * http://updatecontrols.net
 * http://www.codeplex.com/updatecontrols/
 * 
 **********************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using UpdateControls;

namespace UpdateControls.Test
{
    public class Item
    {
        private string _name = string.Empty;
        private decimal _price = 0.0m;
        private int _quantity = 1;

        #region Independent properties
        // Generated by Update Controls --------------------------------
        private Independent _indName = new Independent();
        private Independent _indPrice = new Independent();
        private Independent _indQuantity = new Independent();

        public string Name
        {
            get { _indName.OnGet(); return _name; }
            set { _indName.OnSet(); _name = value; }
        }

        public decimal Price
        {
            get { _indPrice.OnGet(); return _price; }
            set { _indPrice.OnSet(); _price = value; }
        }

        public int Quantity
        {
            get { _indQuantity.OnGet(); return _quantity; }
            set { _indQuantity.OnSet(); _quantity = value; }
        }
        // End generated code --------------------------------
        #endregion

        public decimal Total
        {
            get { return Price * Quantity; }
        }

        public string Validate()
        {
            if (Quantity < 1)
                return "Quantity must be at least 1.";
            else
                return "";
        }
    }
}
