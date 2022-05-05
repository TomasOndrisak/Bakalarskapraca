using System.ComponentModel.DataAnnotations;

namespace WASMrozvrh.Models
{
    public class Hodina
    {
        [Key] // primarny kluc
        public int Id { get; set; }
        [Required] // povinne pole nemôže vyjsť z konštruktora prázdne
        public string Nazov { get; set; }
       

    }
}
