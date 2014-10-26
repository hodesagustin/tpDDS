using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using OrganizadorFutbol5.Clases;

namespace OrganizadorFutbol5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Administrador administrador = new Administrador("Admin", "admin@gmail.com");
            Partido partido = new Partido(DateTime.Now,administrador);

            /* addCalificacion
            Jugador jugador = new Jugador("Prueba", 5);
            Calificacion calif1 = new Calificacion("BIEN", 10, partido);
            Calificacion calif2 = new Calificacion("MAL", 2, partido);
            Calificacion calif3 = new Calificacion("MASO", 5, partido);
            Calificacion calif4 = new Calificacion("MASO-MAL", 6, partido);
            Calificacion calif5 = new Calificacion("MASO-BIEN", 8, partido);

            jugador.addCalificacion(calif1);
            jugador.addCalificacion(calif2);
            jugador.addCalificacion(calif3);
            jugador.addCalificacion(calif4);
            jugador.addCalificacion(calif5);

            MessageBox.Show("Promedio: " + jugador.getPromedio(5));
            */

            /* ORDENAMIENTO
            int cantidadPartidos = 2;
            List<Jugador> jugadores = new List<Jugador>();
            Jugador j1 = new Jugador("J1", 1);
            j1.addCalificacion(new Calificacion("",10,partido));
            j1.addCalificacion(new Calificacion("", 8, partido));
            Jugador j2 = new Jugador("J2", 2);
            j2.addCalificacion(new Calificacion("", 8, partido));
            j2.addCalificacion(new Calificacion("", 5, partido));
            Jugador j3 = new Jugador("J3", 3);
            j3.addCalificacion(new Calificacion("", 6, partido));
            j3.addCalificacion(new Calificacion("", 4, partido));
            Jugador j4 = new Jugador("J4", 4);
            j4.addCalificacion(new Calificacion("", 4, partido));
            j4.addCalificacion(new Calificacion("", 7, partido));
            Jugador j5 = new Jugador("J5", 5);
            j5.addCalificacion(new Calificacion("", 2, partido));
            j5.addCalificacion(new Calificacion("", 2, partido));
            Jugador j6 = new Jugador("J6", 6);
            j6.addCalificacion(new Calificacion("", 1, partido));
            j6.addCalificacion(new Calificacion("", 1, partido));
            Jugador j7 = new Jugador("J7", 7);
            j7.addCalificacion(new Calificacion("", 3, partido));
            j7.addCalificacion(new Calificacion("", 4, partido));
            Jugador j8 = new Jugador("J8", 8);
            j8.addCalificacion(new Calificacion("", 5, partido));
            j8.addCalificacion(new Calificacion("", 6, partido));
            Jugador j9 = new Jugador("J9", 9);
            j9.addCalificacion(new Calificacion("", 7, partido));
            j9.addCalificacion(new Calificacion("", 2, partido));
            Jugador j10 = new Jugador("J10", 10);
            j10.addCalificacion(new Calificacion("", 9, partido));
            j10.addCalificacion(new Calificacion("", 9, partido));

            CriterioOrdenamientoPorHandicap criterioOrdenamientoHandicap = new CriterioOrdenamientoPorHandicap();
            CriterioOrdenamientoPorPromedio criterioOrdenamientoPromedio = new CriterioOrdenamientoPorPromedio(cantidadPartidos);
            CriterioOrdenamientoPorPromedioUltimoPartido criterioOrdenamientoPromedioUltimoPartido = new CriterioOrdenamientoPorPromedioUltimoPartido();
            List<CriterioOrdenamiento> criteriosOrdenamiento = new List<CriterioOrdenamiento>();
            criteriosOrdenamiento.Add(criterioOrdenamientoHandicap);
            criteriosOrdenamiento.Add(criterioOrdenamientoPromedioUltimoPartido);
            CriterioOrdenamientoCompuesto criterioOrdenamientoCompuesto = new CriterioOrdenamientoCompuesto(criteriosOrdenamiento);

            jugadores.Add(j1);
            jugadores.Add(j2);
            jugadores.Add(j3);
            jugadores.Add(j4);
            jugadores.Add(j5);
            jugadores.Add(j6);
            jugadores.Add(j7);
            jugadores.Add(j8);
            jugadores.Add(j9);
            jugadores.Add(j10);

            for (int i = 0; i < jugadores.Count;  i++)
            {
                MessageBox.Show(jugadores[i].ToString() + " - h+p/2: " + (jugadores[i].handicap + jugadores[i].getPromedio(1))/2,"pre-ordenamiento");
            }
            jugadores = jugadores.OrderByDescending(jugador => criterioOrdenamientoCompuesto.getPuntaje(jugador)).ToList();
            for (int i = 0; i < jugadores.Count; i++)
            {
                MessageBox.Show(jugadores[i].ToString() + " - h+p/2: " + (jugadores[i].handicap + jugadores[i].getPromedio(1))/2,"pos-ordenamiento");
            }
            */

            /* DIVISION 
            List<Jugador> jugadores = new List<Jugador>();
            List<Jugador> equipoA= new List<Jugador>();
            List<Jugador> equipoB = new List<Jugador>();
            CriterioDivisionPredeterminado criterioDivision = new CriterioDivisionPredeterminado();

            for (int i = 0 ; i < 10 ; i++)
            {
              jugadores.Add(new Jugador("j" + (i + 1), i + 1));
            }
            criterioDivision.dividir(jugadores, equipoA, equipoB);
            for (int i = 0; i < equipoA.Count;  i++)
            {
              MessageBox.Show(equipoA[i].ToString(),"equipoA");
            }
            for (int i = 0; i < equipoB.Count; i++)
            {
              MessageBox.Show(equipoB[i].ToString(),"equipoB");
            }
            */

            /*
            Partido partido = new Partido(DateTime.Now); 
            Jugador jugador = new Jugador("Agu",5);
            Inscripcion inscripcionStandard = new Inscripcion(new InscripcionTipoStandard(), jugador);
            Jugador Jugador = new Jugador("Pepe",9);
            Inscripcion inscripcionSolidaria = new Inscripcion(new InscripcionTipoSolidaria(), Jugador);
            Inscripcion inscripcionSolidaria2 = new Inscripcion(new InscripcionTipoSolidaria(), new Jugador("B",1));
            Inscripcion inscripcionStandard2 = new Inscripcion(new InscripcionTipoStandard(), new Jugador("C",8));

            partido.inscribir(inscripcionStandard);
            partido.inscribir(inscripcionSolidaria);
            partido.inscribir(inscripcionSolidaria2); 
            partido.inscribir(inscripcionStandard2);

            List<Jugador> jugadores = partido.getJugadoresInscriptos();
            MessageBox.Show(""+jugadores.Count);

            partido.baja(jugador);
            jugadores = partido.getJugadoresInscriptos();
            MessageBox.Show("" + jugadores.Count);

            Jugador reemplazo = new Jugador("Reemplazo",7);
            partido.baja(Jugador,reemplazo);
            jugadores = partido.getJugadoresInscriptos();
            MessageBox.Show("" + jugadores.Count);
            */

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new HomeAdministrador(-1));
            */
        }
    }
}
