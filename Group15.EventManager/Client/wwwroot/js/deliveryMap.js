(function () {
    var dir, map = null;

    var latitude, longtitude; 
    // Global export
    window.deliveryMap = {
        showOrUpdate: function (markerId, marker, zoom, popupText) {

            var elem = document.getElementById(markerId);

            //If map exists it will be removed from context and a new one will be created
            if (map != null) {
                map.off();
                map.remove();
            }

            //Map
            map = L.map(elem, {
                layers: MQ.mapLayer(),
                center: [marker.y, marker.x],
                zoom: 10
            });

            L.marker([marker.y, marker.x]).addTo(map);

            navigator.geolocation.getCurrentPosition(function(position) {

            latitude = position.coords.latitude;
            longtitude = position.coords.longitude;

            L.marker([latitude, longtitude]).addTo(map);

            dir = MQ.routing.directions();

            dir.route({
                locations: [
                    { latLng: { lat: marker.y, lng: marker.x } },
                    { latLng: { lat: latitude, lng: longtitude } },
                ]
            });


            map.addLayer(MQ.routing.routeLayer({
                directions: dir,
                fitBounds: true
            }));
            })
        }
    }

})();
