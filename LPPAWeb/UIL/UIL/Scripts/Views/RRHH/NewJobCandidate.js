$(document).ready(Main);

function Main() {
    $('#Contenido_JobCandidateTable > tbody > tr:nth-child(2) > td:nth-child(1)').click(function () {

        //$('#Contenido_txtNumber').val() = 'test';


        document.getElementById("Contenido_txtNumber").value = 
            $('#Contenido_JobCandidateTable > tbody > tr:nth-child(2)').val();
        //$('#Contenido_JobCandidateTable > tbody > tr:nth-child(3) > td:nth-child(1)')
    })
}