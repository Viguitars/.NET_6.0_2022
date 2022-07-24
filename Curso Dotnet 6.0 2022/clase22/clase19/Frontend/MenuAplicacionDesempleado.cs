using clase19.Interfaces;
using clase19.Modelo;

namespace clase19.Frontend
{
    public class MenuAplicacionDesempleado
    {
        private IRepositorio<Desempleado> _repositorio;
        public MenuAplicacionDesempleado(IRepositorio<Desempleado> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Iniciar()
        {
            
        }
    }
}
