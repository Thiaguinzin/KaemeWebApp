function CreateSubmit() {

    // Retira a mascára
    let minPedidoAtacadoUnmask = $('#minPedidoAtacado').val().replace('R$', '').trim()
    $('#minPedidoAtacado').val(minPedidoAtacadoUnmask)

    if (Validate()) {
        var data = $("#form").serialize();

        $.ajax({
            type: "POST",
            url: "/Fornecedor/Create",
            data: data,
        }).done(function (res) {
            window.location.href = res.newUrl;
        })

    }
}

function Validate() {

    var razaoSocial = document.getElementById("RazaoSocial").value;
    var frete = document.getElementById("dropdown").value;

    if (razaoSocial == '') {
        toastr.error('Razão Social do fornecedor deve ser preenchido');
    }

    if (frete == '') {
        toastr.error('Frete Status do fornecedor deve ser preenchido');
    }

    if (razaoSocial == '' || frete == '') {
        return false;
    }
    else {
        return true;
    }

}

var helpers =
{
    buildDropdown: function (result, dropdown, emptyMessage) {
        // Remove current options
        dropdown.html('');

        // Add the empty option with the empty message
        dropdown.append('<option value="" selected disabled hidden>' + emptyMessage + '</option>');

        // Check result isnt empty
        if (result != '') {
            // Loop through each of the results and append the option to the dropdown
            $.each(result, function (k, v) {
                dropdown.append('<option value="' + v.id + '">' + v.descricao + '</option>');
            });
        }
    }
}

const $money = document.querySelector('[data-js="money"]');

$money.value = "R$ 0,00";

$money.addEventListener(
    "input",
    (e) => {
        e.target.value = maskMoney(e.target.value);
    },
    false
);

function maskMoney(value) {
    const valueAsNumber = value.replace(/\D+/g, "");
    return new Intl.NumberFormat("pt-BR", {
        style: "currency",
        currency: "BRL"
    }).format(valueAsNumber / 100);
}

// Desabilita escrita em input type number
$("[type='number']").keypress(function (evt) {
    evt.preventDefault();
});