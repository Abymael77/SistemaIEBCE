var dataTable;

function cargarDatatableLsEst(IdBlkAsCu, IdCicloEscolar, IdAsigCurso) {
    dataTable = $('#listEstu').DataTable({
        "ajax": {
            "url": "/Secretario/Nota/ListEstudianteLS/?IdBlkAsCu=" + IdBlkAsCu + "&est=1&IdCicloEscolar=" + IdCicloEscolar +"&IdAsigCurso=" + IdAsigCurso,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "nota.id",
                "render": function (data) {
                    return `<td><input class="form-control-plaintext idnt" value='${data}' readonly ></td>`;
                },
                "width": "10%"
            },
            {
                "data": "nota.idAsigEstudinate",
                "render": function (data) {
                    return `<td><input class="form-control-plaintext idases" value='${data}'  readonly ></td>`;
                },
                "width": "10%"
            },
            { "data": "estudiante.nomEstudiante", "width": "30%" },
            { "data": "estudiante.apellEstudiante", "width": "30%" },
            {
                "data": "nota.punteo",
                "render": function (data) {
                    if (data == null) {
                        return `<td><input class="innota form-control" value="0" type="number" min="0" max="100"></td>`;
                    }
                    else {
                        return `<td><input class="innota form-control" value="${data}" type="number" min="0" max="100"></td>`;
                    }
                },
                "width": "20%"
            }
        ],
        "language": {
            "url": "../lib/DataTables/idioma/es-ES.json",
            "emptyTable": "Ningún dato disponible en esta tabla",
            "search": "Buscar:",
            "paginate": {
                "first": "Primero",
                "last": "Último",
                "next": "Siguiente",
                "previous": "Anterior"
            },
            "info": "Mostrando _START_ a _END_ de _TOTAL_ registros",
            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "infoFiltered": "(filtrado de un total de _MAX_ registros)",
        },
        "width": "100%",
        info: false,
        search: false,
        paging: false,
        searching: false,
        ordering: false,
    });
}



function RegistrarNota(idBlk) {
    var ListaEstNota = [];
    var InputNota = document.getElementsByClassName('innota'),
        NotaValue = [].map.call(InputNota, function (dataInput) {
            ListaEstNota.push(dataInput.value);
        });

    var ListaIdEst = [];
    var TdId = document.getElementsByClassName('idases'),
        IdValue = [].map.call(TdId, function (dataInput) {
            ListaIdEst.push(dataInput.value);
        });

    var ListaIdNt = [];
    var TdNtId = document.getElementsByClassName('idnt'),
        IdNtValue = [].map.call(TdNtId, function (dataInput) {
            ListaIdNt.push(dataInput.value);
        });

    $.ajax({
        url: "/Secretario/Nota/SaveNota",
        type: "post",
        data: {
            ListaEstNota1: ListaEstNota,
            ListaIdEst1: ListaIdEst,
            ListaIdNt1: ListaIdNt,
            IdBlkAsCu1: idBlk,
        },
        dataType: "json",
        traditional: true,
        success: function (data) {
            Swal.fire(
                'Exito',
                'Datos enviados',
                'success'
            )
        },
        error: function (error) {
            Swal.fire(
                'Error',
                'Datos NO enviados',
                'error'
            )
        }
    })

    //ListaEstNota.forEach(function (inputsDataValue) {
    //    console.log("Nota: " + inputsDataValue);
    //});

    //ListaIdEst.forEach(function (inputsDataValue) {
    //    console.log("ID: " + inputsDataValue);
    //});

    //console.log(idBlk);

    //var url = "/Secretario/Nota/SaveNota";
    //var data = { ListaEstNota1: ListaEstNota, ListaIdEst1: ListaIdEst, IdBlkAsCu1: idBlk };

    //$.post(url, data).done(function (data) {
    //    swal.fire(
    //        'exito',
    //        'datos enviados',
    //        'success'
    //    )
    //}).fail(function (error) {
    //    swal.fire(
    //        'error',
    //        'datos no enviados',
    //        'error'
    //    )
    //});

    //$.ajax({
    //    url: "/Secretario/Nota/SaveNota",
    //    type: "post",
    //    data: JSON.stringify({ ListaEstNota1: ListaEstNota, ListaIdEst1: ListaIdEst, IdBlkAsCu1: idBlk}),
    //    dataType: "json",
    //    contentType: 'application/json; charset=utf-8',
    //    success: function (data) {
    //        Swal.fire(
    //            'Exito',
    //            'Datos enviados',
    //            'success'
    //        )
    //    },
    //    error: function (error) {
    //        Swal.fire(
    //            'Error',
    //            'Datos NO enviados',
    //            'error'
    //        )
    //    }
    //})

}


function Delete(url) {
    swal.fire({
        icon: 'error',
        iconColor: "#FF6565",
        title: "Esta seguro de borrar?",
        text: "Este contenido no se puede recuperar! ",
        showCancelButton: true,
        cancelButtonColor: "#17172b",
        confirmButtonColor: "#FF6565",
        confirmButtonText: "Si, borrar!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: 'DELETE',
                url: url,
                success: function (data) {
                    if (data.success) {
                        const Toast = Swal.mixin({
                            toast: true,
                            position: 'bottom-end',
                            showConfirmButton: false,
                            timer: 2000,
                            timerProgressBar: true,
                            didOpen: (toast) => {
                                toast.addEventListener('mouseenter', Swal.stopTimer)
                                toast.addEventListener('mouseleave', Swal.resumeTimer)
                            }
                        })
                        Toast.fire({
                            icon: 'success',
                            title: data.message
                        })
                        dataTable.ajax.reload();
                    }
                    else {
                        const Toast = Swal.mixin({
                            toast: true,
                            position: 'bottom-end',
                            showConfirmButton: false,
                            timer: 2000,
                            timerProgressBar: true,
                            didOpen: (toast) => {
                                toast.addEventListener('mouseenter', Swal.stopTimer)
                                toast.addEventListener('mouseleave', Swal.resumeTimer)
                            }
                        })
                        Toast.fire({
                            icon: 'error',
                            title: data.message
                        })
                    }
                }
            });
        }
    });

}