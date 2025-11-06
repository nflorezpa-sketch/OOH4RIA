
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
 * Clase Videojuego:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class VideojuegoRepository : BasicRepository, IVideojuegoRepository
{
public VideojuegoRepository() : base ()
{
}


public VideojuegoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public VideojuegoEN ReadOIDDefault (int id
                                    )
{
        VideojuegoEN videojuegoEN = null;

        try
        {
                SessionInitializeTransaction ();
                videojuegoEN = (VideojuegoEN)session.Get (typeof(VideojuegoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return videojuegoEN;
}

public System.Collections.Generic.IList<VideojuegoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<VideojuegoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(VideojuegoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<VideojuegoEN>();
                        else
                                result = session.CreateCriteria (typeof(VideojuegoNH)).List<VideojuegoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VideojuegoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (VideojuegoEN videojuego)
{
        try
        {
                SessionInitializeTransaction ();
                VideojuegoNH videojuegoNH = (VideojuegoNH)session.Load (typeof(VideojuegoNH), videojuego.Id);





                videojuegoNH.Precio = videojuego.Precio;

                session.Update (videojuegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VideojuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevoVideojuego (VideojuegoEN videojuego)
{
        VideojuegoNH videojuegoNH = new VideojuegoNH (videojuego);

        try
        {
                SessionInitializeTransaction ();
                if (videojuego.Pedido != null) {
                        for (int i = 0; i < videojuego.Pedido.Count; i++) {
                                videojuego.Pedido [i] = (PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN)session.Load (typeof(PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN), videojuego.Pedido [i].Id);
                                videojuego.Pedido [i].Videojuego.Add (videojuegoNH);
                        }
                }

                session.Save (videojuegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VideojuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return videojuegoNH.Id;
}

public void EditarVideojuegoPorID (VideojuegoEN videojuego)
{
        try
        {
                SessionInitializeTransaction ();
                VideojuegoNH videojuegoNH = (VideojuegoNH)session.Load (typeof(VideojuegoNH), videojuego.Id);

                videojuegoNH.Precio = videojuego.Precio;

                session.Update (videojuegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VideojuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void EliminarVideojuegoPorID (int id
                                     )
{
        try
        {
                SessionInitializeTransaction ();
                VideojuegoNH videojuegoNH = (VideojuegoNH)session.Load (typeof(VideojuegoNH), id);
                session.Delete (videojuegoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VideojuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ObtenerVideojuegoPorID
//Con e: VideojuegoEN
public VideojuegoEN ObtenerVideojuegoPorID (int id
                                            )
{
        VideojuegoEN videojuegoEN = null;

        try
        {
                SessionInitializeTransaction ();
                videojuegoEN = (VideojuegoEN)session.Get (typeof(VideojuegoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return videojuegoEN;
}

public System.Collections.Generic.IList<VideojuegoEN> ObtenerTodosVideojuegos (int first, int size)
{
        System.Collections.Generic.IList<VideojuegoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(VideojuegoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<VideojuegoEN>();
                else
                        result = session.CreateCriteria (typeof(VideojuegoNH)).List<VideojuegoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VideojuegoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
