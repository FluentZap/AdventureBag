$(function () {
	$('#buy').click(function () {
		$.post("/adventurebuy",
		{
			name: "Donald Duck",
			city: "Duckburg"
		}, function () {
			$("#shopList").load("/adventuregetlist");
		});
	});
	//$("#shopList").
});