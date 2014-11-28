using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Harmotabs.Web.Models
{
    public class Song
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SongID { get; set; }
        public string Name { get; set; }
        public long ArtistID { get; set; }
        [ForeignKey("ArtistID")]
        public virtual Artist Artist { get; set; }

        public ICollection<Tablature> Tablatures { get; set; }
    }
}