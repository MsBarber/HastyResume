$(document).ready(function () {

    function AddButton() {
        var maxFields = 3;
        var wrapper = $("#eduFieldWrapper");
        var addButton = $("#addFieldGroup");

        var n = 1;
        html = "<br><hr style='color:#1a1a1a;border-width:3px;'><br><label for='schoolName'>Institution:</label><input type='text' class='form-control' id='schoolName" + String(n) + "' placeholder='School Name'></input><br><label for='completionDate" + String(n) + "'>Completion Date:</label><input type='text' class='form-control' id='completionDate" + String(n) + "' placeholder='mm/dd/yy'></input><br><label for='eduText" + String(n) + "'><br>Tell Us More:</label><br>" +
            "<textarea style='max-width:100%' type='text' class='form-control' id='eduText" + String(n) + "'></textarea>";

        addButton.click(function (e) {
            e.preventDefault();
            if (n < maxFields) {
                n++;
                wrapper.append(html);
            }
            if (n == 3) {
                $("#addFieldGroup").remove();
            }
        })
    };
});
