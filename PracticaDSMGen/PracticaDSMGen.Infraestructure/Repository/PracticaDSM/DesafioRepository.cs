
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
 * Clase Desafio:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class DesafioRepository : BasicRepository, IDesafioRepository
{
public DesafioRepository() : base ()
{
}


public DesafioRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public DesafioEN ReadOIDDefault (int id
                                 )
{
        DesafioEN desafioEN = null;

        try
        {
                SessionInitializeTransaction ();
                desafioEN = (DesafioEN)session.Get (typeof(DesafioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return desafioEN;
}

public System.Collections.Generic.IList<DesafioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DesafioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DesafioNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<DesafioEN>();
                        else
                                result = session.CreateCriteria (typeof(DesafioNH)).List<DesafioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DesafioRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DesafioEN desafio)
{
        try
        {
                SessionInitializeTransaction ();
                DesafioNH desafioNH = (DesafioNH)session.Load (typeof(DesafioNH), desafio.Id);

                desafioNH.Nombre = desafio.Nombre;


                desafioNH.Descripcion = desafio.Descripcion;



                session.Update (desafioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DesafioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearDesafio (DesafioEN desafio)
{
        DesafioNH desafioNH = new DesafioNH (desafio);

        try
        {
                SessionInitializeTransaction ();

                session.Save (desafioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DesafioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return desafioNH.Id;
}

public void EliminarDesafio (int id
                             )
{
        try
        {
                SessionInitializeTransaction ();
                DesafioNH desafioNH = (DesafioNH)session.Load (typeof(DesafioNH), id);
                session.Delete (desafioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DesafioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ObtenerDesafioPorID
//Con e: DesafioEN
public DesafioEN ObtenerDesafioPorID (int id
                                      )
{
        DesafioEN desafioEN = null;

        try
        {
                SessionInitializeTransaction ();
                desafioEN = (DesafioEN)session.Get (typeof(DesafioNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return desafioEN;
}

public System.Collections.Generic.IList<DesafioEN> ObtenerTodosDesafios (int first, int size)
{
        System.Collections.Generic.IList<DesafioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DesafioNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<DesafioEN>();
                else
                        result = session.CreateCriteria (typeof(DesafioNH)).List<DesafioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DesafioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> ObtenerDesafioPorVideojuego (int ? p_idVideojuego)
{
        System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DesafioNH self where select de FROM DesafioNH as de join  de.Videojuegos as v where v.id = :p_idVideojuego";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DesafioNHobtenerDesafioPorVideojuegoHQL");
                query.SetParameter ("p_idVideojuego", p_idVideojuego);

                result = query.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.DesafioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DesafioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
