
/*var imported = document.createElement('script');
imported.src = '../assets/js/teechart/lib/teechart.js';
document.head.appendChild(imported);*/

var imported1 = document.createElement('script');
imported1.src = '../assets/js/teechart/lib/teechart-maps.js';
document.head.appendChild(imported1);

var imported1a = document.createElement('script');
imported1a.src = '../assets/js/teechart/lib/teechart-table.js';
document.head.appendChild(imported1a);

var imported2 = document.createElement('script');
imported2.src = '../assets/js/teechart/barchart.js';
document.head.appendChild(imported2);

var imported3 = document.createElement('script');
imported3.src = '../assets/js/teechart/areachart.js';
document.head.appendChild(imported3);

var imported4 = document.createElement('script');
imported4.src = '../assets/js/teechart/donutchart.js';
document.head.appendChild(imported4);

var imported5 = document.createElement('script');
imported5.src = '../assets/js/teechart/mapchart.js';
document.head.appendChild(imported5);

var imported6 = document.createElement('script');
imported6.src = 'https://cdnjs.cloudflare.com/ajax/libs/jsgrid/1.5.3/jsgrid.min.js';
document.head.appendChild(imported6);
	
var imported8 = document.createElement('script');
imported8.src = '../assets/js/jsgrid/basicgrid.js';
document.head.appendChild(imported8);

var imported9 = document.createElement('script');
imported9.src = '../data/Variables.js';
document.head.appendChild(imported9);

var startHeight;

function applyPalette(chart){
  chart.palette.colors=["#D6E1FA","#7797D1","#4466a3","#3b548c","#3B548C","#2B406B","#1C2A47","#121C2F","#0C121F"];
		  
  if (chart.series.items.length > 0) {
	for (var i = 0; i < chart.series.items.length; i++)
	{
		chart.series.items[i].format.fill=chart.palette.get(i);
		if ((chart.series.items[i].pointer != null) && (chart.series.items[i].pointer.format != null))
		{
		  chart.series.items[i].pointer.format.fill=chart.palette.get(i);
		}
	}
  }
}

function addVars()
{
   $("#totalsales")[0].innerHTML = aTotalsales;
   $("#totalitemssold")[0].innerHTML = aTotalitemssold;
   $("#totalsalesin")[0].innerHTML = aTotalsalesin;
   $("#totalsalesinbetween")[0].innerHTML = aTotalsalesinbetween;
   $("#salesCtry1")[0].innerText = $("#salesCtry2")[0].innerText = aCountry;
   $("#totalsalesyearspan")[0].innerHTML = "<small>Between "+aStartyear+" and "+aEndyear+"</small>";
   
   $("#totalsalescountry")[0].innerText = "Total Sales In "+aCountry; 
}

function drawElements() {

  //addVars();

  drawDonut();
  drawBar();
  drawArea();
  drawGrid(20);
  drawMap();  
  addVars();
}
