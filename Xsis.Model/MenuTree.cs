using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_menutree")]
    public class MenuTree
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(AllowEmptyStrings =false)]
        public long id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required(AllowEmptyStrings = false)]
        public string title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string menu_image_url { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string menu_icon { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int menu_order { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int menu_level { get; set; }

        public Nullable<long> menu_parent { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string menu_url { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        [Required(AllowEmptyStrings = false)]
        public string menu_type { get; set; }

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

    }
}
