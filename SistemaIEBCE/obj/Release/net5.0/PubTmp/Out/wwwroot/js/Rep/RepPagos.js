function CuentaEstudiante(idAsEs) {
    jQuery.ajax({
        url: '/Tesorero/Cuota/CuentaEstudiante/?idAsEs=' + idAsEs,
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            //console.log(data);
            //console.log(data.data.length);
            //console.log(data.data[1]['strCantY']);

            var arrGrdo = [];
            var arrayPagado = [];
            var arrayCantidad = [];

            for (var i = 0; i < data.data.length; i++) {

                /*console.log(data[i].mes)*/
                arrGrdo.push(data.data[i].strCantY)
                arrayPagado.push(data.data[i].cantX)
                arrayCantidad.push(data.data[i].cantY)
            }

            console.log(arrGrdo)
            console.log(arrayCantidad)


            const dat = {
                labels: arrGrdo,
                datasets: [
                    {
                        label: 'Pagado',
                        backgroundColor: [
                            'rgba(75, 192, 192, 1)'
                        ],
                        borderColor: [
                            'rgb(75, 192, 192)'
                        ],
                        borderWidth: 2,
                        data: arrayPagado,
                        pointStyle: 'circle',
                        pointRadius: 5,
                        pointHoverRadius: 15,
                        fill: true,
                        stack: 'combined'
                    },
                    {
                        label: 'Total de Cuotas',
                        backgroundColor: [
                            'rgba(255, 159, 64, 0.2)',
                        ],
                        borderColor: [
                            'rgb(255, 159, 64)',
                        ],
                        borderWidth: 2,
                        data: arrayCantidad,
                        pointStyle: 'circle',
                        pointRadius: 5,
                        pointHoverRadius: 15,
                        fill: true,
                        stack: 'combined'
                    }
                ]
            };

            const config = {
                type: 'line',
                data: dat,
                options: {
                    responsive: true,
                    plugins: {
                        filler: {
                            propagate: false,
                        }
                    },
                    pointBackgroundColor: '#fff',
                    radius: 10,
                    interaction: {
                        intersect: false,
                    },
                    elements: {
                        line: {
                            tension: 0.4  // smooth lines
                        },
                    },
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

function ListCuotas() {
    jQuery.ajax({
        url: '/Tesorero/Cuota/ListCuotas',
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {

            //console.log(data);
            //console.log(data.data.length);
            //console.log(data.data[1]['strCantY']);

            var arrCuota = [];
            var arrayCantidad = [];

            for (var i = 0; i < data.data.length; i++) {

                /*console.log(data[i].mes)*/
                arrCuota.push(data.data[i].nomCuota)
                arrayCantidad.push(data.data[i].cantidad)
            }



            const dat = {
                labels: arrCuota,
                datasets: [{
                    label: 'Cuotas',
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
                document.getElementById('chart2'),
                config
            );



        },
        error: function (error) {
            console.log(error);
        }
    });
}