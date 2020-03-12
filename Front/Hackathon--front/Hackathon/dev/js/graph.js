let monBoutonFiltre         = document.querySelector('.header__filtre button');
    let maDivFiltre             = document.querySelector('.div--filtre');

    monBoutonFiltre.addEventListener('click', function() {
        maDivFiltre.classList.toggle('active');
    })


///////////////////////////////////////////////////////////////////////

window.onload = function () {

var chart = new CanvasJS.Chart("chartContainer", {
	animationEnabled: true,
	theme: "light2",
	title:{
		text: "Chiffre d'affaires mensuel cumulé (milliers d'€)"
	},
	axisX:{
		valueFormatString: "MMM",
		crosshair: {
			enabled: true,
			snapToDataPoint: true
		}
	},
	axisY: {
		title: "",
		crosshair: {
			enabled: true
		}
	},
	toolTip:{
		shared:true
	},  
	legend:{
		cursor:"pointer",
		verticalAlign: "bottom",
		horizontalAlign: "left",
		dockInsidePlotArea: true,
		itemclick: toogleDataSeries
	},
	data: [{
		type: "line",
		showInLegend: true,
		name: "CA 2019 Cumulé",
		markerType: "square",
        lineDashType: "dash",
		xValueFormatString: "MMMM YY",
		color: "#0059b3",
		dataPoints: [
            { x: new Date(2018, 0, 0), y: 46.4 },
			{ x: new Date(2018, 1, 0), y:  82.2 },
			{ x: new Date(2018, 2, 0), y: 126.7 },
			{ x: new Date(2018, 3, 0), y: 171.0 },
			{ x: new Date(2018, 4, 0), y: 215.0 },
			{ x: new Date(2018, 5, 0), y: 238.6},
			{ x: new Date(2018, 6, 0), y: 241.6 },
			{ x: new Date(2018, 7, 0), y: 253.6 },
			{ x: new Date(2018, 8, 0), y: 260.2 },
			{ x: new Date(2018, 9, 0), y: 295.0 },
			{ x: new Date(2018, 10, 0), y: 332.5 },
			{ x: new Date(2018, 11, 0), y: 371.6 }
		]
	},
	{
		type: "line",
		showInLegend: true,
		name: "CA 2018 Cumulé",
        color: "#cc0000",
		dataPoints: [
			{ x: new Date(2018, 0, 0), y: 31.9 },
			{ x: new Date(2018, 1, 0), y: 49.3 },
			{ x: new Date(2018, 2, 0), y: 73.5 },
			{ x: new Date(2018, 3, 0), y: 95.1 },
			{ x: new Date(2018, 4, 0), y: 110.7 },
			{ x: new Date(2018, 5, 0), y: 120.6},
			{ x: new Date(2018, 6, 0), y: 139.3 },
			{ x: new Date(2018, 7, 0), y: 154.3 },
			{ x: new Date(2018, 8, 0), y: 171.1 },
			{ x: new Date(2018, 9, 0), y: 194.0 },
			{ x: new Date(2018, 10, 0), y: 232.4 },
			{ x: new Date(2018, 11, 0), y: 235.6 }

		]
	}
	]
});
chart.render();

function toogleDataSeries(e){
	if (typeof(e.dataSeries.visible) === "undefined" || e.dataSeries.visible) {
		e.dataSeries.visible = false;
	} else{
		e.dataSeries.visible = true;
	}
	chart.render();
}

}