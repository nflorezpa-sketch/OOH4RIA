

using System;
using System.Text;
using System.Collections.Generic;

using PracticaDSMGen.ApplicationCore.Exceptions;

using PracticaDSMGen.ApplicationCore.EN.PracticaDSM;
using PracticaDSMGen.ApplicationCore.IRepository.PracticaDSM;


namespace PracticaDSMGen.ApplicationCore.CEN.PracticaDSM
{
/*
 *      Definition of the class TransaccionCEN
 *
 */
public partial class TransaccionCEN
{
private ITransaccionRepository _ITransaccionRepository;

public TransaccionCEN(ITransaccionRepository _ITransaccionRepository)
{
        this._ITransaccionRepository = _ITransaccionRepository;
}

public ITransaccionRepository get_ITransaccionRepository ()
{
        return this._ITransaccionRepository;
}

public int NuevaTransaccion (Nullable<DateTime> p_fecha, double p_total, string p_metodoPago, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoOperacionEnum p_tipoOperacion)
{
        TransaccionEN transaccionEN = null;
        int oid;

        //Initialized TransaccionEN
        transaccionEN = new TransaccionEN ();
        transaccionEN.Fecha = p_fecha;

        transaccionEN.Total = p_total;

        transaccionEN.MetodoPago = p_metodoPago;

        transaccionEN.TipoOperacion = p_tipoOperacion;



        oid = _ITransaccionRepository.NuevaTransaccion (transaccionEN);
        return oid;
}

public void EditarTransaccionPorID (int p_Transaccion_OID, Nullable<DateTime> p_fecha, double p_total, string p_metodoPago, PracticaDSMGen.ApplicationCore.Enumerated.PracticaDSM.TipoOperacionEnum p_tipoOperacion)
{
        TransaccionEN transaccionEN = null;

        //Initialized TransaccionEN
        transaccionEN = new TransaccionEN ();
        transaccionEN.Id = p_Transaccion_OID;
        transaccionEN.Fecha = p_fecha;
        transaccionEN.Total = p_total;
        transaccionEN.MetodoPago = p_metodoPago;
        transaccionEN.TipoOperacion = p_tipoOperacion;
        //Call to TransaccionRepository

        _ITransaccionRepository.EditarTransaccionPorID (transaccionEN);
}

public void EliminarTransaccionPorID (int id
                                      )
{
        _ITransaccionRepository.EliminarTransaccionPorID (id);
}

public TransaccionEN ObtenerTransaccionPorID (int id
                                              )
{
        TransaccionEN transaccionEN = null;

        transaccionEN = _ITransaccionRepository.ObtenerTransaccionPorID (id);
        return transaccionEN;
}

public System.Collections.Generic.IList<TransaccionEN> ObtenerTodasTransacciones (int first, int size)
{
        System.Collections.Generic.IList<TransaccionEN> list = null;

        list = _ITransaccionRepository.ObtenerTodasTransacciones (first, size);
        return list;
}
}
}
