
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Vendedor_nuevoVendedor) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class VendedorCEN
{
public int NuevoVendedor (string p_nombreUsuario, string p_correo, string p_telefono, string p_apodo, String p_contraseña)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Vendedor_nuevoVendedor_customized) START*/

        VendedorEN vendedorEN = null;

        int oid;

        //Initialized VendedorEN
        vendedorEN = new VendedorEN ();
        vendedorEN.NombreUsuario = p_nombreUsuario;

        vendedorEN.Correo = p_correo;

        vendedorEN.Telefono = p_telefono;

        vendedorEN.Apodo = p_apodo;

        vendedorEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);

        //Call to VendedorRepository

        oid = _IVendedorRepository.NuevoVendedor (vendedorEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
