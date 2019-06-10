var vm;
document.addEventListener('DOMContentLoaded', function () {
    vm = new Vue({
        el: '#appAutos',
        data: {

            auto: {
                Id: 0,
                Tipo: '',
                Marca: '',
                Modelo: '',
                Color: '',
                Deposito: '',
                MatriculaCaracterUno: '',
                MatriculaCaracterDos: '',
                MatriculaCaracterTres: '',
                Fecha: '',
            },

            Autos: []
        },
        methods: {
            crearAuto: function () {

                //var data = JSON.stringify(vm.$data.auto);

                $.ajax({
                    url: "/Vehiculos/Add",
                    contentType: "application/json",
                    async: true,
                    type: "POST",
                    data: data,
                    error: function (jqXHR, textStatus, errorThrown) {
                        console.log("FAIL: " + errorThrown);
                    },
                    success: function (data, textStatus, jqXHR) {
                        console.log("SUCCESS!");
                    }
                });
            },

            obtenerAutoById: function (id) {
                $.ajax({
                    //Cambiar a type: POST si necesario
                    type: "GET",
                    // Formato de datos que se espera en la respuesta
                    dataType: "json",
                    // URL a la que se enviará la solicitud Ajax
                    url: "/Vehiculos/GetAutoId/" + id,
                })
                    .done(function (data) {
                        vm.$data.auto = data;
                    })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        if (console && console.log) {
                            console.log("La solicitud ha fallado: " + textStatus);
                        }
                    });
            },
        }
    }
    )
});