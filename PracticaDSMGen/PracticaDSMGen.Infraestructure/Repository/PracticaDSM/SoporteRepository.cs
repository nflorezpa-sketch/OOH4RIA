
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
 * Clase Soporte:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class SoporteRepository : BasicRepository, ISoporteRepository
{
public SoporteRepository() : base ()
{
}


public SoporteRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public SoporteEN ReadOIDDefault (int id
                                 )
{
        SoporteEN soporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                soporteEN = (SoporteEN)session.Get (typeof(SoporteNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return soporteEN;
}

public System.Collections.Generic.IList<SoporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SoporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SoporteNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<SoporteEN>();
                        else
                                result = session.CreateCriteria (typeof(SoporteNH)).List<SoporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in SoporteRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SoporteEN soporte)
{
        try
        {
                SessionInitializeTransaction ();
                SoporteNH soporteNH = (SoporteNH)session.Load (typeof(SoporteNH), soporte.Id);

                soporteNH.Descripcion = soporte.Descripcion;


                soporteNH.Estado = soporte.Estado;



                session.Update (soporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in SoporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public System.Collections.Generic.IList<SoporteEN> ObtenerSoportes (int first, int size)
{
        System.Collections.Generic.IList<SoporteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SoporteNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<SoporteEN>();
                else
                        result = session.CreateCriteria (typeof(SoporteNH)).List<SoporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in SoporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void EliminarSoporte (int id
                             )
{
        try
        {
                SessionInitializeTransaction ();
                SoporteNH soporteNH = (SoporteNH)session.Load (typeof(SoporteNH), id);
                session.Delete (soporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in SoporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ObtenerSoportePorID
//Con e: SoporteEN
public SoporteEN ObtenerSoportePorID (int id
                                      )
{
        SoporteEN soporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                soporteEN = (SoporteEN)session.Get (typeof(SoporteNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return soporteEN;
}

public int NuevoSoporte (SoporteEN soporte)
{
        SoporteNH soporteNH = new SoporteNH (soporte);

        try
        {
                SessionInitializeTransaction ();

                session.Save (soporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in SoporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return soporteNH.Id;
}
}
}
