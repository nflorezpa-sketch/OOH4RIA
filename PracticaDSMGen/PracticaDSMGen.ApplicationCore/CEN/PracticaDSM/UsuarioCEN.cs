

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;
using Newtonsoft.Json;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioRepository _IUsuarioRepository;

public UsuarioCEN(IUsuarioRepository _IUsuarioRepository)
{
        this._IUsuarioRepository = _IUsuarioRepository;
}

public IUsuarioRepository get_IUsuarioRepository ()
{
        return this._IUsuarioRepository;
}

public int Registrar (string p_nombreUsuario, string p_correo, string p_telefono, string p_apodo, String p_contraseña)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.NombreUsuario = p_nombreUsuario;

        usuarioEN.Correo = p_correo;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.Apodo = p_apodo;

        usuarioEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);



        oid = _IUsuarioRepository.Registrar (usuarioEN);
        return oid;
}

public void EditarUsuario (int p_Usuario_OID, string p_nombreUsuario, string p_correo, string p_telefono, string p_apodo, String p_contraseña)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Id = p_Usuario_OID;
        usuarioEN.NombreUsuario = p_nombreUsuario;
        usuarioEN.Correo = p_correo;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.Apodo = p_apodo;
        usuarioEN.Contraseña = Utils.Util.GetEncondeMD5 (p_contraseña);
        //Call to UsuarioRepository

        _IUsuarioRepository.EditarUsuario (usuarioEN);
}

public void EliminarUsuario (int id
                             )
{
        _IUsuarioRepository.EliminarUsuario (id);
}

public System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN> FiltrarProductosPrecio (string arg0)
{
        return _IUsuarioRepository.FiltrarProductosPrecio (arg0);
}
public UsuarioEN ObtenerUsuarioPorID (int id
                                      )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioRepository.ObtenerUsuarioPorID (id);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ObtenerTodosUsuarios (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioRepository.ObtenerTodosUsuarios (first, size);
        return list;
}
public string IniciarSesion (int p_Usuario_OID, string p_pass)
{
        string result = null;
        UsuarioEN en = _IUsuarioRepository.ReadOIDDefault (p_Usuario_OID);

        if (en != null && en.Contraseña.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en.Id);

        return result;
}

public System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN> ObtenerUsuariosPorInsignia (string arg0)
{
        return _IUsuarioRepository.ObtenerUsuariosPorInsignia (arg0);
}



private string Encode ()
{
        var payload = new Dictionary<string, object>(){
                {}
        };
        string token = Jose.JWT.Encode (payload, Utils.Util.getKey (), Jose.JwsAlgorithm.HS256);

        return token;
}

public string GetToken (int id)
{
        UsuarioEN en = _IUsuarioRepository.ReadOIDDefault (id);
        string token = Encode ();

        return token;
}
public int CheckToken (string token)
{
        int result = -1;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                int id = (int)ObtenerID (decodedToken);

                UsuarioEN en = _IUsuarioRepository.ReadOIDDefault (id);

                if (en != null && ((long)en.Id).Equals (ObtenerID (decodedToken))
                    ) {
                        result = id;
                }
                else throw new ModelException ("El token es incorrecto");
        } catch (Exception)
        {
                throw new ModelException ("El token es incorrecto");
        }

        return result;
}
}
}
