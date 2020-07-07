using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularcrudWebApi.DBModels
{
    public class PaymentDetail
    {
        [Key]
        public int PMId { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string CardOwnerName { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string CardNumber { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string ExpirationDate { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string CVV { get; set; }
    }
}
