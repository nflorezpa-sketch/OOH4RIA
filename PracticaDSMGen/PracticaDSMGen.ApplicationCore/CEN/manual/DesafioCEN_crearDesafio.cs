
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Desafio_crearDesafio) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class DesafioCEN
{
public int CrearDesafio (string p_nombre, string p_descripcion)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Desafio_crearDesafio_customized) ENABLED START*/

        DesafioEN desafioEN = null;
        int oid;


        if (string.IsNullOrWhiteSpace (p_nombre) || p_nombre.Length < 2) {
                throw new ModelException ("El nombre del desafio debe tener al menos 2 caracteres y no puede estar vacio.");
        }


        if (!char.IsUpper (p_nombre [0])) {
                throw new ModelException ("El nombre del desafio debe empezar con una letra mayuscula.");
        }

        desafioEN = new DesafioEN ();
        desafioEN.Nombre = p_nombre;
        desafioEN.Descripcion = p_descripcion;

        oid = _IDesafioRepository.CrearDesafio (desafioEN);
        return oid;

        /*PROTECTED REGION END*/
}
}
}
