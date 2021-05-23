var dataTable;

$(document).ready(function () {
    cargarDatatable();
});


function cargarDatatable() {
    /*El #tblCategorias hace referencia al Id de la tabla creada en el Index.html
      El DataTable hace referencia a la libreria de TadaTable */
    dataTable = $("#tblArticulos").DataTable({
        /*Obtiene varios parametros */
        "ajax": {
            /*llamados a parametros*/
            /*La URL hace referencia a la ubicacion a la ruta donde va a extraer las categorias*/
            "url": "/admin/articulos/GetAll",
            /*El tipo de llamado*/
            "type": "GET",
            /*formato de retorno*/
            "datatype": "json"
        },
        /*columnas de la tabla se configura deacuerdo a los DataTables estandarizados en la documentacion*/
        "columns": [
            /*Se pasa los nombre de los campos "ID"*/
            { "data": "id", "width": "5%" },
            /*Se pasa los nombre de los campos "nombre"*/
            { "data": "nombre", "width": "25%" },
            /*Se pasa los nombre de los campos "orden"*/
            { "data": "categoria.nombre", "width": "15%" },
            { "data": "fechaCreacion", "width": "15%" },
            {
                /*Llamar los botones*/
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                            <a href='/Admin/Articulos/Edit/${data}' class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                            <i class='fas fa-edit'></i> Editar
                            </a>
                            &nbsp;
                            <a onclick=Delete("/Admin/Articulos/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                            <i class='fas fa-trash-alt'></i> Borrar
                            </a>
                            `;
                }, "width": "30%"
            }
        ],
        "language": {
            /*Texto si no encuentra registros*/
            "emptyTable": "No hay registros"
        },
        "width": "100%"
    });
}

/*Funcion para Eliminar*/

function Delete(url) {
    swal({
        title: "Esta seguro de borrar?",
        text: "Este contenido no se puede recuperar!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Si, borrar!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }
        });
    });
}
