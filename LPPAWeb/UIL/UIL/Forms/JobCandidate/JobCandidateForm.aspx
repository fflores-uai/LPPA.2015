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
    <form id="bodyForm" runat="server">

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
            <article id="NameFieldSet" class="active table-bordered" style="padding: 10px">
                <fieldset>
                    <legend>Datos Personales</legend>

                    <div>
                        <p>
                            <label for="cbxPrefix">Prefix : </label>

                            <asp:DropDownList ID="cbxPrefix" runat="server">
                                <asp:ListItem Text="Mr." Value="1" Selected="true" />
                                <asp:ListItem Text="Mrs." Value="2" />
                            </asp:DropDownList>
                        </p>
                    </div>
                    <div>
                        <p>
                            <label for="txtFirstName">First Name : </label>
                            <asp:TextBox ID="txtFirstName" type="text" runat="server"></asp:TextBox>
                        </p>
                    </div>
                    <p>
                        <label for="txtMiddleName">Middle Name: </label>
                        <asp:TextBox ID="txtMiddleName" type="text" runat="server"></asp:TextBox>
                    </p>

                    <p>
                        <label for="txtLastName">Last Name: </label>
                        <asp:TextBox ID="txtLastName" type="text" runat="server"></asp:TextBox>
                    </p>

                    <div>
                        <p>
                            <asp:Button type="button" ID="btnNext" runat="server" />
                        </p>
                    </div>
                </fieldset>
            </article>

            <article id="SkillsFieldSet" class="active table-bordered" style="padding: 10px">
                <fieldset>
                    <legend>Skills</legend>
                    <div>
                        <p>
                            <label for="txtSkill">Description: </label>
                            <asp:TextBox TextMode="MultiLine" ID="txtSkill" type="text" Style="width: 400px; max-width: 400px" runat="server"></asp:TextBox>
                        </p>
                    </div>
                </fieldset>
            </article>
        </section>
    </form>
</body>
</html>