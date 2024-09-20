using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Bebidas
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public bool Activa { get; set; }

        [NotMapped] public Tipos? _Tipo { get; set; }
    }
}