
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface IReporteRepository
{
void setSessionCP (GenericSessionCP session);

ReporteEN ReadOIDDefault (int id
                          );

void ModifyDefault (ReporteEN reporte);

System.Collections.Generic.IList<ReporteEN> ReadAllDefault (int first, int size);



int NuevoReporte (ReporteEN reporte);

void ModificarReporte (ReporteEN reporte);


void EliminarReportePorID (int id
                           );


ReporteEN ObtenerReportePorID (int id
                               );


System.Collections.Generic.IList<ReporteEN> ObtenerReportes (int first, int size);
}
}
