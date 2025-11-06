

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class CategoriaCEN
 *
 */
public partial class CategoriaCEN
{
private ICategoriaRepository _ICategoriaRepository;

public CategoriaCEN(ICategoriaRepository _ICategoriaRepository)
{
        this._ICategoriaRepository = _ICategoriaRepository;
}

public ICategoriaRepository get_ICategoriaRepository ()
{
        return this._ICategoriaRepository;
}

public void ModificarCategoriaPorID (int p_Categoria_OID, string p_nombre, string p_descripcion)
{
        CategoriaEN categoriaEN = null;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Id = p_Categoria_OID;
        categoriaEN.Nombre = p_nombre;
        categoriaEN.Descripcion = p_descripcion;
        //Call to CategoriaRepository

        _ICategoriaRepository.ModificarCategoriaPorID (categoriaEN);
}

public void EliminarCategoriaPorID (int id
                                    )
{
        _ICategoriaRepository.EliminarCategoriaPorID (id);
}

public CategoriaEN ActualizarCategoriaPorID (int id
                                             )
{
        CategoriaEN categoriaEN = null;

        categoriaEN = _ICategoriaRepository.ActualizarCategoriaPorID (id);
        return categoriaEN;
}

public System.Collections.Generic.IList<CategoriaEN> ObtenerTodasCategorias (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> list = null;

        list = _ICategoriaRepository.ObtenerTodasCategorias (first, size);
        return list;
}
public System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN> ObtenerVideojuegoPorNombre (string arg0)
{
        return _ICategoriaRepository.ObtenerVideojuegoPorNombre (arg0);
}
}
}
