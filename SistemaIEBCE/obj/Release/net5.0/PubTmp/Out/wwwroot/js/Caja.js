var dataTable;

$(document).ready(function () {
    cargarDatatable();
});

function cargarDatatable() {
    dataTable = $("#tblCaja").DataTable({
        "ajax": {
            "url": "/Tesorero/Caja/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "5%" },
            {
                "data": "inicio",
                "render": function (data) {
                    var dd = data.split('T');
                    return dd[0];
                },
                "width": "30%"
            },
            {
                "data": "fin",
                "render": function (data) {
                    if (data == null) {
                        var dd = '----';
                    }
                    else {
                        var dd = data.split('T');
                    }
                    return dd[0];
                },
                "width": "40%"
            },
            { "data": "montoInicial", "width": "5%" },
            {
                "data": "estado",
                "render": function (data) {
                    return data == 1 ? `<div class="d-flex justify-content-center"> <span class="badge badge-primary">Activo</span> </div>` : `<div class="d-flex justify-content-center"> <span class="badge badge-secondary">Inactivo</span> </div>`;
                },
                "width": "20%"
            },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="d-flex justify-content-center flex-nowrap">
                            <a href='/Tesorero/Caja/Edit/${data}' class='btn btn-outline-primary mr-1' title="Editar">
                            <i class='fas fa-edit'></i>
                            </a>
                            <a href='/Tesorero/Caja/CajaDetalleVer/?idCaja=${data}' class='btn btn-outline-primary' title="Ver">
                            <i class="fa-regular fa-eye"></i>
                            </a>
                            <a onclick="Delete('/Tesorero/Caja/Delete/${data}')" class='btn btn-outline-danger' title="Eliminar">
                            <i class='fas fa-trash-alt'></i>
                            </a>
                            </div>`;
                }, "width": "15%"
            }
        ],
        "language": {
            url: "../lib/DataTables/idioma/es-ES.json",
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
        "width": "100%"
    });
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

function DeleteAl(url) {
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
                        location.reload();
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