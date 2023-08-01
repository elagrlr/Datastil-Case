var svgTurkeyMap = document.getElementById("svg-turkey-map").getElementsByTagName("path");
var cityName = document.getElementById("city-name");

for (i = 0; i < svgTurkeyMap.length; i++) {

  svgTurkeyMap[i].addEventListener("mousemove", function() {
    cityName.classList.add("show-city-name--active");
    cityName.style.left = (event.clientX + 20 + "px");
    cityName.style.top = (event.clientY + 20 + "px")
    cityName.innerHTML = this.getAttribute("title");
  });

  svgTurkeyMap[i].addEventListener("mouseleave", function() {
    cityName.classList.remove("show-city-name--active");
  });

  svgTurkeyMap[i].addEventListener("click", function() {
      var cityId = this.getAttribute("data-city-name");

      $.get(`/GetCityDetail/${cityId}`, function (data) {
          console.log(data);
          $("#city-modal-body").html(data.name);  
          
          $('#city-modal').modal('show');
      });
  });

    $(document).on("click", "#activateNode", function () {
        var myNodeId = $(this).data('node');
        $('#nodeId').text(myNodeId);
        var _modalData =Json.Serialize(item);
    });
     
}