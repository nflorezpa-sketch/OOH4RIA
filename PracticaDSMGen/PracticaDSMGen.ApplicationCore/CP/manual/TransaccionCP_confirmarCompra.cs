
using System;
using System.Text;

using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;
using PracticaDSMGen.ApplicationCore.CEN.PracticaDSM;



/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CP.PracticaDSM_Transaccion_confirmarCompra) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CP.PracticaDSM
{
public partial class TransaccionCP : GenericBasicCP
{
public void ConfirmarCompra (int p_oid)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CP.PracticaDSM_Transaccion_confirmarCompra) ENABLED START*/

        TransaccionCEN transaccionCEN = null;



        try
        {
                CPSession.SessionInitializeTransaction ();
                transaccionCEN = new  TransaccionCEN (CPSession.UnitRepo.TransaccionRepository);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method ConfirmarCompra() not yet implemented.");



                CPSession.Commit ();
        }
        catch (Exception ex)
        {
                CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                CPSession.SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
