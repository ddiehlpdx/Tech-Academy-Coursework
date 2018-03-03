var lastPage = false;
var leftButton  = document.getElementById('btn-left');
var rightButton = document.getElementById('btn-right');
var total = document.getElementById('total');
var currentForm = "#frm1";
var nextPage = 2;
var runningTotal = 0;
var itemized = [];

document.getElementById('total').innerHTML = "$" + runningTotal + ".00";

function begin() {
	var pgTurn = document.getElementById(nextPage);
	pgTurn.scrollIntoView({behavior: "smooth"});
	nextPage++;
	leftButton.style.display = "inline-block";
	rightButton.style.display = "inline-block";
	total.style.display = "inline-block";
}

function scrRight() {
	calculateTotal(currentForm);
	if(lastPage == true) {
		totalOut(itemized);
	}
	var pgTurn = document.getElementById(nextPage);
	if(nextPage < 5) {
		pgTurn.scrollIntoView({behavior: "smooth"});
		nextPage++;
	}
	if(nextPage == 5) {
		document.getElementById('btn-right').innerHTML = '<i class="fas fa-shopping-cart display-4"></i>';
		lastPage = true;
	}
	document.getElementById('total').innerHTML = "$" + runningTotal + ".00";
	currentForm = '#frm' + (nextPage - 2);
}
			
function scrLeft() {
	negate(currentForm);
	lastPage = false;
	var pgTurn = document.getElementById(nextPage - 2);
	if(nextPage == 5) {
		document.getElementById('btn-right').innerHTML = '<i class="fas fa-chevron-circle-right display-4"></i>';
	}
	if(nextPage > 2) {
		pgTurn.scrollIntoView({behavior: "smooth"});
		nextPage--;
		currentForm = '#frm' + (nextPage - 2);
		if(nextPage <= 2) {
			leftButton.style.display = "none";
			rightButton.style.display = "none";
			total.style.display = "none";
			currentForm = "#frm1";
		}
	}
	document.getElementById('total').innerHTML = "$" + runningTotal + ".00";
}


function calculateTotal() {
	$(currentForm+" input[type=radio]:checked, input[type=checkbox]:checked").each(function() {
		itemized.push([$(this).attr('id'), $(this).val()]);
		runningTotal += parseInt($(this).val());
		console.log(itemized);
	});
}

function negate() {
	var prevForm = '#frm' + (nextPage - 3);
	$(prevForm+" input[type=radio]:checked, input[type=checkbox]:checked").each(function() {
		runningTotal -= parseInt($(this).val());
	});
	itemized.pop();
	itemized.pop();
	console.table(itemized);
}

function totalOut(arr) {
	arr.push(['<strong>Total Price</strong>', '<strong>' + runningTotal + '</strong>']);
	var result = "<table border='1|1'>";
	for(i = 0; i < arr.length; i++) {
		result += "<tr>";
		result += "<td>" + arr[i][0] + "</td>";
		result += "<td>$" + arr[i][1] + "</td>";
		result += "</tr>";
	}
	result += "</table>";
	document.getElementById('modal-body').innerHTML = result;
	$('#modal').modal('show');
}