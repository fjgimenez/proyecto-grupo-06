﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp1
{
    [Serializable()]
    public class Clientes : Usuarios
    {
        
        public Clientes(string nombre, string apellido, string rut, string mail, string telefono, string contraseña) : base(nombre, apellido, rut, mail, telefono, contraseña)
        {
        }

    }
}
