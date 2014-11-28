using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Harmotabs.Web.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserID { get; set; }
        public string Identifier { get; set; }
    }
}