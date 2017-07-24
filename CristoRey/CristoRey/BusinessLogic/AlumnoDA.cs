using CristoRey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CristoRey.BussinessLogic
{
    public class AlumnoDA
    {
        ALUMNO objAlumno = new ALUMNO();
        public List<string> Errores { get; private set; }
        //ADD MET PRU. UNIT.
        public bool EsValido(ALUMNO alumno)
        {
            Errores = new List<string>();
            var valido = true;
            if (string.IsNullOrWhiteSpace(alumno.nom_alum))
            {
                Errores.Add("El nombre del alumno es requerido.");
                valido = false;
            }
            if (alumno.dni_alum.Length < 8)
            {
                Errores.Add("El Dni debe ser correcto.");
                valido = false;
            }
            return valido;
        }
    }
}