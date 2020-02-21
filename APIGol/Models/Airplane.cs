using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIGol.Models
{
    public class Airplane
    {
        [Key]
        public int AviaoId { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string CodAviao { get; set; }
       
        [MaxLength(150)]
        public string Modelo { get; set; }

        public int QtdPassageiro { get; set; }

        public DateTime DtRegistro { get; set; }

    }
}
