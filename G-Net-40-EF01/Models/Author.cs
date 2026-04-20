using System;
using System.Collections.Generic;
using System.Text;

namespace G_Net_40_EF01.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; }

        public string? ShortBiography { get; set; }

        public DateTime DateOfBirth { get; set; }


    }
}
