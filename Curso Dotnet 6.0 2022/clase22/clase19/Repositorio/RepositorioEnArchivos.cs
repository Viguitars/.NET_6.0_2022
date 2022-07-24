﻿using clase19.Interfaces;
using clase19.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase19.Repositorio
{
    public class RepositorioEnArchivos<T> : IRepositorio<T> where T : Persona
    {
        private string _pathArchivo = "c:\\persona.txt";

        public void Actualizar(T persona)
        {
            //Actualizo persona en un archivo
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            //Actualizo persona en un archivo
        }

        public void Eliminar(string numeroDocumento)
        {
            //Elimino persona en un archivo
        }

        public bool Existe(string numeroDocumento)
        {
            //Verifico si existe persona en un archivo
            return true;
        }
        
        public bool Existe(T persona)
        {
            //Verifico si existe persona en un archivo
            return true;
        }

        public void Insertar(T persona)
        {
            //Inserto persona en un archivo
        }
    }
}
