$(document).ready(Main);

function Main() {
    //$('.dataTable').DataTable();

    $('td').click(function () {

        document.getElementById("Contenido_txtNumber").value =
           this.innerText;
    });
    
    
    
}