
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Categoria_nuevaCategoria) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class CategoriaCEN
{
public int NuevaCategoria (string p_nombre, string p_descripcion)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Categoria_nuevaCategoria_customized) ENABLED START*/

        CategoriaEN categoriaEN = null;
        int oid;


        if (string.IsNullOrWhiteSpace (p_nombre)) {
                throw new ModelException ("El nombre de la categoria no puede estar vacio.");
        }

        if (p_nombre.Length < 3) {
                throw new ModelException ("El nombre de la categoria debe tener al menos 3 caracteres.");
        }

        // Inicializar entidad
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_nombre;
        categoriaEN.Descripcion = p_descripcion;

        // Llamada al repositorio
        oid = _ICategoriaRepository.NuevaCategoria (categoriaEN);
        return oid;

        /*PROTECTED REGION END*/
}
}
}
