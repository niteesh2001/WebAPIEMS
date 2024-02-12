using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebAPIEMS.Models
{
    [Table("DeptMaster")]
    public class DeptMaster
    {

        [Key]
        public int DeptCode { get; set; }
        public string? DeptName { get; set; } = null!;

        public virtual ICollection<EmpProfile>? EmpProfiles { get; set; } 
    }
}
