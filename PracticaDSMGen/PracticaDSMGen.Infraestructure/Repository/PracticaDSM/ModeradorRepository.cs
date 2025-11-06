
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
 * Clase Moderador:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class ModeradorRepository : BasicRepository, IModeradorRepository
{
public ModeradorRepository() : base ()
{
}


public ModeradorRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ModeradorEN ReadOIDDefault (int id
                                   )
{
        ModeradorEN moderadorEN = null;

        try
        {
                SessionInitializeTransaction ();
                moderadorEN = (ModeradorEN)session.Get (typeof(ModeradorNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return moderadorEN;
}

public System.Collections.Generic.IList<ModeradorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ModeradorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ModeradorNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ModeradorEN>();
                        else
                                result = session.CreateCriteria (typeof(ModeradorNH)).List<ModeradorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ModeradorRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ModeradorEN moderador)
{
        try
        {
                SessionInitializeTransaction ();
                ModeradorNH moderadorNH = (ModeradorNH)session.Load (typeof(ModeradorNH), moderador.Id);

                moderadorNH.Correo = moderador.Correo;


                moderadorNH.Contraseña = moderador.Contraseña;



                session.Update (moderadorNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ModeradorRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevoModerador (ModeradorEN moderador)
{
        ModeradorNH moderadorNH = new ModeradorNH (moderador);

        try
        {
                SessionInitializeTransaction ();

                session.Save (moderadorNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ModeradorRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return moderadorNH.Id;
}
}
}
