

function RegistrarCobro() {
    const divdiases = document.getElementById("ases").textContent;
    var NoReciboval = document.getElementById("NoRecibo");
    //console.log(divdiases);
    if (divdiases == "idAsEs") {
        Swal.fire({
            icon: 'warning',
            title: "Selecciona a un estudiante",
            confirmButtonText: 'Aceptar',
            focusConfirm: false,
        })
    }
    else if (NoReciboval.value == "" || NoReciboval.value < 0 || NoReciboval.value == undefined) {
        Swal.fire({
            icon: 'warning',
            title: "Numero de factura invalido",
            confirmButtonText: 'Aceptar',
            focusConfirm: false,
        })
    }
    else {
        //Activar select de estuduante
        var estu = document.getElementById("estu");
        estu.disabled = false;

        //fecha
        var fecha = document.getElementById("fecha");
        var NoRecibo = document.getElementById("NoRecibo");

        //idAsEs
        var estu = document.getElementById("estu");
        var arr = estu.value.split('-');

        var ListaCuota = [];
        var InputCuota = document.getElementsByClassName('idCuota'),
            CuotaValue = [].map.call(InputCuota, function (dataInput) {
                ListaCuota.push(dataInput.value);
            });

        var ListaCantidad = [];
        var InputCantidad = document.getElementsByClassName('cantidad'),
            CantidadValue = [].map.call(InputCantidad, function (dataInput) {
                ListaCantidad.push(dataInput.value);
            });

        var ListaMonto = [];
        var InputMonto = document.getElementsByClassName('monto'),
            MontoValue = [].map.call(InputMonto, function (dataInput) {
                ListaMonto.push(dataInput.value);
            });


        console.log("==================================>|");
        console.log("ListaCuota => " + ListaCuota);
        console.log("ListaCantidad => " + ListaCantidad);
        console.log("ListaMonto => " + ListaMonto);
        console.log("idAsEs =>" + arr[1]);
        console.log("fecha => " + fecha.value);
        console.log("NoRecibo => " + NoRecibo.value);

        $.ajax({
            url: "/Tesorero/Factura/SaveDetalleFactura",
            type: "post",
            data: {
                ListaCuota1: ListaCuota,
                ListaCantidad1: ListaCantidad,
                ListaMonto1: ListaMonto,
                idAsEs1: arr[1],
                fecha: fecha.value,
                noRecibo: NoRecibo.value
            },
            dataType: "json",
            traditional: true,
        });

        window.location.href = '/Tesorero/Menu/Index';
    }


}