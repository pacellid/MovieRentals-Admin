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
        [Key]
        public int MovieId { get; set; }
        public String MovieTitle { get; set; }
        public int MovieYear { get; set; }
    }
}
