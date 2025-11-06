
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Reporte_nuevoReporte) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class ReporteCEN
{
public int NuevoReporte (string p_usuarioReportado, string p_motivo, Nullable<DateTime> p_fecha)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Reporte_nuevoReporte_customized) START*/

        ReporteEN reporteEN = null;

        int oid;

        //Initialized ReporteEN
        reporteEN = new ReporteEN ();
        reporteEN.UsuarioReportado = p_usuarioReportado;

        reporteEN.Motivo = p_motivo;

        reporteEN.Fecha = p_fecha;

        //Call to ReporteRepository

        oid = _IReporteRepository.NuevoReporte (reporteEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
