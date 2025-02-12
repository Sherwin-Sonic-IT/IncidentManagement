let myBarChart = null;

function renderBarChart(incidentBarChart, labels, data, chartTitle, incidentNames) {
    var ctx = document.getElementById(incidentBarChart).getContext('2d');

    if (myBarChart !== null) {
        myBarChart.destroy();
    }

    myBarChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: chartTitle,
                data: data,
                backgroundColor: '#003366',
                hoverBackgroundColor: '#126180',
                borderColor: '#87ceeb',
                borderWidth: 2
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
                            return incidentNames[index];
                        }
                    }
                }
            }
        }
    });
}
