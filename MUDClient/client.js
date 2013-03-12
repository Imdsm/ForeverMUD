$(function() {

	// focus on the textbox, without selecting all the text
	$("#input").focus().val($("#input").val());	
	
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