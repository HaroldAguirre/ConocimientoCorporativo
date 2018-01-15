$('#btnNuevo').click(function (even) {
    $('#modal-content').load('/Products/Create');
});

$('#btnEditar').click(function (even) {
    $('#modal-content').load('/Products/Edit/' + $(this).data("id"));
});