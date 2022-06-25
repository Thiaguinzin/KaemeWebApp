
function CreateSubmit() {

    if (!Validate()) {

        $(function () {
            var Toast = Swal.mixin({
                toast: true,
                position: 'top-end',
                showConfirmButton: false,
                timer: 3000
            });

            Toast.fire({
                icon: 'error',
                title: 'Nome do cliente deve ser preenchido!'
            });

        });

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

        $(function () {
            var Toast = Swal.mixin({
                toast: true,
                position: 'top-end',
                showConfirmButton: false,
                timer: 3000
            });

            Toast.fire({
                icon: 'error',
                title: 'Nome do cliente deve ser preenchido!'
            });

        });

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

function ObterSigno(date) {

    var signo = "";
    var arr = date.split("-");
    var mes = arr[1];
    var dia = arr[2];

    if (mes == 12 && dia >= 22 || mes == 01 && dia <= 20) {
        var signo = "Capricórnio";
    }
    else if (mes == 01 && dia >= 21 || mes == 02 && dia <= 18) {
        var signo = "Aquário";
    }
    else if (mes == 02 && dia >= 19 || mes == 03 && dia <= 20) {
        var signo = "Peixes";
    }
    else if (mes == 03 && dia >= 21 || mes == 04 && dia <= 20) {
        var signo = "Áries";
    }
    else if (mes == 04 && dia >= 21 || mes == 05 && dia <= 20) {
        var signo = "Touro";
    }
    else if (mes == 05 && dia >= 21 || mes == 06 && dia <= 20) {
        var signo = "Gêmeos";
    }
    else if (mes == 06 && dia >= 21 || mes == 07 && dia <= 22) {
        var signo = "Câncer";
    }
    else if (mes == 07 && dia >= 23 || mes == 08 && dia <= 22) {
        var signo = "Leão";
    }
    else if (mes == 08 && dia >= 23 || mes == 09 && dia <= 22) {
        var signo = "Virgem";
    }
    else if (mes == 09 && dia >= 23 || mes == 10 && dia <= 22) {
        var signo = "Libra";
    }
    else if (mes == 10 && dia >= 23 || mes == 11 && dia <= 21) {
        var signo = "Escorpião";
    }
    else if (mes == 11 && dia >= 22 || mes == 12 && dia <= 21) {
        var signo = "Sagitário";
    }

    document.getElementById("Signo").value = signo;
}