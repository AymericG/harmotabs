using System.ComponentModel.DataAnnotations.Schema;

namespace Harmotabs.Web.Models
{
    public class Tablature
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TablatureID { get; set; }
        public string Content { get; set; }
        public long SongID { get; set; }
        [ForeignKey("SongID")]
        public virtual Song Song { get; set; }

        public long ViewCount { get; set; }
    }
}