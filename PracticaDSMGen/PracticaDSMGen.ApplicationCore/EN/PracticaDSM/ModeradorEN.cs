
using System;
// Definición clase ModeradorEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class ModeradorEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo correo
 */
private string correo;



/**
 *	Atributo contraseña
 */
private String contraseña;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> reporte;



/**
 *	Atributo soporte
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> soporte;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Correo {
        get { return correo; } set { correo = value;  }
}



public virtual String Contraseña {
        get { return contraseña; } set { contraseña = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> Soporte {
        get { return soporte; } set { soporte = value;  }
}





public ModeradorEN()
{
        reporte = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN>();
        soporte = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN>();
}



public ModeradorEN(int id, string correo, String contraseña, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> reporte, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> soporte
                   )
{
        this.init (Id, correo, contraseña, reporte, soporte);
}


public ModeradorEN(ModeradorEN moderador)
{
        this.init (moderador.Id, moderador.Correo, moderador.Contraseña, moderador.Reporte, moderador.Soporte);
}

private void init (int id
                   , string correo, String contraseña, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ReporteEN> reporte, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.SoporteEN> soporte)
{
        this.Id = id;


        this.Correo = correo;

        this.Contraseña = contraseña;

        this.Reporte = reporte;

        this.Soporte = soporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ModeradorEN t = obj as ModeradorEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
