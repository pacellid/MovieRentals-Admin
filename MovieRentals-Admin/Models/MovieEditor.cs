using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals_Admin.Models
{
    public class MovieEditor
    {
        public IEnumerable<SelectListItem> Movies { get; set; }
    }
}