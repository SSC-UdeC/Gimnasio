using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SSC_Gimnasio.Modelos
{
    public class Clientes
    {
        [Key]
        public int Id_Cliente { get; set; } // INT (PK)

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no debe exceder los 100 caracteres")]
        public string ?Nombre { get; set; } // VARCHAR(100)

        [Required(ErrorMessage = "El campo Teléfono es obligatorio")]
        [StringLength(10, ErrorMessage = "El teléfono no debe exceder los 10 caracteres")]
        public string ?Telefono { get; set; } // VARCHAR(10)

        [Required(ErrorMessage = "El campo Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido")]
        [StringLength(50, ErrorMessage = "El correo electrónico no debe exceder los 50 caracteres")]
        public string ?Email { get; set; } // VARCHAR(100)

        [Required(ErrorMessage = "El campo Fecha de registro es obligatorio")]
        public DateTime Fecha_Registro { get; set; } // DATE

        [Required(ErrorMessage = "El campo Fecha de vencimiento es obligatorio")]
        public DateTime Fecha_Vencimiento { get; set; } // DATE

        [Required(ErrorMessage = "El campo Teléfono de emergencia es obligatorio")]
        [StringLength(10, ErrorMessage = "El teléfono de emergencia no debe exceder los 10 caracteres")]
        public string ?Telefono_Emergencia { get; set; } // VARCHAR(10)

        public ICollection<Visitas> ?Visitas { get; set; } 
    }
}
