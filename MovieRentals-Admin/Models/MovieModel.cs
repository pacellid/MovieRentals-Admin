using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Domonic.Models
{
    public class Movie
    { 
            public String MovieTitle { get; set; }

            [Key]
            public int MovieId { get; set; }
            public int Year { get; set; }
            

    }
}
