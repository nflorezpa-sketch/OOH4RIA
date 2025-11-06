
using System;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CP.PracticaDSM;

namespace PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM
{
public partial interface IVendedorRepository
{
void setSessionCP (GenericSessionCP session);

VendedorEN ReadOIDDefault (int id
                           );

void ModifyDefault (VendedorEN vendedor);

System.Collections.Generic.IList<VendedorEN> ReadAllDefault (int first, int size);





int NuevoVendedor (VendedorEN vendedor);

VendedorEN ObtenerVendedorPorID (int id
                                 );
}
}
