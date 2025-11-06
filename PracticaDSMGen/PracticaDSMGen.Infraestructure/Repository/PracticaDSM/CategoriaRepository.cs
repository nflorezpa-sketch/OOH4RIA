
using System;
using System.Text;
using PracticaDSMGen.ApplicationCore.CEN.PracticaDSM;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;
using PracticaDSMGen.Infraestructure.EN.PracticaDSM;


/*
 * Clase Categoria:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class CategoriaRepository : BasicRepository, ICategoriaRepository
{
public CategoriaRepository() : base ()
{
}


public CategoriaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public CategoriaEN ReadOIDDefault (int id
                                   )
{
        CategoriaEN categoriaEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoriaEN = (CategoriaEN)session.Get (typeof(CategoriaNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return categoriaEN;
}

public System.Collections.Generic.IList<CategoriaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CategoriaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<CategoriaEN>();
                        else
                                result = session.CreateCriteria (typeof(CategoriaNH)).List<CategoriaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CategoriaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaNH categoriaNH = (CategoriaNH)session.Load (typeof(CategoriaNH), categoria.Id);

                categoriaNH.Nombre = categoria.Nombre;


                categoriaNH.Descripcion = categoria.Descripcion;


                session.Update (categoriaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CategoriaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevaCategoria (CategoriaEN categoria)
{
        CategoriaNH categoriaNH = new CategoriaNH (categoria);

        try
        {
                SessionInitializeTransaction ();

                session.Save (categoriaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CategoriaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoriaNH.Id;
}

public void ModificarCategoriaPorID (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaNH categoriaNH = (CategoriaNH)session.Load (typeof(CategoriaNH), categoria.Id);

                categoriaNH.Nombre = categoria.Nombre;


                categoriaNH.Descripcion = categoria.Descripcion;

                session.Update (categoriaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CategoriaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void EliminarCategoriaPorID (int id
                                    )
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaNH categoriaNH = (CategoriaNH)session.Load (typeof(CategoriaNH), id);
                session.Delete (categoriaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CategoriaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ActualizarCategoriaPorID
//Con e: CategoriaEN
public CategoriaEN ActualizarCategoriaPorID (int id
                                             )
{
        CategoriaEN categoriaEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoriaEN = (CategoriaEN)session.Get (typeof(CategoriaNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return categoriaEN;
}

public System.Collections.Generic.IList<CategoriaEN> ObtenerTodasCategorias (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CategoriaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<CategoriaEN>();
                else
                        result = session.CreateCriteria (typeof(CategoriaNH)).List<CategoriaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CategoriaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN> ObtenerVideojuegoPorNombre (string arg0)
{
        System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CategoriaNH self where FROM VideojuegoEN AS v WHERE v.nombre LIKE CONCAT('%', :nombreVideojuego, '%')";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CategoriaNHobtenerVideojuegoPorNombreHQL");
                query.SetParameter ("arg0", arg0);

                result = query.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.CategoriaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CategoriaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
