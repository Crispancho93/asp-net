/**
 * mensaje de confirmación después de insertar, actualización, eliminar  
 */

function confirmacion(mensaje, redireccion) {

    bootbox.alert({
        message: mensaje,

        // se ejecuta despues que se acepta
        callback: function () {
            window.location.href = redireccion;
        }
    });
}

/**
 * confirmación para eliminar
 */
function confirm_eliminar(id) {

    // codifica en 8859-1
    let mensaje = decodeURIComponent(escape("Esta acción no se puede revertir."));
    bootbox.confirm({
        title: "Desea eliminar?",
        message: mensaje,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },

        // se ejecuta despúes aceptar el confirm
        callback: function (result) {
            if (result) {
                document.getElementById(id).click();
            }
        }
    });


}

/**
 * 
 * ocultar botones
 */
function ocultar(id) {
    document.getElementById(id).style.display = 'none'; 
}


