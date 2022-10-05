var dataTable;
var dataTableBlk;
var dataTableAs;

function cargarDatatableAsCicl() {
    dataTable = $("#tblAsisCic").DataTable({
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
                            <a href='/Secretario/Asistencia/Curso/?IdCicloEscolar=${data}' class='btn btn-outline-primary mr-1' title="Cursos">
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
    dataTable = $("#tblAsisCurso").DataTable({
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

function cargarDatatableAsisBloque(AsCur, IdCicloEscolar) {
    dataTableBlk = $("#tblBloqueAsis").DataTable({
        "ajax": {
            "url": "/Secretario/Asistencia/GetAll/" + AsCur,
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
                            <a href='/Secretario/Asistencia/TblAsistencia/?IdBlkAsCu=${data}&IdCicloEscolar=${IdCicloEscolar}&IdAsigCurso=${AsCur}' class='btn btn-outline-primary mr-1' title='Cursos'>
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

function ListTblAsis() {
    dataTable = $("#tblBloqueAsis").DataTable({
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

function cargarDtblAsis(IdBlkAsCu, IdCicloEscolar, IdAsigCurso) {
    dataTableAs = $("#tblBloqueAsis").DataTable({
        "ajax": {
            "url": "/Secretario/Asistencia/GetAllAsis/?IdBlkAsCu=" + IdBlkAsCu + "&IdCicloEscolar=" + IdCicloEscolar + "&IdAsigCurso=" + IdAsigCurso,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "20%" },
            {
                "data": "fecha",
                "render": function (data) {
                    return data;
                }, "width": "50%"
            },
            {
                "data": "asigEstudiante.id",
                "render": function (data) {
                    return `<div class="d-flex justify-content-center flex-nowrap">
                            <a href='/Secretario/Asistencia/updateAsis/?IdBlkAsCu=${data}&IdCicloEscolar=${IdCicloEscolar}&IdAsigCurso=${IdAsigCurso}' class='btn btn-outline-primary mr-1' title="Cursos">
                            <i class='fas fa-edit'></i>
                            </a>
                            </div>`;
                }, "width": "30%"
            }
        ],
        "language": {
            "url": "../lib/DataTables/idioma/es-ES.json",
            "emptyTable": "No hay registros"
        },
        "width": "100%"
    });
}


function cargarDatatableLsEstAs(IdBlkAsCu, IdCicloEscolar, IdAsigCurso) {
    dataTable = $('#listEstuAsis').DataTable({
        "ajax": {
            "url": "/Secretario/Asistencia/CreateAsistenciaLstEst/?IdBlkAsCu=" + IdBlkAsCu + "&est=1&IdCicloEscolar=" + IdCicloEscolar + "&IdAsigCurso=" + IdAsigCurso,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "nota.idAsigEstudinate",
                "render": function (data) {
                    return `<td><input class="form-control-plaintext idases" value='${data}' readonly ></td>`;
                },
                "width": "5%"
            },
            { "data": "estudiante.nomEstudiante", "width": "25%" },
            { "data": "estudiante.apellEstudiante", "width": "25%" },
            {
                "data": "nota.id",
                "render": function (data) {
                    return `<td>
                                <div class="form-check form-check-inline">
                                  <input class="form-check-input tipo" type="radio" name="inlineRadioOptions${data}" id="inlineRadio1${data}" checked value="Presente">
                                  <label class="form-check-label" for="inlineRadio1${data}">Presente</label>
                                </div>
                                <div class="form-check form-check-inline">
                                  <input class="form-check-input tipo" type="radio" name="inlineRadioOptions${data}" id="inlineRadio2${data}" value="Ausente">
                                  <label class="form-check-label" for="inlineRadio2${data}">Ausente</label>
                                </div>
                                <div class="form-check form-check-inline">
                                  <input class="form-check-input tipo" type="radio" name="inlineRadioOptions${data}" id="inlineRadio3${data}" value="Justificado">
                                  <label class="form-check-label" for="inlineRadio3${data}">Justificado</label>
                                </div>
                            </td>`;
                },
                "width": "30%"
            },
            {
                "data": "",
                "render": function (data) {
                    return `<td><input class="form-control-plaintext coment border" value=''></td>`;
                },
                "width": "15%"
            }
        ],
        "language": {
            "url": "../lib/DataTables/idioma/es-ES.json",
            "emptyTable": "No hay registros"
        },
        "width": "100%"
    });
}

//function cargarDatatableLsEstAsUpdate(IdBlkAsCu, IdCicloEscolar, Fecha) {
//    dataTable = $('#listEstuAsisUpdate').DataTable({
//        "ajax": {
//            "url": "/Secretario/Asistencia/GetAllAsis/?IdBlkAsCu=" + IdBlkAsCu + "&est=1&IdCicloEscolar=" + IdCicloEscolar + "&Fecha=" + Fecha,
//            "type": "GET",
//            "datatype": "json"
//        },
//        "columns": [
//            {
//                "data": "nota.idAsigEstudinate",
//                "render": function (data) {
//                    return `<td><input class="form-control-plaintext idases" value='${data}' readonly ></td>`;
//                },
//                "width": "5%"
//            },
//            { "data": "estudiante.nomEstudiante", "width": "25%" },
//            { "data": "estudiante.apellEstudiante", "width": "25%" },
//            {
//                "data": "nota.id",
//                "render": function (data) {
//                    return `<td>
//                                <div class="form-check form-check-inline">
//                                  <input class="form-check-input tipo" type="radio" name="inlineRadioOptions${data}" id="inlineRadio1${data}" checked value="Presente">
//                                  <label class="form-check-label" for="inlineRadio1${data}">Presente</label>
//                                </div>
//                                <div class="form-check form-check-inline">
//                                  <input class="form-check-input tipo" type="radio" name="inlineRadioOptions${data}" id="inlineRadio2${data}" value="Ausente">
//                                  <label class="form-check-label" for="inlineRadio2${data}">Ausente</label>
//                                </div>
//                                <div class="form-check form-check-inline">
//                                  <input class="form-check-input tipo" type="radio" name="inlineRadioOptions${data}" id="inlineRadio3${data}" value="Justificado">
//                                  <label class="form-check-label" for="inlineRadio3${data}">Justificado</label>
//                                </div>
//                            </td>`;
//                },
//                "width": "30%"
//            },
//            {
//                "data": "",
//                "render": function (data) {
//                    return `<td><input class="form-control-plaintext coment border" value=''></td>`;
//                },
//                "width": "15%"
//            }
//        ],
//        "language": {
//            "url": "../lib/DataTables/idioma/es-ES.json",
//            "emptyTable": "No hay registros"
//        },
//        "width": "100%"
//    });
//}


function RegistrarAsis(idBlk) {

    var ListaAsEs = [];
    var InputIdases = document.getElementsByClassName('idases'),
        NotaValue = [].map.call(InputIdases, function (dataInput) {
            ListaAsEs.push(dataInput.value);
        });

    var ListaTipo = [];
    var TdTipo = document.getElementsByClassName('tipo'),
        IdValue = [].map.call(TdTipo, function (dataInput) {
            if (dataInput.checked) {
                ListaTipo.push(dataInput.value);
            }
        });

    var ListaComent = [];
    var TdCom = document.getElementsByClassName('coment'),
        IdNtValue = [].map.call(TdCom, function (dataInput) {
            ListaComent.push(dataInput.value);
        });

    var fecha = document.getElementById('dateAsis').value;

    $.ajax({
        url: "/Secretario/Asistencia/SaveAsistencia",
        type: "post",
        data: {
            ListaAsEs1: ListaAsEs,
            ListaTipo1: ListaTipo,
            ListaComent1: ListaComent,
            IdBlkAsCu1: idBlk,
            fecha1: fecha
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
}

function UpdateAsis(idBlk) {

    var ListaIdAsis = [];
    var InputIdasis = document.getElementsByClassName('idasis'),
        IdAsis = [].map.call(InputIdasis, function (dataInput) {
            ListaIdAsis.push(dataInput.value);
        });

    var ListaAsEs = [];
    var InputIdases = document.getElementsByClassName('idases'),
        NotaValue = [].map.call(InputIdases, function (dataInput) {
            ListaAsEs.push(dataInput.value);
        });

    var ListaTipo = [];
    var TdTipo = document.getElementsByClassName('tipo'),
        IdValue = [].map.call(TdTipo, function (dataInput) {
            if (dataInput.checked) {
                ListaTipo.push(dataInput.value);
            }
        });

    var ListaComent = [];
    var TdCom = document.getElementsByClassName('coment'),
        IdNtValue = [].map.call(TdCom, function (dataInput) {
            ListaComent.push(dataInput.value);
        });

    var fecha = document.getElementById('dateAsisUp').value;

    $.ajax({
        url: "/Secretario/Asistencia/UpdateAsistencia",
        type: "post",
        data: {
            ListaIdAsis1: ListaIdAsis,
            ListaAsEs1: ListaAsEs,
            ListaTipo1: ListaTipo,
            ListaComent1: ListaComent,
            IdBlkAsCu1: idBlk,
            fecha1: fecha
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