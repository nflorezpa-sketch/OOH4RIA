
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
 * Clase Reporte:
 *
 */

namespace PracticaDSMGen.Infraestructure.Repository.PracticaDSM
{
public partial class ReporteRepository : BasicRepository, IReporteRepository
{
public ReporteRepository() : base ()
{
}


public ReporteRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ReporteEN ReadOIDDefault (int id
                                 )
{
        ReporteEN reporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Get (typeof(ReporteNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReporteNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                        else
                                result = session.CreateCriteria (typeof(ReporteNH)).List<ReporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReporteRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteNH reporteNH = (ReporteNH)session.Load (typeof(ReporteNH), reporte.Id);

                reporteNH.UsuarioReportado = reporte.UsuarioReportado;


                reporteNH.Motivo = reporte.Motivo;


                reporteNH.Fecha = reporte.Fecha;


                reporteNH.Estado = reporte.Estado;



                session.Update (reporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevoReporte (ReporteEN reporte)
{
        ReporteNH reporteNH = new ReporteNH (reporte);

        try
        {
                SessionInitializeTransaction ();

                session.Save (reporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteNH.Id;
}

public void ModificarReporte (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteNH reporteNH = (ReporteNH)session.Load (typeof(ReporteNH), reporte.Id);

                reporteNH.UsuarioReportado = reporte.UsuarioReportado;


                reporteNH.Motivo = reporte.Motivo;


                reporteNH.Fecha = reporte.Fecha;


                reporteNH.Estado = reporte.Estado;

                session.Update (reporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void EliminarReportePorID (int id
                                  )
{
        try
        {
                SessionInitializeTransaction ();
                ReporteNH reporteNH = (ReporteNH)session.Load (typeof(ReporteNH), id);
                session.Delete (reporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ObtenerReportePorID
//Con e: ReporteEN
public ReporteEN ObtenerReportePorID (int id
                                      )
{
        ReporteEN reporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Get (typeof(ReporteNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ObtenerReportes (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReporteNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                else
                        result = session.CreateCriteria (typeof(ReporteNH)).List<ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PracticaDSMGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new PracticaDSMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
