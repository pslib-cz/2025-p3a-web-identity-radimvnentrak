using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace CoffeeRecordsIdentity.Models
{
    public class CoffeeCup: IdentityUser
    {
        public int CoffeeCupId { get; set; }
        [Display(Name = "Short Name")]

        //[ForeignKey(UserId)]
        public string UserName { get; set; } = String.Empty;
        public ApplicationUser UserId { get; set; } // asi?
        [Display(Name = "Time and date")]
        public DateTime Created { get; set; }
        [Display(Name = "Id of Machine")]
        public int MachineNo { get; set; }
    }
}
