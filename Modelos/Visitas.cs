using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSC_Gimnasio.Modelos
{
    public class Visitas
    {
        [Key]
        public int Id_Visita { get; set; } // INT (PK)

        [Required]
        public int Id_Cliente { get; set; } // INT (FK)

        // Relación con la tabla Clientes
        [ForeignKey("Id_Cliente")]
        public Clientes Cliente { get; set; }

        [Required(ErrorMessage = "El campo Fecha de visita es obligatorio")]
        public DateTime Fecha_Visita { get; set; } // DATETIME
    }
}
