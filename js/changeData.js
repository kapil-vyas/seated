function loop(){
	//chair color and status
	if (isActive == 0){
		$("#changeImage").attr("src", "images/logoGray.png");
		$("#changeStatus").html("Nothing Detected");
		$("#changeStatus").css("background-color", "#7c7c7c");
		window.timeElapsed = 0;
		window.time = Date.now();
		
	}
	
	if (isActive == 1){
		$("#changeImage").attr("src", "images/logo.png");
		$("#changeStatus").html("Sitting Detected");
		$("#changeStatus").css("background-color", "green");
		if (window.timeElapsed = 0){
			window.time = Date.now();
		}
	}

	//angle
	$("#changeAngle").html(angle);
	httpGet();
	window.timeElapsed = Date.now() - window.time;
	$("#changeTimer").html(Math.trunc(window.timeElapsed/1000) + "s");
}
window.isActive = "";
window.time = Date.now();
window.timeElapsed = 0;
setInterval(loop, 500);
