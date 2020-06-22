namespace trycatch
{
    public class Permissao
    {
         private bool Acesso { get; set; }

        public void Autorizar(){

            //analisa essa parte do codigo e mostra o texto do catch no lugar do erro
            try{

                Console.WriteLine("Acessar aplicação? True/False");
                Acesso = Boolean.Parse( Console.ReadLine() );

            }catch(Exception){

                Console.WriteLine("Erro nos dados inseridos, erro gerado");

            }
    }
}