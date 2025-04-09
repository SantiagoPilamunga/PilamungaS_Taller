using PilamungaS_Taller.Models;

namespace PilamungaS_Taller.Repositorios
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> Equipos;
        public EquipoRepository()
        {
            Equipos = DevuelveListadoEquipos();
        }
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de quito",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };


            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "Liga de quito",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            equipos.Add(bsc);
            equipos.Add(ldu);
            return equipos;
        }

        public Equipo DevuelveEquipoPorId(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo= equipos.First(IThreadPoolWorkItem=> IThreadPoolWorkItem.Id == Id);
            return equipo;
        }

        public bool ActualizarEquipo(int Id,Equipo equipo)
        {
            //logica de actualizacion
            return true;
        }
    }
}

