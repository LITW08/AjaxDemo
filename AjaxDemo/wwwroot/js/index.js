$(() => {
    $("#get-number").on('click', function () {

        const from = $("#from").val();
        const to = $("#to").val();
        const parameters = {
            min: from,
            max: to
        }

        $.get(`/home/getrandomnumber`, parameters, function (obj) {
            $("#output").append(`<li>${obj.number}</li>`);
        });
    });

});