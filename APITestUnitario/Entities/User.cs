namespace APITestUnitario.Entities
{
    public class User
    {
        public User()
        {
            Nome = "Fernando";
            Idade = 36;
        }


        public string? Nome { get; set; }    
        public int Idade { get; set; }  
    }
}
