using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenPrimerParcial.Models
{
    public enum Type
    {

        Conocido,
        Compañero_de_estudio,
        Colega_de_trabajo,
        amigo_de_infancia,
        pariente

    }
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }

        string Name { get; set; }
        [Required]

        public Type Amigo { get; set; }

        string Nickname { get; set; }

        DateTime Fecha { get; set; }

    }
}