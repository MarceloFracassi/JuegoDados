using JuegoDados.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace JuegoDados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JuegosDadosController : ControllerBase  //primero constructor
    {
        private readonly Dados _dados;      //Segundo Paso, clase privada.  ****
        private readonly MetodoPrueba _metodoPueba;

        public JuegosDadosController( Dados dados, MetodoPrueba metodoPrueba)  //Dentro del constructor se recibe un parametro del tipo
        {
            _dados = dados;                       // ahi dentro igualas ese parametro al de _  ****
            _metodoPueba = metodoPrueba;
        }

        [HttpGet]   //aca va URL por defecto con verb Get
        public IActionResult Get()                     ///***
        {
            return Ok(_dados.TirarDados());
        }

        [HttpGet ("all")]   //aca va con otro GET pero se cambia URL porque sino no lo permite
        public IActionResult GetAllDados()              //*****
        { 
            List<int> tirada = new List<int>();   ///Generacion de una lista
            for(var i = 0; i <= 6; i++)
            {
                tirada.Add(_dados.TirarDados());
            }
            return Ok();
        }                                           //En el controller se usa una interfaz en el [HttpGet]****
                                                    //por que la interfaz IActionResult Get() por que nos permite devolver 
                                                    //mas de un tipo de elemento. 
        [HttpPut ("MetodoPruebaConRuta")]
        public IActionResult Put()
        {
            return Ok(_metodoPueba.MostrarMensaje());
        }
    }
}