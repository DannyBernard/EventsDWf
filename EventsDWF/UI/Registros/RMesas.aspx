<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RMesas.aspx.cs" Inherits="EventsDWF.UI.Registros.RMesas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
<div style="max-width: 600px;">
				<div class="panel panel-default">
					<div class="panel-heading h4 text-primary text-center">
						Registro de Mesas
					</div>
					<div class="panel-body">
						<div class="form-horizontal" role="form">
							<div class="form-group">
								<label style="text-align:left" class="col-sm-4 control-label" for="txtmobile">ID: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control" ID="IDTexBox" placeholder="0" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
									<div class=" btn btn-primary glyphicon glyphicon-search">
								<asp:Button ID="BuscarButton" runat="server" Text="Buscar"  BackColor="Transparent" BorderWidth="0"   ></asp:Button>
								</div>
								</div>
								
							</div>
								<div class="form-group">
								<label style="text-align:left" class="col-sm-4 control-label" for="txtmobile">Numero De Mesa: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control" ID="NumeromesaTextBox" placeholder="0" Enabled="true" TextModel="Numer"  runat="server"></asp:TextBox>
								</div>
								</div>
							<div class="form-group">
								<label style="text-align:left" class="col-sm-4 control-label" for="txtmobile">Cantidad de personas: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control" ID="CantidadPersonasTextBox" placeholder="0" Enabled="true" TextModel="Numer"  runat="server"></asp:TextBox>
								</div>
								</div>
								<div class="form-group">
								<label style="text-align:left" class="col-sm-4 control-label" for="txtmobile">Precio: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control"  ID="PrecioTextBox" placeholder="0.0"  TextModel="Numer" Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
							<div class="form-group">
								<label style="text-align:left" class="col-sm-4 control-label" for="txtmobile">Cantidad: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control"  ID="CntidadTextBox" placeholder="0" TextModel="Numer" Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
							
							<div class="form-group">
								<div class="col-sm-offset-2 col-sm-10">
										<div class=" btn btn-primary glyphicon glyphicon-plus ">
									<asp:Button ID="NuevoButton" runat="server" Text="Nuevo" BackColor="Transparent" BorderWidth="0" ></asp:Button>
											</div>
										<div class="btn btn-success glyphicon glyphicon-floppy-disk">
									<asp:Button ID="GuardarButton" runat="server" Text="Guardar" BackColor="Transparent" BorderWidth="0" ></asp:Button>
											</div>
										<div class="btn btn-danger glyphicon glyphicon-floppy-remove">
									<asp:Button CssClass=" " ID="EliminarButton" runat="server" Text="Eliminar" BackColor="Transparent" BorderWidth="0" ></asp:Button>
											</div>
								</div>
							</div>
							</div>
						</div>
					</div>
				</div>
	</div>
</asp:Content>
