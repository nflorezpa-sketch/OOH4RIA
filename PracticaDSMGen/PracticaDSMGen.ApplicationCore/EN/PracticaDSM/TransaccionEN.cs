
using System;
// Definición clase TransaccionEN
namespace PracticaDSMGen.ApplicationCore.EN.PracticaDSM
{
public partial class TransaccionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo total
 */
private double total;



/**
 *	Atributo metodoPago
 */
private string metodoPago;



/**
 *	Atributo tipoOperacion
 */
private PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoOperacionEnum tipoOperacion;



/**
 *	Atributo pedido
 */
private PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN pedido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual double Total {
        get { return total; } set { total = value;  }
}



public virtual string MetodoPago {
        get { return metodoPago; } set { metodoPago = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoOperacionEnum TipoOperacion {
        get { return tipoOperacion; } set { tipoOperacion = value;  }
}



public virtual PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public TransaccionEN()
{
}



public TransaccionEN(int id, Nullable<DateTime> fecha, double total, string metodoPago, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoOperacionEnum tipoOperacion, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN pedido
                     )
{
        this.init (Id, fecha, total, metodoPago, tipoOperacion, pedido);
}


public TransaccionEN(TransaccionEN transaccion)
{
        this.init (transaccion.Id, transaccion.Fecha, transaccion.Total, transaccion.MetodoPago, transaccion.TipoOperacion, transaccion.Pedido);
}

private void init (int id
                   , Nullable<DateTime> fecha, double total, string metodoPago, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoOperacionEnum tipoOperacion, PracticaDSMGen.ApplicationCore.EN.PracticaDSM.PedidoEN pedido)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Total = total;

        this.MetodoPago = metodoPago;

        this.TipoOperacion = tipoOperacion;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TransaccionEN t = obj as TransaccionEN;
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
