using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MS_ATG_Code_sample.Models
{

    public class Votes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; set; }

        public string Gender { get; set; }
    }
}