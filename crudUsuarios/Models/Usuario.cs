﻿using System;
using System.ComponentModel.DataAnnotations;

namespace crudUsuarios.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El celular es obligatorio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }
    }
}
