
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
 * Clase Insignia:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class InsigniaRepository : BasicRepository, IInsigniaRepository
{
public InsigniaRepository() : base ()
{
}


public InsigniaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public InsigniaEN ReadOIDDefault (int id
                                  )
{
        InsigniaEN insigniaEN = null;

        try
        {
                SessionInitializeTransaction ();
                insigniaEN = (InsigniaEN)session.Get (typeof(InsigniaNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return insigniaEN;
}

public System.Collections.Generic.IList<InsigniaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<InsigniaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InsigniaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<InsigniaEN>();
                        else
                                result = session.CreateCriteria (typeof(InsigniaNH)).List<InsigniaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InsigniaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (InsigniaEN insignia)
{
        try
        {
                SessionInitializeTransaction ();
                InsigniaNH insigniaNH = (InsigniaNH)session.Load (typeof(InsigniaNH), insignia.Id);

                insigniaNH.Perfil = insignia.Perfil;


                insigniaNH.RutaDeImg = insignia.RutaDeImg;



                session.Update (insigniaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InsigniaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


//Sin e: ObtenerInsigniaPorID
//Con e: InsigniaEN
public InsigniaEN ObtenerInsigniaPorID (int id
                                        )
{
        InsigniaEN insigniaEN = null;

        try
        {
                SessionInitializeTransaction ();
                insigniaEN = (InsigniaEN)session.Get (typeof(InsigniaNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return insigniaEN;
}

public System.Collections.Generic.IList<InsigniaEN> ObtenerTodasInsignias (int first, int size)
{
        System.Collections.Generic.IList<InsigniaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(InsigniaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<InsigniaEN>();
                else
                        result = session.CreateCriteria (typeof(InsigniaNH)).List<InsigniaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InsigniaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public int NuevaInsignia (InsigniaEN insignia)
{
        InsigniaNH insigniaNH = new InsigniaNH (insignia);

        try
        {
                SessionInitializeTransaction ();

                session.Save (insigniaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InsigniaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return insigniaNH.Id;
}
}
}
