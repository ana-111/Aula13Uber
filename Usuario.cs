namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome{ get; set; }

        private string login =  "anacarolina@gmail.com";

        private string senha =  "954564864";

        public string Foto { get; set; }

        public string LocalizacaoAtual { get; set; }
        
        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){
              if(this.login == login && this.senha == senha){
                TokenLogin = "qweqweqweqweqwewqe1231231231231232";
                return true;
                }
                return false;
        }
         public void Logout(){
            TokenLogin = "";
            }
        

    }
}