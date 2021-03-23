$(() => {

    function fillTable() {
        $("tbody").empty();
        $.get('/people/getall', function (ppl) {
            ppl.forEach(p => {
                $("tbody").append(`
<tr>
    <td>${p.firstName}</td>
    <td>${p.lastName}</td>
    <td>${p.age}</td>

</tr>`);
            });
        });
    }

    fillTable();

    $("#add").on('click', function() {
        const firstName = $("#first-name").val();
        const lastName = $("#last-name").val();
        const age = $("#age").val();

        $("#first-name").val('');
        $("#last-name").val('');
        $("#age").val('');

        $.post('/people/add', { firstName, lastName, age }, function(p) {
            fillTable();
        });

    });
})