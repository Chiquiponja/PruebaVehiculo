
$().ready((function () {
    
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
                required: "Escribi tu Nombre... ",
                minlength: "Minimo 3 caracter"
               
            },
            Marca: {
                required: "Escribi la Marca... ",
                minlength: "Minimo 3 caracter"
               
            },
            Modelo: {
                required: "Escribi el Modelo... ",
                minlength: "Minimo 3 caracter"
               
            },
            Color: {
                required: "Escribi el Color... ",
                minlength: "Minimo 3 caracter"
               
            },
            Deposito: {
                required: "Escribi tu Deposito... ",
                minlength: "Minimo 3 caracter"
               
            },
            MatriculaCaracterUno: {
                required: "Escribi la Matricula... ",
                minlength: "Minimo 3 caracter",
              
            },
            MatriculaCaracterDos: {
                required: "Escribi la Matricula... ",
                minlength: "Minimo 3 caracter"
               
            },
            MatriculaCaracterTres: {
                required: "Escribi la Matricula... ",
                minlength: "Minimo 3 caracter"
               
            },
            Fecha: {
                required: "Escribi la Fecha... ",
                minlength: "Minimo 3 caracter"
               
            }

        },
        submitHandler: function (form) {
            form.submit();
        }
    });

   
}));