using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.ComponentModel.DataAnnotations;

namespace MS_ATG_Code_sample.Models
{

    public class VoteResultsViewModel
    {
        [Key]
        public float males;
        public float females;
    }
}