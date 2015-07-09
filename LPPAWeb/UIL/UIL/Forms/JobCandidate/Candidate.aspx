<%@ Page Title="CANDIDATE" Language="vb" AutoEventWireup="false" MasterPageFile="~/Forms/Shared/MasterPage.Master" CodeBehind="Candidate.aspx.vb" Inherits="Website.Candidate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <!--FORMS INGRESO DATOS-->
    <div id="containerFieldsets">
        <section class="form-group col-lg-5 center-block">

            <!--NAME-->
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
                    
                         <p>
                            <label for="txtFirstName">First Name : </label>
                            <asp:TextBox ID="txtFirstName" type="text" runat="server"></asp:TextBox>
                        </p>

                    <p>
                        <label for="txtMiddleName">Middle Name: </label>
                        <asp:TextBox ID="txtMiddleName" type="text" runat="server"></asp:TextBox>
                    </p>

                    <p>
                        <label for="txtLastName">Last Name: </label>
                        <asp:TextBox ID="txtLastName" type="text" runat="server"></asp:TextBox>
                    </p>

                        <p>
                        <label for="txtEmail">Email: </label>
                        <asp:TextBox ID="txtEmail" type="text" runat="server"></asp:TextBox>
                    </p>

                        <p>
                        <label for="txtWebsite">WebSite: </label>
                        <asp:TextBox ID="txtWebsite" type="text" runat="server"></asp:TextBox>
                    </p>

                        </div>
      
                </fieldset>
            </article>
            <!--NAME END-->

            <!--SKILLS-->
            <article id="SkillsFieldSet" class="active table-bordered " style="padding: 10px">
                <fieldset>
                    <legend>Skills</legend>
                    <div>
                        <p>
                            <label for="txtSkill">Description: </label>
                            <asp:TextBox TextMode="MultiLine" ID="txtSkill" type="text" Style="width: 400px; max-width: 400px; height: 400px" runat="server"></asp:TextBox>
                        </p>
                    </div>

                </fieldset>
            </article>
            <!--SKILLS END-->

            <!--EMPLOYEMENT-->
            <article id="EmploymentFieldset" class="active table-bordered " style="padding: 10px">
                <fieldset>
                    <legend>Employement</legend>
                    <div>
                        <p>
                            <label for="txtStartDate">Start Date: </label>
                            <asp:TextBox ID="txtStartDate" type="text" runat="server"></asp:TextBox>
                        </p>

                        <p>
                            <label for="txtEndDate">End Date: </label>
                            <asp:TextBox ID="txtEndDate" type="text" runat="server"></asp:TextBox>
                        </p>
                        <p>
                            <label for="txtOrgName">Organization Name: </label>
                            <asp:TextBox ID="txtOrgName" type="text" runat="server"></asp:TextBox>
                        </p>

                        <p>
                            <label for="txtJobTitle">Job Title: </label>
                            <asp:TextBox ID="txtJobTitle" type="text" runat="server"></asp:TextBox>
                        </p>

                        <p>
                            <label for="txtResponsibility">Responsibility: </label>
                            <asp:TextBox TextMode="MultiLine"
                                ID="txtResponsibility"
                                Style="width: 350px; max-width: 350px; height: 50px"
                                type="text"
                                runat="server"></asp:TextBox>
                        </p>

                        <p>
                            <label for="txtFunctionCategory">Function Category: </label>
                            <asp:TextBox ID="txtFunctionCategory" type="text" runat="server"></asp:TextBox>
                        </p>

                        <p>
                            <label for="txtIndustryCategory">Industry Category: </label>
                            <asp:TextBox ID="txtIndustryCategory" type="text" runat="server"></asp:TextBox>
                        </p>
                        <!--LOCATION-->
                        <div>

                            <fieldset>
                                <legend>Location</legend>
                                <p>
                                    <label for="txtCountryRegion">Country Region: </label>
                                    <asp:TextBox ID="txtCountryRegion" type="text" runat="server"></asp:TextBox>
                                </p>

                                <p>
                                    <label for="txtState">State: </label>
                                    <asp:TextBox ID="txtState" type="text" runat="server"></asp:TextBox>
                                </p>

                                <p>
                                    <label for="txtCity">City: </label>
                                    <asp:TextBox ID="txtCity" type="text" runat="server"></asp:TextBox>
                                </p>
                            </fieldset>
                        </div>
                        <!--LOCATION-->


                    </div>

                </fieldset>
            </article>
            <!--EMPLOYEMENT END-->

            <!--EDUCATION-->
            <article id="EducationFieldset" class="active table-bordered " style="padding: 10px">
                <fieldset>
                    <legend>Education</legend>
                    <div>
                        <p>
                            <label for="txtLevel">Start Date: </label>
                            <asp:TextBox ID="txtStartDate1" type="text" runat="server"></asp:TextBox>
                        </p>

                        <p>
                            <label for="txtStartDateEd">Start Date: </label>
                            <asp:TextBox ID="txtStartDateEd" type="text" runat="server"></asp:TextBox>
                        </p>

                        <p>
                            <label for="txtEndDateEd">End Date: </label>
                            <asp:TextBox ID="txtEndDateEd" type="text" runat="server"></asp:TextBox>
                        </p>

                         <p>
                            <label for="txtDegree">Degree: </label>
                            <asp:TextBox ID="txtDegree" type="text" runat="server"></asp:TextBox>
                        </p>

                         <p>
                            <label for="txtMajor">Major: </label>
                            <asp:TextBox ID="txtMajor" type="text" runat="server"></asp:TextBox>
                        </p>

                         <p>
                            <label for="txtMinor">Minor: </label>
                            <asp:TextBox ID="txtMinor" type="text" runat="server"></asp:TextBox>
                        </p>

                         <p>
                            <label for="txtGPA">GPA: </label>
                            <asp:TextBox ID="txtGPA" type="text" runat="server"></asp:TextBox>
                        </p>

                         <p>
                            <label for="txtGPAScale">GPA Scale: </label>
                            <asp:TextBox ID="txtGPAScale" type="text" runat="server"></asp:TextBox>
                        </p>

                         <p>
                            <label for="txtSchool">School: </label>
                            <asp:TextBox ID="txtSchool" type="text" runat="server"></asp:TextBox>
                        </p>

                         <!--LOCATION-->
                        <div>

                            <fieldset>
                                <legend>Location</legend>
                                <p>
                                    <label for="txtCountryRegionEd">Country Region: </label>
                                    <asp:TextBox ID="txtCountryRegionEd" type="text" runat="server"></asp:TextBox>
                                </p>

                                <p>
                                    <label for="txtStateEd">State: </label>
                                    <asp:TextBox ID="txtStateEd" type="text" runat="server"></asp:TextBox>
                                </p>

                                <p>
                                    <label for="txtCityEd">City: </label>
                                    <asp:TextBox ID="txtCityEd" type="text" runat="server"></asp:TextBox>
                                </p>
                            </fieldset>
                        </div>
                        <!--LOCATION-->

                    </div>

                </fieldset>
            </article>
            <!--EDUCACTION-->

            <!--ADDRESS-->
            <article id="AddressFieldset" class="active table-bordered " style="padding: 10px">
                <fieldset>
                    <legend>Address</legend>
                    <div>
                        <p>
                            <label for="txtType">Type: </label>
                            <asp:TextBox ID="txtType" type="text" runat="server"></asp:TextBox>
                        </p>

                        <p>
                            <label for="txtStreet">Street: </label>
                            <asp:TextBox ID="txtStreet" type="text" runat="server"></asp:TextBox>
                        </p>

                    </div>

                      <!--LOCATION-->
                        <div>

                            <fieldset>
                                <legend>Location</legend>
                                <p>
                                    <label for="txtCountryRegionAd">Country Region: </label>
                                    <asp:TextBox ID="txtCountryRegionAd" type="text" runat="server"></asp:TextBox>
                                </p>

                                <p>
                                    <label for="txtStateAd">State: </label>
                                    <asp:TextBox ID="txtStateAd" type="text" runat="server"></asp:TextBox>
                                </p>

                                <p>
                                    <label for="txtCityAd">City: </label>
                                    <asp:TextBox ID="txtCityAd" type="text" runat="server"></asp:TextBox>
                                </p>
                            </fieldset>
                        </div>
                        <!--LOCATION-->

                    <!--TELEPHONE-->
                        <div>

                            <fieldset>
                                <legend>Telephone</legend>
                                <p>
                                    <label for="txtTypeTel">Tel. Type: </label>
                                    <asp:TextBox ID="txtTypeTel" type="text" runat="server"></asp:TextBox>
                                </p>

                                <p>
                                    <label for="txtIntlCode">Int. Code: </label>
                                    <asp:TextBox ID="txtIntlCode" type="text" runat="server"></asp:TextBox>
                                </p>

                                 <p>
                                    <label for="txtAreaCode">Area Code: </label>
                                    <asp:TextBox ID="txtAreaCode" type="text" runat="server"></asp:TextBox>
                                </p>

                                <p>
                                    <label for="txtNumber">Number: </label>
                                    <asp:TextBox ID="txtNumber" type="text" runat="server"></asp:TextBox>
                                </p>
                            </fieldset>
                        </div>
                        <!--TELEPHONE-->

                
                </fieldset>
            </article>

            <article class="fieldSetButtons">
                <div>
                        <p style="padding-top: 20px;">
                            <asp:Button ID="btnNext" type="button" Text="NEXT" runat="server" />
                        </p>
                    </div>
                <div>
                    <p style="padding-top: 10px;">
                            <asp:Button ID="btnAddMe" type="button" Text="ADD CANDIDATE" runat="server" />
                        </p>
                </div>

                </article>
            <!--ADDRESS END-->
        </section>
    </div>
</asp:Content>