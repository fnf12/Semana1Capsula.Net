using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionMvc.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingrese un Nombre")]
        [StringLength(255,MinimumLength =3,
            ErrorMessage ="El nombre debe tener un minimo de 3 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ingrese un Apellido")]
        [StringLength(255, MinimumLength = 3,
            ErrorMessage = "El Apellido debe tener un minimo de 3 caracteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Ingrese un Mail")]
        [EmailAddress(ErrorMessage ="El mail no es valido")]
        [StringLength(255)]
        public string Mail { get; set; }

        [StringLength(30)]
        public string Telephone { get; set; }
    }
}
