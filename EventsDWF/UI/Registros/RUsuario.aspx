<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RUsuario.aspx.cs" Inherits="EventsDWF.UI.Registros.RUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">

	
			<div style="max-width: 600px;">
				<div class="panel panel-default">
					<div class="panel-heading h4 text-primary text-center">
						Registro de Usuarios
					</div>
					<div class="panel-body">
						<div class="form-horizontal" role="form">
							<div class="form-group">
								<label style="text-align:left" class="col-sm-2 control-label" for="txtmobile">ID: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control" ID="IDTexBox" placeholder="0" Enabled="true" TextMode="Number"  runat="server"></asp:TextBox>
									<div class=" btn btn-primary glyphicon glyphicon-search">
								<asp:Button  ID="BuscarButton" runat="server" Text="Buscar"  BackColor="Transparent" BorderWidth="0" OnClick="BuscarButton_Click"  ></asp:Button>
								</div>
								</div>
								
							</div>
								<div class="form-group">
								<label style="text-align:left" class="col-sm-2 control-label" for="txtmobile">Nombre: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control" ID="NombreTextBox" placeholder="Ingrese el Nombre" Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
							<div class="form-group">
								<label style="text-align:left" class="col-sm-2 control-label" for="txtmobile">User: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control" ID="UserTextBox" placeholder="Ingrese el Nombre de Usuario" Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
								<div class="form-group">
								<label style="text-align:left" class="col-sm-2 control-label" for="txtmobile">Password: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control"  ID="PasswordTextBox" placeholder="Ingrese la Contraseña" Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
							<div class="form-group">
								<label style="text-align:left" class="col-sm-2 control-label" for="txtmobile">Tipo: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control"  ID="TipoTextBox" placeholder="Ingrese el Tipo" Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
							<div class="form-group">
								<label style="text-align:left" class="col-sm-2 control-label" for="txtmobile">Email: </label>
								<div class="col-sm-10">
									<asp:TextBox class="form-control" TextMode="Email" ID="EmailTextBox" placeholder="Ingrese el Email" Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
							<div class="form-group">
								<label style="text-align:left" class="col-sm-2 control-label" for="txtmobile">Fecha: </label>
								<div class="col-sm-10">
										<asp:TextBox class="form-control" TextMode="Date" ID="FechaTextBox" placeholder=" " Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
							<div class="form-group">
								<div class="col-sm-offset-2 col-sm-10">
										<div class=" btn btn-primary glyphicon glyphicon-plus ">
									<asp:Button ID="NuevoButton" runat="server" Text="Nuevo" BackColor="Transparent" BorderWidth="0" OnClick="NuevoButton_Click"></asp:Button>
											</div>
										<div class="btn btn-success glyphicon glyphicon-floppy-disk">
									<asp:Button ID="GuardarButton" runat="server" Text="Guardar" BackColor="Transparent" BorderWidth="0" OnClick="GuardarButton_Click"></asp:Button>
											</div>
										<div class="btn btn-danger glyphicon glyphicon-floppy-remove">
									<asp:Button CssClass=" " ID="EliminarButton" runat="server" Text="Eliminar" BackColor="Transparent" BorderWidth="0" OnClick="EliminarButton_Click"></asp:Button>
											</div>
								</div>
							</div>
							</div>
						</div>
					</div>
				</div>
	</div>
	
</asp:Content>
