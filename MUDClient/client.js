$(function() {

	// focus and refocus
	$("#input").focus();
	$("#input").blur(function() {
		setTimeout(function() { $("#input").focus(); }, 0);
	});

	// handle input 
	$("#input").keypress(function(event) {
		if (event.which == 13) {
			event.preventDefault();
			var value = $("#input").val();
			$("#input").val("");
			
			$("#output").append(value + "<br>");
			$("#output").scrollTop(999999);
		}
	});

});