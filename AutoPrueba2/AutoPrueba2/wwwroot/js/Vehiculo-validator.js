
$(function () {
    
    $("#vehiculoform").validate({
        
        rules: {
            Tipo  : {
                required: true,
                minlength: 3
               
            },
            Marca: {
                required: true,
                minlength: 3
               
            },
            Modelo: {
                required: true,
                minlength: 3
               
            },
            Color: {
                required: true,
                minlength: 3
               
            },
            Deposito: {
                required: true,
                minlength: 3
               
            },
            MatriculaCaracterUno: {
                required: true,
                minlength: 3
               
            },
            MatriculaCaracterDos: {
                required: true,
                minlength: 3
               
            },
            MatriculaCaracterTres: {
                required: true,
                minlength: 3
               
            },
            Fecha: {
                required: true,
                minlength: 3
               
            }


        },
        messages: {
            Tipo: {
                required: "Escribi tu... ",
                minlength: "miniimo 3 caracter"
               
            },
            Marca: {

                minlength: "miniimo 3 caracter"
               
            },
            Modelo: {

                minlength: "miniimo 3 caracter"
               
            },
            Color: {

                minlength: "miniimo 3 caracter"
               
            },
            Deposito: {

                minlength: "miniimo 3 caracter"
               
            },
            MatriculaCaracterUno: {

                minlength: "miniimo 3 caracter"
               
            },
            MatriculaCaracterDos: {

                minlength: "miniimo 3 caracter"
               
            },
            MatriculaCaracterTres: {

                minlength: "miniimo 3 caracter"
               
            },
            Fecha: {

                minlength: "miniimo 3 caracter"
               
            }

        },
        submitHandler: function (form) {
            form.submit();
        }
    });

   
});