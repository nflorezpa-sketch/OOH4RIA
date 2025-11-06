
using System;
using System.Text;
using System.Collections.Generic;
using PracticaDSMGen.ApplicationCore.Exceptions;
using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


/*PROTECTED REGION ID(usingPracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Moderador_nuevoModerador) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
public partial class ModeradorCEN
{
public int NuevoModerador (string p_correo, String p_contraseña)
{
        /*PROTECTED REGION ID(PracticaDSMGen.ApplicationCore.CEN.PracticaDSM_Moderador_nuevoModerador_customized) ENABLED START*/

        ModeradorEN moderadorEN = null;
        int oid;

        // 🔐 VALIDACIONES PERSONALIZADAS

        if (string.IsNullOrWhiteSpace (p_correo)) {
                throw new ModelException ("El correo del moderador no puede estar vacío.");
        }

        if (string.IsNullOrWhiteSpace (p_contraseña)) {
                throw new ModelException ("La contraseña no puede estar vacía.");
        }

        // Debe contener al menos una mayúscula
        if (!Regex.IsMatch (p_contraseña, "[A-Z]")) {
                throw new ModelException ("La contraseña debe contener al menos una letra mayúscula.");
        }

        // Debe contener al menos un número
        if (!Regex.IsMatch (p_contraseña, "[0-9]")) {
                throw new ModelException ("La contraseña debe contener al menos un número.");
        }

        // Inicializar ModeradorEN
        moderadorEN = new ModeradorEN ();
        moderadorEN.Correo = p_correo;

        //Encriptar la contraseña antes de guardarla
        moderadorEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);

        // Guardar en el repositorio
        oid = _IModeradorRepository.NuevoModerador (moderadorEN);
        return oid;

        /*PROTECTED REGION END*/
}
}
}
