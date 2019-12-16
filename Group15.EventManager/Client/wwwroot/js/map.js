(function () {
    var dir, map = null;

    var latitude, longtitude;
    // Global export
    window.map = {
        showOrUpdate: function (markerId, marker, zoom, popupText) {

            //If map exists it will be removed from context and a new one will be created
            if (map != null) {
                map.off();
                map.remove();
            }

            map = L.map(markerId, {
                layers: MQ.mapLayer(),
                center: [marker.y, marker.x],
                zoom: zoom
            });

            navigator.geolocation.getCurrentPosition(function (position) { //Navigation for current location of browser

                latitude = position.coords.latitude;
                longtitude = position.coords.longitude;

                dir = MQ.routing.directions();

                dir.route({ //Directions for event/store and the user
                    locations: [
                        { latLng: { lat: marker.y, lng: marker.x } },
                        { latLng: { lat: latitude, lng: longtitude } },
                    ]
                });

                map.addLayer(MQ.routing.routeLayer({
                    directions: dir,
                    fitBounds: true,
                }));
            })
        }
    }
})();
