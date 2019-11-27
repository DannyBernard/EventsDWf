<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RMesas.aspx.cs" Inherits="EventsDWF.UI.Registros.RMesas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<div style="max-width: 600px;">
			<div class="panel panel-primary">
				<div class="panel-heading h4 text-primary text-center">
					Registro de combo de  Mesas
					<div class="form-group">
							<label style="text-align: right" class=" col col-sm-12 control-label" for="txtmobile">Fecha: </label>
							&nbsp&nbsp&nbsp
						<asp:Label Style="text-align: right" ID="FechaLabel" class=" col col-sm-12 control-label" runat="server" Text="Fecha: "></asp:Label>

						</div>
					
				</div>
				<div class="panel-body">
					<div class="form-horizontal" role="form">
						<div class="form-group">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">ID: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="IDTexBox" placeholder="0" min="0" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
								<div class=" btn btn-primary glyphicon glyphicon-search">
									<asp:Button ID="BuscarButton" runat="server" Text="Buscar" BackColor="Transparent" BorderWidth="0" OnClick="BuscarButton_Click1"></asp:Button>
								</div>
							</div>

						</div>
					
						<div class="form-group">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">Cantidad de personas: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="CantidadPersonasTextBox" placeholder="0" min="0" Enabled="true" TextModel="Numer" runat="server"></asp:TextBox>
								  <asp:RequiredFieldValidator ID="CantidadPersonas" runat="server" MaxLength="200"
                                ControlToValidate="CantidadPersonasTextBox"
                                ErrorMessage="Campo obligatorio" ForeColor="Red"
                                Display="Dynamic" SetFocusOnError="True"
                                ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el campo Cantidad de personas
                            </asp:RequiredFieldValidator>
							
							</div>
						</div>
							<div class="form-group">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">Cantidad de Mesas: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="CantidadTextBox" min="0" placeholder="0" Enabled="true" TextModel="Numer" runat="server"></asp:TextBox>
								  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" MaxLength="200"
                                ControlToValidate="CantidadTextBox"
                                ErrorMessage="Campo  obligatorio" ForeColor="Red"
                                Display="Dynamic" SetFocusOnError="True"
                                ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el campo Cantidad 
                            </asp:RequiredFieldValidator>
							
							</div>
						</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">Precio: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="PrecioTextBox" min="0" placeholder="0.0" TextModel="Numer" Enabled="true" runat="server"></asp:TextBox>
								  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" MaxLength="200"
                                ControlToValidate="CantidadTextBox"
                                ErrorMessage="Campo  obligatorio" ForeColor="Red"
                                Display="Dynamic" SetFocusOnError="True"
                                ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el campo Precio
                            </asp:RequiredFieldValidator>
							</div>
						</div>
						
						<div class="form-group">
							<div class="col-sm-offset-2 col-sm-10">
								<div class=" btn btn-primary glyphicon glyphicon-plus ">
									<asp:Button ID="NuevoButton" runat="server" Text="Nuevo" BackColor="Transparent" BorderWidth="0" OnClick="NuevoButton_Click"></asp:Button>
								</div>
								<div class="btn btn-success glyphicon glyphicon-floppy-disk">
									<asp:Button ID="GuardarButton" runat="server" Text="Guardar" ValidationGroup="Guardar" BackColor="Transparent" BorderWidth="0" OnClick="GuardarButton_Click"></asp:Button>
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
