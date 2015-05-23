<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="JobCandidateForm.aspx.vb" Inherits="UIL.JobCandidateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Job Candidates</title>
    <link href="/Content/bootstrap.css" rel="stylesheet" />
    <link href="/Content/Slider.css" rel="stylesheet" />
    <link href="../../Content/MyStyle.css" rel="stylesheet" />
</head>
<body>

    <!--HEADER NavBar-->
    <header>
        <nav class="navbar navbar-default" role="navigation">

            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                    <span class="sr-only">Desplegar navegación</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="/Forms/Index/Index.html">
                    <img src="/Content/Resourses/awc_logo.png" width="180" /></a>
                <!--Agregar logo o aplicarle stilos-->
            </div>

            <div class="collapse navbar-collapse navbar-ex1-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <!--Agregar en esta seccion los link a las otras paginas-->
                    <li id="HomeLink"><a href="/Forms/Index/Index.html">Home</a></li>
                    <li id="CandidatesLink"><a href="/Forms/JobCandidate/JobCandidate.html">Candidates</a></li>

                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" id="UserName">UserName<b class="caret"></b></a>
                        <ul class="dropdown-menu">
                            <li id="SingIn"><a href="#">Sing In</a></li>
                            <li id="LogOut"><a href="#">Log Out</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </nav>
    </header>
    <!--END HEADER-->

    <!--FORMS INGRESO DATOS-->
    <section class="form-group col-lg-5 center-block">
        <article class="active table-bordered" style="padding: 10px">
            <div>
                
                <p>
                    <label>First Name : </label>
                    <asp:TextBox ID="TextBox1" class="input-sm" type="text" name="Name" runat="server" /></asp:TextBox>
                </p>
                <p>
                    <label>Middle Name: </label>
                    <input class="input-sm" type="text" name="Name" value="" />
                </p>
                <p>
                    <label>Last Name : </label>
                    <input class="input-sm" type="text" name="Name" value="" />
                </p>
            </div>
        </article>

    </section>


    <footer>
    </footer>

</body>
</html>
