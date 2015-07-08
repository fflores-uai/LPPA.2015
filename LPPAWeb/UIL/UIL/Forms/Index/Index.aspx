<%@ Page Title="HOMES" Language="vb" AutoEventWireup="false" MasterPageFile="~/Forms/Shared/MasterPage.Master" CodeBehind="Index.aspx.vb" Inherits="Website.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <!--SLIDER-->
    <div class="visible-lg visible-md" style="height:800px;">
        <div class="slider">

            <div class="slide active-slide">
                <div class="container">
                    <div class="row">
                        <div class="slide-copy col-xs-5">
                            <h1 class="header">Adventure Works Cycles</h1>
                            <p>The way you ride</p>

                            <ul class="get-app">
                                <li><a href="#">
                                    <img src="/Content/Resourses/ios.png" /></a></li>
                                <li><a href="#">
                                    <img src="../../Content/Resourses/windows.png" /></a></li>
                                <li><a href="#">
                                    <img src="../../Content/Resourses/blackberry.png" /></a></li>
                                <li><a href="#">
                                    <img src="../../Content/Resourses/android.png" /></a></li>
                            </ul>
                        </div>
                        <div class="slide-img col-xs-7">
                            <img src="/Content/Resourses/trasnp.png" width="450" height="90" />
                            <img src="../../Content/Resourses/kid.jpg" width="450" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="slide slide-feature">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <a href="#">
                                <img src="/Content/Resourses/Logo.png" /></a>
                            <a href="#"></a>
                        </div>
                    </div>
                </div>
            </div>

            <div class="slide">
                <div class="container">
                    <div class="row">
                        <div class="slide-copy col-xs-5">
                            <h1 class="header">Todos los Terrenos</h1>
                            <p>
                                Aquellas que incorporan los últimos avances en
                                tecnología y materiales, siendo por lo tanto las más
                                caras y sofisticadas. El uso principal de estas
                                bicicletas es la competencia.
                            </p>

                            <ul class="get-app">
                                <li><a href="#">
                                    <img src="/Content/Resourses/ios.png" /></a></li>
                                <li><a href="#">
                                    <img src="../../Content/Resourses/windows.png" /></a></li>
                                <li><a href="#">
                                    <img src="../../Content/Resourses/blackberry.png" /></a></li>
                                <li><a href="#">
                                    <img src="../../Content/Resourses/android.png" /></a></li>
                            </ul>
                        </div>
                        <div class="slide-img col-xs-7">
                            <img src="/Content/Resourses/trasnp.png" width="450" height="90" />
                            <img src="/Content/Resourses/woman.jpg" width="450" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--END SLIDER-->
        <!--NAVEGADOR CARRUSEL-->
        <div class="slider-nav">
            <a href="#" class="arrow-prev">
                <img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/arrow-prev.png" /></a>
            <ul class="slider-dots">
                <li class="dot active-dot">&bull;</li>
                <li class="dot">&bull;</li>
                <li class="dot">&bull;</li>
            </ul>
            <a href="#" class="arrow-next">
                <img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/arrow-next.png" /></a>
        </div>
    </div>
    <!--END NAVEGADOR CARRUSEL-->

    <!--IMAGEN CHICA-->

    <div class="hidden-md hidden-lg">
        <section>
            <article class="jumbotron">
                <p class="text-center">
                    <img src="../../Content/Resourses/Logo.png" />
                </p>
            </article>
        </section>
    </div>
    <!--IMAGEN CHICA-->

    <!--MODAL LOGIN-->

    <!--END MODAL LOGIN-->
    <footer>
        <p>
            <a href="Index.html">ADVENTURE WORKS CYLCLE</a>
        </p>
    </footer>
</asp:Content>