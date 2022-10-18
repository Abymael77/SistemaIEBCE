var dataTable;
var dataTableBlk;


function cargarDatatable() {
    dataTable = $("#tblCiclos").DataTable({
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
                            <a href='/Secretario/ImpresionNota/ListBloque/?idCicEs=${data}' class='btn btn-outline-primary mr-1' title="Bloque">
                            <i class="fa-solid fa-cube"></i>
                            </a>
                            <a href='/Secretario/ImpresionNota/ListEstudiante/?IdBloque=-1000&IdCicloEsc=${data}' class='btn btn-outline-primary mr-1' title="Estudiantes">
                            <i class="fa-solid fa-print"></i>
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

function cargarDatatableBloque1(idCicEs) {
    dataTableBlk = $("#tblBloque").DataTable({
        "ajax": {
            "url": "/Secretario/ImpresionNota/Bloque/?idCicEs=" + idCicEs,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "5%" },
            { "data": "nomBloque", "width": "20%" },
            { "data": "idCicloEscolar", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="d-flex justify-content-center flex-nowrap">
                            <a href='/Secretario/ImpresionNota/ListEstudiante/?IdBloque=${data}&IdCicloEsc=${idCicEs}' class='btn btn-outline-primary mr-1' title="Estudiantes">
                            <i class="fa-solid fa-cube"></i>
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


function cargarDatatableEstudiante(IdBloque, IdCicloEsc) {
    dataTableBlk = $("#tblEstudiante").DataTable({
        "ajax": {
            "url": "/Secretario/ImpresionNota/GetListEstudiante/?IdBloque=" + IdBloque + "&IdCicloEsc=" + IdCicloEsc,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "5%" },
            { "data": "estudiante.carnet", "width": "10%" },
            { "data": "estudiante.nomEstudiante", "width": "40%" },
            { "data": "estudiante.apellEstudiante", "width": "40%" },
            {
                "data": "id",
                "render": function (data) {
                    return IdBloque < 0 ? `<div class="d-flex justify-content-center flex-nowrap">
                            <a href='/Secretario/ImpresionNota/BoletaPromedio/?idAsigEstudinate=${data}' class='btn btn-outline-danger mr-1' title="Notas">
                            <i class="fa-solid fa-print"></i>
                            </a>
                            </div>` : 
                        `<div class="d-flex justify-content-center flex-nowrap">
                            <a href='/Secretario/ImpresionNota/Boleta/?idAsigEstudinate=${data}&IdBloque=${IdBloque}' class='btn btn-outline-primary mr-1' title="Bloques">
                            <i class="fa-solid fa-print"></i>
                            </a>
                            </div>`;
                }, "width": "5%"
            }
        ],
        "language": {
            "url": "../lib/DataTables/idioma/es-ES.json",
            "emptyTable": "No hay registros"
        },
        "width": "100%"
    });
}

function CargarBoletaPromedio(cols) {
    dataTable = $('#NotasFull').DataTable({
        "createdRow": function (row, data, index) {
            if (data[cols] < 60) {
                $('td', row).eq(cols).css({
                    'font-weight': 'bold',
                    'color': '#CF0A0A',
                    'font-size': '110%',
                })
            } else {
                $('td', row).eq(cols).css({
                    'font-weight': 'bold',
                    'color': '#083AA9',
                    'font-size':'110%',
                })
            }
        },
        "language": {
            "url": "../lib/DataTables/idioma/es-ES.json",
            "emptyTable": "No hay registros"
        },
        "width": "100%",
        info: false,
        search: false,
        paging: false,
        searching: false,

    });
}

function CargarBoleta(idAsigEstudinate, idBloque) {
    dataTable = $('#Notas').DataTable({
        "ajax": {
            "url": "/Secretario/ImpresionNota/ListNotaCurso/?idAsigEstudinate=" + idAsigEstudinate + "&idBloque=" + idBloque,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "curso.nomCurso", "width": "70%" },
            {
                "data": "punteo",
                "render": function (data) {
                    return data >= 60 ? `<div class="d-flex justify-content-center"> <span class="text-infos font-weight-bolder">${data}</span> </div>` : `<div class="d-flex justify-content-center"> <span class="text-danger font-weight-bolder">${data}</span> </div>`;
                },
                "width": "20%"
            }
        ],
        "language": {
            "url": "../lib/DataTables/idioma/es-ES.json",
            "emptyTable": "No hay registros"
        },
        "width": "100%",
        info: false,
        search: false,
        paging: false,
        searching: false,

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