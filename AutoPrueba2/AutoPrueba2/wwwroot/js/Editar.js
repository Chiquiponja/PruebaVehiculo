﻿var vm;
function initVue() {
    vm = new Vue({
        el: '#appp',
        data: {
            vehiculo: [],

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