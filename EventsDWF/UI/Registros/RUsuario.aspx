<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RUsuario.aspx.cs" Inherits="EventsDWF.UI.Registros.RUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<div style="max-width: 1000px;">
			<div class="panel panel-primary">
				<div class="panel-heading h4 text-primary text-center">
					Registro de Usuarios
					<div class="form-group">
							<label style="text-align: right" class=" col col-sm-12 control-label" for="txtmobile">Fecha: </label>
							&nbsp&nbsp&nbsp
						<asp:Label Style="text-align: right" ID="FechaLabel" class=" col col-sm-12 control-label" runat="server" Text="Fecha: "></asp:Label>

						</div>
				</div>
				<div class="panel-body">
					<div class="form-horizontal" role="form">
						<div class="form-group">
							<label style="text-align: left" class="col-sm-2 control-label" for="txtmobile">ID: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="IDTexBox" placeholder="0" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
								<div class=" btn btn-primary glyphicon glyphicon-search">
									<asp:Button ID="BuscarButton" runat="server" Text="Buscar" BackColor="Transparent" BorderWidth="0" OnClick="BuscarButton_Click"></asp:Button>
								</div>
							</div>

						</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-2 control-label" for="txtmobile">Nombre: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="NombreTextBox" placeholder="Ingrese el Nombre" Enabled="true" runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" MaxLength="200"
									ControlToValidate="NombreTextBox"
									ErrorMessage="Campo obligatorio" ForeColor="Red"
									Display="Dynamic" SetFocusOnError="True"
									ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el Nombre
								</asp:RequiredFieldValidator>
							</div>
						</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-2 control-label" for="txtmobile">User: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="UserTextBox" placeholder="Ingrese el Nombre de Usuario" Enabled="true" runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" MaxLength="200"
									ControlToValidate="UserTextBox"
									ErrorMessage="Campo  obligatorio" ForeColor="Red"
									Display="Dynamic" SetFocusOnError="True"
									ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el User
								</asp:RequiredFieldValidator>
							</div>

						</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-2 control-label" for="txtmobile">Password: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="PasswordTextBox" placeholder="Ingrese la Contraseña" TextMode="Password" Enabled="true" runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" MaxLength="200"
									ControlToValidate="PasswordTextBox"
									ErrorMessage="Campo obligatorio" ForeColor="Red"
									Display="Dynamic" SetFocusOnError="True"
									ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el PassWord
								</asp:RequiredFieldValidator>
							</div>
						</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-2 control-label" for="txtmobile">Tipo: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="TipoTextBox" placeholder="Ingrese el Tipo" Enabled="true" runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" MaxLength="200"
									ControlToValidate="TipoTextBox"
									ErrorMessage="Campo Estudiante obligatorio" ForeColor="Red"
									Display="Dynamic" SetFocusOnError="True"
									ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el Tipo
								</asp:RequiredFieldValidator>
							</div>
						</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-2 control-label" for="txtmobile">Email: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" TextMode="Email" ID="EmailTextBox" placeholder="Ingrese el Email" Enabled="true" runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" MaxLength="200"
									ControlToValidate="EmailTextBox"
									ErrorMessage="Campo Estudiante obligatorio" ForeColor="Red"
									Display="Dynamic" SetFocusOnError="True"
									ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el Email
								</asp:RequiredFieldValidator>
							</div>
						</div>
						
						</div>
						<div class="form-group">
							<div class="col-sm-offset-2 col-sm-10">
								<div class=" btn btn-primary glyphicon glyphicon-plus ">
									<asp:Button ID="NuevoButton" runat="server" Text="Nuevo" BackColor="Transparent" BorderWidth="0" OnClick="NuevoButton_Click"></asp:Button>
								</div>
								<div class="btn btn-success glyphicon glyphicon-floppy-disk">
									<asp:Button ID="GuardarButton" runat="server" Text="Guardar" BackColor="Transparent" ValidationGroup="Guardar" BorderWidth="0" OnClick="GuardarButton_Click"></asp:Button>
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
