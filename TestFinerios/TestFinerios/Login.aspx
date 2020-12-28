<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TestFinerios._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
    <script>
        function Error() {
            M.toast({ html: '<i class="material-icons">cancel</i><span>Usuario y/o Contraseña Incorrectos</span>', classes: 'rounded' })
        }
       
    </script>
     <nav>
  <div class="nav-wrapper">
    <a href="#!" class="brand-logo">Prueba Finerio</a>
  </div>
</nav>
    <div class="row">
        <div class="col s3 m3"></div>
    <div class="col s6 m6">
      <div class="card blue-grey darken-2">
        <div class="card-content white-text">
            <div style="text-align: center">
          <i class="material-icons large">account_box</i>
                </div>
          <span class="card-title" style="text-align:center">Login</span>
          <p>Por favor untroduzca sus credenciales.</p>
            <br />  <br /><br />  <br />
          <div class="row">
            
              
                <div class="row">
        <div class="input-field col s6">
          <asp:TextBox id="email" type="email" class="validate" runat="server" />
          <label for="email">Email</label>
        </div>
        <div class="col s6">
            <p> El email es: jonathan.ortiz.dorantes@gmail.com</p>
        </div>
      </div>
                <div class="row">
        <div class="input-field col s6">
            <asp:TextBox id="password" type="password" class="validate"  runat="server" />  
          <label for="password">Password</label>
        </div>
        <div class="col s6">
            <p> El password es: 1234Entra</p>
        </div>
      </div>
              
       
           </div>
        <div class="card-action">

            <asp:Button id="btnEntrar" class="btn waves-effect waves-light" type="button" name="action" Text="Entrar" runat="server" OnClick="BtnEntrar_Click" Font-Bold="True" CausesValidation="False" UseSubmitBehavior="False" />
          </div>
      </div>
    </div>
  </div>
        </div>


</asp:Content>
