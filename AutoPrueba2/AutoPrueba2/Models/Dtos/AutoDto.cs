using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPrueba2.Models.Dtos
{
    public class AutoDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Deposito { get; set; }
        public string MatriculaCaracterUno { get; set; }
        public int MatriculaCaracterDos { get; set; }
        public string MatriculaCaracterTres { get; set; }
        public string Fecha { get; set; }
        public string MatriculaConcatenada { get; set; }
    }
}
