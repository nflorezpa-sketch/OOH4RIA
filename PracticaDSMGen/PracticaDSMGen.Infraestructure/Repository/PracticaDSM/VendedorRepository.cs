
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
 * Clase Vendedor:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class VendedorRepository : BasicRepository, IVendedorRepository
{
public VendedorRepository() : base ()
{
}


public VendedorRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public VendedorEN ReadOIDDefault (int id
                                  )
{
        VendedorEN vendedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                vendedorEN = (VendedorEN)session.Get (typeof(VendedorNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return vendedorEN;
}

public System.Collections.Generic.IList<VendedorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<VendedorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(VendedorNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<VendedorEN>();
                        else
                                result = session.CreateCriteria (typeof(VendedorNH)).List<VendedorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VendedorRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (VendedorEN vendedor)
{
        try
        {
                SessionInitializeTransaction ();
                VendedorNH vendedorNH = (VendedorNH)session.Load (typeof(VendedorNH), vendedor.Id);
                session.Update (vendedorNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VendedorRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevoVendedor (VendedorEN vendedor)
{
        VendedorNH vendedorNH = new VendedorNH (vendedor);

        try
        {
                SessionInitializeTransaction ();

                session.Save (vendedorNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in VendedorRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vendedorNH.Id;
}

//Sin e: ObtenerVendedorPorID
//Con e: VendedorEN
public VendedorEN ObtenerVendedorPorID (int id
                                        )
{
        VendedorEN vendedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                vendedorEN = (VendedorEN)session.Get (typeof(VendedorNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return vendedorEN;
}
}
}
