function EstPorGrado(anio) {
    jQuery.ajax({
        url: '/Director/CicloEcolar/EstPorGrado/?anio=' + anio,
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            //console.log(data);
            //console.log(data.data.length);
            //console.log(data.data[1]['strCantY']);

            var arrGrdo = [];
            var arrayCantidad = [];

            for (var i = 0; i < data.data.length; i++) {

                /*console.log(data[i].mes)*/
                arrGrdo.push(data.data[i].strCantY)
                arrayCantidad.push(data.data[i].cantX)
            }

            console.log(arrGrdo)
            console.log(arrayCantidad)


            const dat = {
                labels: arrGrdo,
                datasets: [{
                    label: 'Estudiantes',
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(255, 159, 64, 0.2)',
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(255, 205, 86, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                        'rgba(201, 203, 207, 0.2)'
                    ],
                    borderColor: [
                        'rgb(255, 99, 132)',
                        'rgb(255, 159, 64)',
                        'rgb(75, 192, 192)',
                        'rgb(255, 205, 86)',
                        'rgb(54, 162, 235)',
                        'rgb(153, 102, 255)',
                        'rgb(201, 203, 207)'
                    ],
                    borderWidth: 2,
                    data: arrayCantidad,
                    pointStyle: 'circle',
                    pointRadius: 10,
                    pointHoverRadius: 15
                }]
            };

            const config = {
                type: 'bar',
                data: dat,
                options: {
                    responsive: true,
                }
            };

            const myChart = new Chart(
                document.getElementById('chart1'),
                config
            );



        },
        error: function (error) {
            console.log(error);
        }
    });
}


function GradoSeccion(anio) {
    jQuery.ajax({
        url: '/Director/CicloEcolar/EstuPorGradoSecc/?anio=' + anio,
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            //console.log(data);
            //console.log(data.data.length);
            //console.log(data.data[1]['strCantY']);

            var arrGrdo = [];
            var arrayCantidad = [];

            for (var i = 0; i < data.data.length; i++) {

                /*console.log(data[i].mes)*/
                arrGrdo.push(data.data[i].strCantY)
                arrayCantidad.push(data.data[i].cantX)
            }

            console.log(arrGrdo)
            console.log(arrayCantidad)





            const dat = {
                labels: arrGrdo,
                datasets: [{
                    label: 'Estudiantes',
                    backgroundColor: '#ffcd56',
                    borderColor: '#ffcd56',
                    data: arrayCantidad,
                    pointStyle: 'circle',
                    pointRadius: 10,
                    pointHoverRadius: 15
                }]
            };

            const config = {
                type: 'line',
                data: dat,
                options: {
                    responsive: true,
                }
            };

            const myChart = new Chart(
                document.getElementById('chart2'),
                config
            );



        },
        error: function (error) {
            console.log(error);
        }
    });
}

function EstuPorEstado(anio) {
    jQuery.ajax({
        url: '/Director/CicloEcolar/EstuPorEstado/?anio=' + anio,
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            //console.log(data);
            //console.log(data.data.length);
            //console.log(data.data[1]['strCantY']);

            var arrGrdo = ['Inactivo', 'Activo'];
            var arrayCantidad = [];

            for (var i = 0; i < data.data.length; i++) {

                /*console.log(data[i].mes)*/
                //arrGrdo.push(data.data[i].strCantY)
                arrayCantidad.push(data.data[i].cantX)
            }

            console.log(arrGrdo)
            console.log(arrayCantidad)





            const dat = {
                labels: arrGrdo,
                datasets: [{
                    label: 'Estudiantes',
                    backgroundColor: [
                        '#5C6373',
                        '#1B2740',
                    ],
                    borderColor: 'rgb(255, 255, 255)',
                    data: arrayCantidad,
                }]
            };

            const config = {
                type: 'doughnut',
                data: dat,
                options: {
                    responsive: true,
                }
            };

            const myChart = new Chart(
                document.getElementById('chart3'),
                config
            );



        },
        error: function (error) {
            console.log(error);
        }
    });
}

function CursosPorGrado(anio) {
    jQuery.ajax({
        url: '/Director/CicloEcolar/CursosPorGrado/?anio=' + anio,
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            //console.log(data);
            //console.log(data.data.length);
            //console.log(data.data[1]['strCantY']);

            var arrGrdo = [];
            var arrayCantidad = [];

            for (var i = 0; i < data.data.length; i++) {

                /*console.log(data[i].mes)*/
                arrGrdo.push(data.data[i].strCantY)
                arrayCantidad.push(data.data[i].cantX)
            }

            console.log(arrGrdo)
            console.log(arrayCantidad)


            const dat = {
                labels: arrGrdo,
                datasets: [{
                    label: 'Cursos',
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(255, 159, 64, 0.2)',
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(255, 205, 86, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                        'rgba(201, 203, 207, 0.2)'
                    ],
                    borderColor: [
                        'rgb(255, 99, 132)',
                        'rgb(255, 159, 64)',
                        'rgb(75, 192, 192)',
                        'rgb(255, 205, 86)',
                        'rgb(54, 162, 235)',
                        'rgb(153, 102, 255)',
                        'rgb(201, 203, 207)'
                    ],
                    borderWidth: 2,
                    data: arrayCantidad,
                    pointStyle: 'circle',
                    pointRadius: 10,
                    pointHoverRadius: 15
                }]
            };

            const config = {
                type: 'bar',
                data: dat,
                options: {
                    responsive: true,
                }
            };

            const myChart = new Chart(
                document.getElementById('chart4'),
                config
            );



        },
        error: function (error) {
            console.log(error);
        }
    });
}
