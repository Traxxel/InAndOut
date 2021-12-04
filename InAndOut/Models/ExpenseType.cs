using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InAndOut.Models
{
    public class ExpenseType
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense Type")]
        [Required]
        public String Name { get; set; }
    }
}
