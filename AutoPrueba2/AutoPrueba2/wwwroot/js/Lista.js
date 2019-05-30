var vm;
function initVue() {
    vm = new Vue({
        el: '#app',
        data: {
            vehiculo: [],

        },
        methods: {
            obtenerVehiculo: function () {
                $.ajax({
                    //Cambiar a type: POST si necesario
                    type: "GET",
                    // Formato de datos que se espera en la respuesta
                    dataType: "json",
                    // URL a la que se enviará la solicitud Ajax
                    url: "/Vehiculos/Listar",
                })
                    .done(function (data) {
                        vm.$data.vehiculo = data;
                    })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        if (jqXHR.status === 0) {

                            alert('ERROR EN EL SERVIDOR');

                        } else if (jqXHR.status == 404) {

                            alert('ERROR EN EL SERVIDOR');

                        } else if (jqXHR.status == 500) {

                            alert('ERROR EN EL SERVIDOR');

                        } else if (textStatus === 'parsererror') {

                            alert('ERROR EN EL SERVIDOR');

                        } else if (textStatus === 'timeout') {

                            alert('ERROR EN EL SERVIDOR');

                        } else if (textStatus === 'abort') {

                            alert('ERROR EN EL SERVIDOR');

                        } else {

                            alert('ERROR EN EL SERVIDOR' + jqXHR.responseText);
                        }
                    });
            },
            obtenerEdit: function () {
                $.ajax({
                    //Cambiar a type: POST si necesario
                    type: "GET",
                    // Formato de datos que se espera en la respuesta
                    dataType: "json",
                    // URL a la que se enviará la solicitud Ajax
                    url: "/Vehiculos/Edit",
                })
                    .done(function (data) {
                        vm.$data.vehiculo = data;
                    })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        if (console && console.log) {
                            console.log("La solicitud ha fallado: " + textStatus);
                        }
                    });
            },
            obtenerDetele: function () {
                $.ajax({
                    //Cambiar a type: POST si necesario
                    type: "GET",
                    // Formato de datos que se espera en la respuesta
                    dataType: "json",
                    // URL a la que se enviará la solicitud Ajax
                    url: "/Vehiculos/Detele",
                })
                    .done(function (data) {
                        vm.$data.vehiculo = data;
                    })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        if (console && console.log) {
                            console.log("La solicitud ha fallado: " + textStatus);
                        }
                    });
            },
        }
    })
};


