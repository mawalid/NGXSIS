using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{
    [Table("x_addrbook")]
    public class AddrBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(AllowEmptyStrings = false)]
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }

        public Nullable<long> modified_by { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> modified_on { get; set; }

        public Nullable<long> deleted_by { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> deleted_on { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Boolean is_delete { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Boolean is_locked { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int attempt { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string email { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required(AllowEmptyStrings = false)]
        public string abuid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required(AllowEmptyStrings = false)]
        public string abpwd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string fp_token { get; set; }

        [Column(TypeName = "DateTime")]
        public Nullable<DateTime> fp_expired_date { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Nullable<int> fp_counter { get; set; }
    }
}
