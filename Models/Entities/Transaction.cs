using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    [Table("transactions")]
    public class Transaction
    {
        [Key] //Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-Increment Annotation
        public int Id { get; set; }
        public decimal Balance { get; set; } //Shows the Account Balance that user belongs in account. 
        public bool isCreditCard { get; set; } //Debit Card or Credit Card Bool Value
    }
}
