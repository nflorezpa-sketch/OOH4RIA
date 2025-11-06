

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class ReporteCEN
 *
 */
public partial class ReporteCEN
{
private IReporteRepository _IReporteRepository;

public ReporteCEN(IReporteRepository _IReporteRepository)
{
        this._IReporteRepository = _IReporteRepository;
}

public IReporteRepository get_IReporteRepository ()
{
        return this._IReporteRepository;
}

public void ModificarReporte (int p_Reporte_OID, string p_usuarioReportado, string p_motivo, Nullable<DateTime> p_fecha, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoReporteEnum p_estado)
{
        ReporteEN reporteEN = null;

        //Initialized ReporteEN
        reporteEN = new ReporteEN ();
        reporteEN.Id = p_Reporte_OID;
        reporteEN.UsuarioReportado = p_usuarioReportado;
        reporteEN.Motivo = p_motivo;
        reporteEN.Fecha = p_fecha;
        reporteEN.Estado = p_estado;
        //Call to ReporteRepository

        _IReporteRepository.ModificarReporte (reporteEN);
}

public void EliminarReportePorID (int id
                                  )
{
        _IReporteRepository.EliminarReportePorID (id);
}

public ReporteEN ObtenerReportePorID (int id
                                      )
{
        ReporteEN reporteEN = null;

        reporteEN = _IReporteRepository.ObtenerReportePorID (id);
        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ObtenerReportes (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> list = null;

        list = _IReporteRepository.ObtenerReportes (first, size);
        return list;
}
}
}
