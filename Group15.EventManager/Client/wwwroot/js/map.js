(function () {

    var dir, map = null;
    var userLongtitude, userLatitude;

window.map = {
    showOrUpdate: function (markerId, marker, address, zoom, payOnline) {

            //If map exists it will be removed from context and a new one will be created
            if (map != null) {
                map.off();
                map.remove();
            }

            navigator.geolocation.getCurrentPosition(function (position) { //Navigation for current location of browser

                userLongtitude = position.coords.longitude;
                userLatitude = position.coords.latitude;

                map = L.map(markerId, {
                    layers: MQ.mapLayer(),
                    center: [userLongtitude, userLatitude],
                    zoom: zoom
                });

                dir = MQ.routing.directions();

                if (payOnline == true) {
                    dir.route({ //Directions for event and if the user and markers exists
                        locations: [
                            { latLng: { lat: userLatitude, lng: userLongtitude } },
                            { latLng: { lat: marker.y, lng: marker.x } },
                        ]
                    });
                }
                else {
                    dir.route({ //Directions for event and the user if address exists
                        locations: [
                            { latLng: { lat: userLatitude, lng: userLongtitude } },
                            address 
                        ]
                    });
                }

                map.addLayer(MQ.routing.routeLayer({
                    directions: dir,
                    fitBounds: true,
                }));
            })
        }
    }
})();
