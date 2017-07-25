using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CristoRey.Models;
using CristoRey.BussinessLogic;
using System.Linq;

namespace UnitTestCristoRey
{
    [TestClass]
    public class UnitTestAlumno
    {
        //NOMBRE ALUMNO
        [TestMethod]       
        public void EsValido_AlumnoConNombreEsValido()
        {
            var servicioAlumnoDA = new AlumnoDA();
            var alumno = new ALUMNO() {dni_alum = "71842016" };
            var resultado = servicioAlumnoDA.EsValido(alumno);
            Assert.IsFalse(resultado);
            Assert.IsTrue(servicioAlumnoDA.Errores.Any());
        }

        //DNI ALUMNO
        [TestMethod]
        public void EsValido_AlumnoConDniCorrectoEsValido()
        {
            //METODO 2
            var servicioAlumnoDA = new AlumnoDA();
            var alumno = new ALUMNO() { nom_alum = "Roy Brayan" , dni_alum="71842016" };
            var resultado = servicioAlumnoDA.EsValido(alumno);
            Assert.IsTrue(resultado);
            Assert.IsFalse(servicioAlumnoDA.Errores.Any());
        }
    }
}
