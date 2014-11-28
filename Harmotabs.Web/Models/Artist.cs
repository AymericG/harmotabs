using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Harmotabs.Web.Models
{
    public class Artist
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ArtistID { get; set; }
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}