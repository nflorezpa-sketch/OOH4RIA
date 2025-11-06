
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Insignia_nuevaInsignia) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class InsigniaCEN
{
public int NuevaInsignia (string p_rutaDeImg)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Insignia_nuevaInsignia_customized) ENABLED START*/

        InsigniaEN insigniaEN = null;
        int oid;

        if (string.IsNullOrWhiteSpace (p_rutaDeImg)) {
                throw new ModelException ("La ruta de la imagen no puede estar vac�a.");
        }

        if (p_perfil < 1 || p_perfil > 4) {
                throw new ModelException ("El tipo de insignia especificado no es v�lido. Debe ser 1=Perfil, 2=Marco, 3=Fondo o 4=Icono.");
        }


        insigniaEN = new InsigniaEN ();
        insigniaEN.RutaDeImg = p_rutaDeImg;

        insigniaEN.Perfil = (PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoInsigniaEnum)p_perfil;

        oid = _IInsigniaRepository.NuevaInsignia (insigniaEN);
        return oid;

        /*PROTECTED REGION END*/
}
}
}
