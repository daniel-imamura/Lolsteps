namespace lolsteps_api.Models
{
    public class Champions
    {
         [Key]  
        public int ChampionId { get; set; }        

        [Required(ErrorMessage = "Este campo é obrigatório")]        
        public string ?Nome { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string ?Url { get; set; }        
    }
}