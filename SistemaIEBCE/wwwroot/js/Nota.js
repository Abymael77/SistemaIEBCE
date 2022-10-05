
var dataTable;
var dataTableBlk;


function cargarDatatable() {
    dataTable = $("#tblNota").DataTable({
        "ajax": {
            "url": "/Secretario/CicloEscolar/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "5%" },
            { "data": "anio", "width": "20%" },
            { "data": "grado.nomGrado", "width": "20%" },
            { "data": "seccion.nomSeccion", "width": "20%" },
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
                            <a href='/Secretario/Nota/Curso/?IdCicloEscolar=${data}' class='btn btn-outline-primary mr-1' title="Cursos">
                            <i class='fas fa-edit'></i>
                            </a>
                            </div>`;
                }, "width": "15%"
            }
        ],
        "language": {
            "url": "../lib/DataTables/idioma/es-ES.json",
            "emptyTable": "No hay registros"
        },
        "width": "100%"
    });
}

function cargarDatatableNotaCurso() {
    dataTable = $("#tblNotaCurso").DataTable({
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
        "width": "100%"
    });
}

function cargarDatatableBloque(AsCur, IdCicloEscolar) {
    dataTableBlk = $("#tblBloque").DataTable({
        "ajax": {
            "url": "/Secretario/Nota/GetAll/" + AsCur,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "5%" },
            { "data": "bloque.nomBloque", "width": "20%" },
            {
                "data": "bloque.estado",
                "render": function (data) {
                    return data == 1 ? `<div class="d-flex justify-content-center"> <span class="badge badge-primary">Activo</span> </div>` : `<div class="d-flex justify-content-center"> <span class="badge badge-secondary">Inactivo</span> </div>`;
                },
                "width": "20%"
            },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="d-flex justify-content-center flex-nowrap">
                            <a href='/Secretario/Nota/ListEstudiante/?IdBlkAsCu=${data}&IdCicloEscolar=${IdCicloEscolar}&IdAsigCurso=${AsCur}' class='btn btn-outline-primary mr-1' title="Cursos">
                            <i class='fas fa-edit'></i>
                            </a>
                            </div>`;
                }, "width": "15%"
            }
        ],
        "language": {
            "url": "../lib/DataTables/idioma/es-ES.json",
            "emptyTable": "No hay registros"
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