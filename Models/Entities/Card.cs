using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    [Table("cards")]
    public class Card
    {
        [Key] // Primary Key Of Card Model
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-Increment Annotation of Id
        public int id { get; set; }
        public string CardType { get; set; } // Card Type such as VISA, MasterCard etc.
        public string CardNumber { get; set; } // This is the card number which has 16 digits
        public string ExpirationDate { get; set; } // This is the expiration date of card
        public string CVC { get; set; } // This is the CVC number which is continued after 16 digits of Card number
        public int TransactionId { get; set; } // Connection between Card Model and Transaction Model as One to One
        [ForeignKey("TransactionId")]
        public ICollection<Transaction> Transactions { get; set; }
        //public Transaction Transactions { get; set; }

    }
}
