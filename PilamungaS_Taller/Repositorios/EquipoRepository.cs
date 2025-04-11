using Microsoft.AspNetCore.Razor.Language.Intermediate;
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
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };

            Equipo cnb = new Equipo
            {
                Id = 3,
                Nombre = "Cuniburo",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo uct = new Equipo
            {
                Id = 4,
                Nombre = "U.Catolica",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo inv = new Equipo
            {
                Id = 5,
                Nombre = "Independiente",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo lbt = new Equipo
            {
                Id = 6,
                Nombre = "Libertad",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo dcu = new Equipo
            {
                Id = 7,
                Nombre = "Dep.Cuenca",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo orn = new Equipo
            {
                Id = 8,
                Nombre = "Orense",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo msr = new Equipo
            {
                Id = 9,
                Nombre = "MushucRuna",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo auc = new Equipo
            {
                Id = 10,
                Nombre = "Aucas",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo mca = new Equipo
            {
                Id = 11,
                Nombre = "Macara",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo mnt = new Equipo
            {
                Id = 12,
                Nombre = "Manta",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo tuv = new Equipo
            {
                Id = 13,
                Nombre = "TecnicoUniversitario",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo emc = new Equipo
            {
                Id = 14,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo del = new Equipo
            {
                Id = 15,
                Nombre = "Delfin",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            Equipo nac = new Equipo
            {
                Id = 16,
                Nombre = "Nacional",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 0,
                PartidosPerdidos = 2
            };
            equipos.Add(bsc);
            equipos.Add(ldu);
            equipos.Add(cnb);
            equipos.Add(uct);
            equipos.Add(inv);
            equipos.Add(lbt);
            equipos.Add(dcu);
            equipos.Add(orn);
            equipos.Add(msr);
            equipos.Add(auc);
            equipos.Add(mca);
            equipos.Add(mnt);
            equipos.Add(tuv);
            equipos.Add(emc);
            equipos.Add(del);
            equipos.Add(nac);
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
            var equipos = DevuelveEquipoPorId(Id);
            equipos.PartidosGanados = equipo.PartidosGanados;
            equipos.PartidosJugados = equipo.PartidosJugados;
            equipos.PartidosEmpatados = equipo.PartidosEmpatados;
            equipos.PartidosPerdidos= equipo.PartidosPerdidos;
            
            return true;
        }
    }
}

