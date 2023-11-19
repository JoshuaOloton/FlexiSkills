var printPage = () => {
    var elem = $("#student-info");
    var table = $("#course-table");

    elem.addClass("text-center");
    elem.append(table);
    elem = elem.get(0);

    var opt = {
        margin: 1,
        filename: 'courseform.pdf',
        image: { type: 'jpeg', quality: 0.98 },
        html2canvas: { scale: 2 },
        jsPDF: { unit: 'in', format: 'letter', orientation: 'portrait' }
    };

    html2pdf().from(elem).set(opt).save();
    console.log("Shitt!");
}

$(document).ready(() => {
    if ($("td input:checked").length == $("td input").length) {
        $("#select-all").prop("checked", true);
    }
    $("#select-all").click(() => {
        $("td input").prop("checked", $("#select-all").prop("checked"));
    });
    $("td input").click(() => {
        if ($("td input:checked").length == $("td input").length) {
            $("#select-all").prop("checked", true);
        }
        else {
            $("#select-all").prop("checked", false);
        }
    });
    //var hiddenFields = $("input[type=hidden]");
});

function authFormSubmit() {
    console.log("Submitted");
    document.querySelector('#submit-btn').innerHTML = 'logging in..';
    document.querySelector('#submit-btn').disabled = true;
    document.querySelector('#submit-btn').style.backgroundColor = '#2d6d30';
}