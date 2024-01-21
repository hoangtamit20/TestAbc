using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCLP.Data.Entities
{
    [Table("UrlHelper")]
    public class UrlHelperEntity
    {
        [Key]
        public int Id { get; set; }
        public string UrlResetPassword { get; set; } = string.Empty;
        public string UrlConfirmEmail { get; set; } = string.Empty;
    }
}