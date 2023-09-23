namespace JuegoDados.Services
{
    public class Dados
    {
        public int TirarDados()   //metodo a realizar por Dados
        {
            Random randomizar = new Random();           //metodos de NET para tirar el dado pre establecidos aca dentro
            return randomizar.Next(1,6);
        }
    }
}
