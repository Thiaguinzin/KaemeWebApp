function CreateSubmit() {

    if (!Validate()) {

        toastr.error('Nome do cliente deve ser preenchido');

    }
    else {
        var data = $("#form").serialize();

        $.ajax({
            type: "POST",
            url: "/Cliente/Create",
            data: data,
        }).done(function (res) {
            window.location.href = res.newUrl;
        })
    }

}

function EditSubmit() {

    if (!Validate()) {

        toastr.error('Nome do cliente deve ser preenchido');

    }
    else {
        var data = $("#form").serialize();

        $.ajax({
            type: "POST",
            url: "/Cliente/Edit",
            data: data,
        }).done(function (res) {
            window.location.href = res.newUrl;
        })
    }

}

function Validate() {
    var nome = document.getElementById("Nome").value;

    if (nome == '') {
        return false
    }
    else {
        return true
    }

}

var ConfirmDelete = function (id) {

    $("#idCliente").val(id);
    $("#modalDeletar").modal('show');

}

var DeleteCliente = function () {

    var clienteID = $("#idCliente").val();

    $.ajax({

        type: "POST",
        url: "/Cliente/Delete",
        data: { id: clienteID },
    }).done(function (res) {
        window.location.href = res.newUrl;
    })

}