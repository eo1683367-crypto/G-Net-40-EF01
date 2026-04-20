using System;
using System.Collections.Generic;
using System.Text;

namespace G_Net_40_EF01.Models
{
    public class Book
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }
        
        public int NumberOfPages { get; set; }

        public int YearOfPubished { get; set; }

        public bool IsInStock { get; set; }


        #region Navigation Property
        public Category Category { get; set; }
        public int CategoryId { get; set; } 
        #endregion

    }
}
