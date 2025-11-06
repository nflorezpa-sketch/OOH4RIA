
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
 * Clase Transaccion:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class TransaccionRepository : BasicRepository, ITransaccionRepository
{
public TransaccionRepository() : base ()
{
}


public TransaccionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public TransaccionEN ReadOIDDefault (int id
                                     )
{
        TransaccionEN transaccionEN = null;

        try
        {
                SessionInitializeTransaction ();
                transaccionEN = (TransaccionEN)session.Get (typeof(TransaccionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return transaccionEN;
}

public System.Collections.Generic.IList<TransaccionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TransaccionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TransaccionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<TransaccionEN>();
                        else
                                result = session.CreateCriteria (typeof(TransaccionNH)).List<TransaccionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TransaccionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TransaccionEN transaccion)
{
        try
        {
                SessionInitializeTransaction ();
                TransaccionNH transaccionNH = (TransaccionNH)session.Load (typeof(TransaccionNH), transaccion.Id);

                transaccionNH.Fecha = transaccion.Fecha;


                transaccionNH.Total = transaccion.Total;


                transaccionNH.MetodoPago = transaccion.MetodoPago;


                transaccionNH.TipoOperacion = transaccion.TipoOperacion;


                session.Update (transaccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TransaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevaTransaccion (TransaccionEN transaccion)
{
        TransaccionNH transaccionNH = new TransaccionNH (transaccion);

        try
        {
                SessionInitializeTransaction ();

                session.Save (transaccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TransaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return transaccionNH.Id;
}

public void EditarTransaccionPorID (TransaccionEN transaccion)
{
        try
        {
                SessionInitializeTransaction ();
                TransaccionNH transaccionNH = (TransaccionNH)session.Load (typeof(TransaccionNH), transaccion.Id);

                transaccionNH.Fecha = transaccion.Fecha;


                transaccionNH.Total = transaccion.Total;


                transaccionNH.MetodoPago = transaccion.MetodoPago;


                transaccionNH.TipoOperacion = transaccion.TipoOperacion;

                session.Update (transaccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TransaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void EliminarTransaccionPorID (int id
                                      )
{
        try
        {
                SessionInitializeTransaction ();
                TransaccionNH transaccionNH = (TransaccionNH)session.Load (typeof(TransaccionNH), id);
                session.Delete (transaccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TransaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ObtenerTransaccionPorID
//Con e: TransaccionEN
public TransaccionEN ObtenerTransaccionPorID (int id
                                              )
{
        TransaccionEN transaccionEN = null;

        try
        {
                SessionInitializeTransaction ();
                transaccionEN = (TransaccionEN)session.Get (typeof(TransaccionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return transaccionEN;
}

public System.Collections.Generic.IList<TransaccionEN> ObtenerTodasTransacciones (int first, int size)
{
        System.Collections.Generic.IList<TransaccionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TransaccionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<TransaccionEN>();
                else
                        result = session.CreateCriteria (typeof(TransaccionNH)).List<TransaccionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TransaccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
