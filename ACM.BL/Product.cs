﻿using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }

        private string _ProductName;

        public string ProductName
        {
            get
            {
                // return StringHandler.InsertSpaces( _ProductName ); }
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }
        

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product
            return new Product();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = this.ProductId + ": " +
                            this.ProductName + " " +
                            "Detail: " + this.ProductDescription + " " +
                            "Status: " + this.EntityState.ToString();
            return logString;
        }

    }
}
