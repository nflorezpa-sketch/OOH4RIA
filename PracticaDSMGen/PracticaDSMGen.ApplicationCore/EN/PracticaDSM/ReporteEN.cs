
using System;
// Definición clase ReporteEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class ReporteEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo usuarioReportado
 */
private string usuarioReportado;



/**
 *	Atributo motivo
 */
private string motivo;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo estado
 */
private PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoReporteEnum estado;



/**
 *	Atributo moderador
 */
private System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN> moderador;



/**
 *	Atributo usuario
 */
private PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string UsuarioReportado {
        get { return usuarioReportado; } set { usuarioReportado = value;  }
}



public virtual string Motivo {
        get { return motivo; } set { motivo = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoReporteEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN> Moderador {
        get { return moderador; } set { moderador = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ReporteEN()
{
        moderador = new System.Collections.Generic.List<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN>();
}



public ReporteEN(int id, string usuarioReportado, string motivo, Nullable<DateTime> fecha, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoReporteEnum estado, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN> moderador, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario
                 )
{
        this.init (Id, usuarioReportado, motivo, fecha, estado, moderador, usuario);
}


public ReporteEN(ReporteEN reporte)
{
        this.init (reporte.Id, reporte.UsuarioReportado, reporte.Motivo, reporte.Fecha, reporte.Estado, reporte.Moderador, reporte.Usuario);
}

private void init (int id
                   , string usuarioReportado, string motivo, Nullable<DateTime> fecha, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.EstadoReporteEnum estado, System.Collections.Generic.IList<PracticaDSMGen.ApplicationCore.EN.PracticaDSM.ModeradorEN> moderador, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.UsuarioEN usuario)
{
        this.Id = id;


        this.UsuarioReportado = usuarioReportado;

        this.Motivo = motivo;

        this.Fecha = fecha;

        this.Estado = estado;

        this.Moderador = moderador;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReporteEN t = obj as ReporteEN;
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
