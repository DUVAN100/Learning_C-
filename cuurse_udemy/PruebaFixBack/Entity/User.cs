using Domain.Entity.Base;
using System.ComponentModel.DataAnnotations;
namespace Entity
{
    public class User : EntityB
    {
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(20)]
        public string IdentityNumber { get; set; }
        public int Age { get; set; }
        public string House { get; set; }
    }
}
