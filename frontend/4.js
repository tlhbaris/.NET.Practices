function initMap() {
    const pos = { lat: 41.04431098475722, lng: 29.006752026993592 };
  
    const map = new google.maps.Map(document.getElementById("map"), {
      zoom: 17,
      center: pos,
    });
  
    var marker = new google.maps.Marker({
      position: pos,
      map: map,
    });
  
    map.addListener("click", (e) => {
      console.log("Enlem" + e.latLng.lat());
      console.log("Boylam" + e.latLng.lng());
      var newPos = {
        lat: e.latLng.lat(),
        lng: e.latLng.lng(),
      };
  
      marker.setMap(null);
      marker = new google.maps.Marker({
        position: newPos,
        map: map,
      });
    });
  }
  
  window.initMap = initMap;
  