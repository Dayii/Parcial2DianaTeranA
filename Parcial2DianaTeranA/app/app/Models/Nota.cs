namespace app.Models
{
    class Nota
    {
        [Key]
        public int NotaId { get; set; }

        [Required]
        [Display(Nota = "Nota")]
        public string Nota { get; set; }

     
    }
}
