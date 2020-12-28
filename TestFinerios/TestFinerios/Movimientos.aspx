<%@ Page Title="Movimiento Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Movimientos.aspx.cs" Inherits="TestFinerios.Movimientos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
    <script>
        function Error() {
            M.toast({ html: '<i class="material-icons">cancel</i><span>Usuario y/o Contraseña Incorrectos</span>', classes: 'rounded' })
        }
       
    </script>
    <nav>
  <div class="nav-wrapper">
    <a  class="brand-logo">Movimientos</a>
    <ul class="right hide-on-med-and-down" style="padding-right:3%">
      <li>
          <asp:Label id="usu" Text="jonathan.ortiz.dorantes@gmail.com" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#5ef0f0fa" />
      </li>
    </ul>
  </div>
</nav>
    <div class="row col s12 m12">
    <div class="col s10 m10">
         <asp:GridView class="striped responsive-table" ID="tablaMo" runat="server" 
          autogeneratecolumns="False"
          emptydatatext="No data available." 
          allowpaging="false" 
            DataKeyNames="Id" AlternatingRowStyle-BorderColor="#0099FF" AlternatingRowStyle-BorderStyle="Dashed" CssClass="responsive-table" AlternatingRowStyle-CssClass="striped" PageSize="20">
<AlternatingRowStyle BorderColor="#0099FF" BorderStyle="Dashed" CssClass="striped"></AlternatingRowStyle>
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" 
                    InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Monto" HeaderText="Monto" 
                    SortExpression="Monto" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" 
                    SortExpression="Descripcion" />
                <asp:BoundField DataField="Categoria" HeaderText="Categoria" 
                    SortExpression="Categoria" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
                    SortExpression="Fecha" />
            </Columns>

             <RowStyle BorderColor="#0033CC" BorderStyle="Dashed" />

        </asp:GridView>
       
      </div>
       
        </div>
</asp:Content>