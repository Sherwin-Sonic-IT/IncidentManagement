let myLineChart = null;
function renderLineChart(incidentLineChart, labels, data, chartTitle, tooltipData) {
    var ctx = document.getElementById(incidentLineChart).getContext('2d');

    if (myLineChart !== null) {
        myLineChart.destroy();
    }

     myLineChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: chartTitle,
                data: data,
                backgroundColor: '#f5f5f5',
                borderColor: '#003366',  
                borderWidth: 1,
                fill: true,
            }]
        },
        options: {
            scales: {
                x: {
                    beginAtZero: true
                }
            },
            plugins: {
                tooltip: {
                    callbacks: {
                        label: function (tooltipItem) {
                            var index = tooltipItem.dataIndex;
                            return tooltipData[index];
                        }
                    }
                }
            }
        }
    });
}
