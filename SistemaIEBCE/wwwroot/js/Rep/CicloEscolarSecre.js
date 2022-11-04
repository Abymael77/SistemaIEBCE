function EstPorGenero(IdCiEs) {
    jQuery.ajax({
        url: '/Secretario/CicloEscolar/EstPorGenero/?IdCiEs=' + IdCiEs,
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

function EstuPorGeneroEstado(IdCiEs) {
    jQuery.ajax({
        url: '/Secretario/CicloEscolar/EstuPorGeneroEstado/?IdCiEs=' + IdCiEs + "&est=1",
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
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(255, 205, 86, 0.2)',
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(255, 159, 64, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                        'rgba(201, 203, 207, 0.2)'
                    ],
                    borderColor: [
                        'rgb(75, 192, 192)',
                        'rgb(255, 205, 86)',
                        'rgb(255, 99, 132)',
                        'rgb(255, 159, 64)',
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
                document.getElementById('chart2'),
                config
            );



        },
        error: function (error) {
            console.log(error);
        }
    });
}


function EstuPorGeneroEstado0(IdCiEs) {
    jQuery.ajax({
        url: '/Secretario/CicloEscolar/EstuPorGeneroEstado/?IdCiEs=' + IdCiEs + "&est=0",
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
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(255, 159, 64, 0.2)',
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(255, 205, 86, 0.2)',
                        'rgba(201, 203, 207, 0.2)'
                    ],
                    borderColor: [
                        'rgb(54, 162, 235)',
                        'rgb(153, 102, 255)',
                        'rgb(255, 99, 132)',
                        'rgb(255, 159, 64)',
                        'rgb(75, 192, 192)',
                        'rgb(255, 205, 86)',
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
                document.getElementById('chart3'),
                config
            );



        },
        error: function (error) {
            console.log(error);
        }
    });
}


function EstuPorEstado(IdCiEs) {
    jQuery.ajax({
        url: '/Secretario/CicloEscolar/EstuPorEstado/?IdCiEs=' + IdCiEs + "&est=0",
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            //console.log(data);
            //console.log(data.data.length);
            //console.log(data.data[1]['strCantY']);

            if (data.data.length == 2) {
                var arrGrdo = ["Retidados", "Activos"];
            } else if (data.data.length == 1) {
                var arrGrdo = ["Activos"];
            }

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
                        'rgba(75, 192, 192, 0.5)',
                        'rgba(255, 205, 86, 0.3)',
                        'rgba(54, 162, 235, 0.8)',
                        'rgba(153, 102, 255, 0.8)',
                        'rgba(255, 159, 64, 0.8)',
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(201, 203, 207, 0.2)',
                    ],
                    borderColor: [
                        'rgb(75, 192, 192)',
                        'rgb(255, 205, 86)',
                        'rgb(54, 162, 235)',
                        'rgb(153, 102, 255)',
                        'rgb(255, 159, 64)',
                        'rgb(255, 99, 132)',
                        'rgb(201, 203, 207)',
                    ],
                    borderWidth: 2,
                    data: arrayCantidad,
                    pointStyle: 'circle',
                    pointRadius: 10,
                    pointHoverRadius: 15
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
                document.getElementById('chart4'),
                config
            );



        },
        error: function (error) {
            console.log(error);
        }
    });
}
