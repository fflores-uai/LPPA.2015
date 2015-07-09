<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="JobCandidateVb.aspx.vb" Inherits="UIL.JobCandidateVb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
      <nav class="navbar navbar-default" role="navigation">

        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                <span class="sr-only">Desplegar navegación</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="/Forms/Index/Index.html">ADVENTURE WORKS</a> <!--Agregar logo o aplicarle stilos-->
        </div>

        <div class="collapse navbar-collapse navbar-ex1-collapse">
            <ul class="nav navbar-nav navbar-right">
                <!--Agregar en esta seccion los link a las otras paginas-->
                <li id="HomeLink"><a href="/Forms/Index/Index.html">Home</a></li>
                <li id="CandidatesLink"><a href="/Forms/JobCandidate/JobCandidate.html">Candidates</a></li>
            </ul>
        </div>
    </nav>


    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>

    <!--Scripts-->
    <script src="../../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/Views/Index/Index.js"></script>
    <!--End Scripts-->

</body>
</html>
