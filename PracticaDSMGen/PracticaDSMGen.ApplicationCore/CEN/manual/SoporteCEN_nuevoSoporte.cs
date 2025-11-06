
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Soporte_nuevoSoporte) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class SoporteCEN
{
public int NuevoSoporte (string p_descripcion)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Soporte_nuevoSoporte_customized) START*/

        SoporteEN soporteEN = null;

        int oid;

        //Initialized SoporteEN
        soporteEN = new SoporteEN ();
        soporteEN.Descripcion = p_descripcion;

        //Call to SoporteRepository

        oid = _ISoporteRepository.NuevoSoporte (soporteEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
