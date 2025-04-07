﻿using PilamungaS_Taller.Models;

namespace PilamungaS_Taller.Repositorios
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuleveListadoEquipos()
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
            equipos.Add(ldu);
            return equipos;
        }
    }
}
