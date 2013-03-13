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
			

			if (value == "connect") {
				var connection = new WebSocket("ws://127.0.0.1:8000");

				connection.onopen = function() {
					log("Connection opened");
				};

				connection.onmessage = function (event) {
					var message = event.data;
					log("> " + message)
				};

				connection.onclose = function (event) {
					log("Socket closed");
				};

			}
		}
	});

	function log(text) {
		$("#output").append(text + "<br>");
		$("#output").scrollTop(999999);
	}

});