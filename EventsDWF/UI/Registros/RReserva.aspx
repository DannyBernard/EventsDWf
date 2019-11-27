<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RReserva.aspx.cs" Inherits="EventsDWF.UI.Registros.RReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<div class="panel panel-primary">
			<div class="panel-heading text-primary text-center">Registro Reserva</div>
			<div class="panel-body">
				<div class="form-horizontal col-md-12" role="form">
					<div class="panel-heading h4 text-primary text-center panel-primary">
						<h1><span style="color: deepskyblue;">Registro de Reserva </span></h1>

						<div class="form-group">
							<label style="text-align: right" class=" col col-sm-12 control-label" for="txtmobile">Fecha: </label>
							&nbsp&nbsp&nbsp
						<asp:Label Style="text-align: right" ID="FechaLabel" class=" col col-sm-12 control-label" runat="server" Text="Fecha: "></asp:Label>

						</div>
					</div>
					<div class="form-group ">
						<label style="text-align:left" class="col-sm-8 control-label" for="txtmobile">ID: </label>
						<div class="col-sm-6">
							<asp:TextBox class="form-control" ID="IDTexBox" min="0" placeholder="0" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
							<div class=" col-md-6 btn btn-primary glyphicon glyphicon-search">
								<asp:Button ID="BuscarButton" runat="server" Text="Buscar" BackColor="Transparent" BorderWidth="0" OnClick="BuscarButton_Click"></asp:Button>
							</div>
						</div>
					</div>

					<div class="row">
						<div class="form-group" >
							<label style="text-align: left" class="col-sm-8 control-label" for="txtmobile">Nombre: </label>
							<div class="col-sm-6">
								<asp:TextBox class="form-control" ID="NombreTextBox" placeholder="Ingrese el Nombre" Enabled="true" runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" MaxLength="200"
									ControlToValidate="NombreTextBox"
									ErrorMessage="Campo  obligatorio" ForeColor="Red"
									Display="Dynamic" SetFocusOnError="True"
									ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el Nombre
								</asp:RequiredFieldValidator>
							</div>
							<!--cantidad-->
						</div>
						<div class="form-group ">
							<label style="text-align: left" class="col-sm-8 control-label" for="txtmobile">Cantidad a Reservar: </label>
							<div class="col-md-6">
								<asp:TextBox class="form-control" ID="CantidadTextBox" min="0" placeholder="de Reserva" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" MaxLength="200"
									ControlToValidate="CantidadTextBox"
									ErrorMessage="Campo  obligatorio" ForeColor="Red"
									Display="Dynamic" SetFocusOnError="True"
									ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el campo cantidad
								</asp:RequiredFieldValidator>
							</div>
						</div>

						<div class="form-group">
							<label style="text-align: left" class="col-sm-8 control-label" for="txtmobile">Numero de combo de Mesa: </label>
							<div class="col-sm-6">
								<asp:DropDownList ID="NumeroMesaDropdownList" min="0" CssClass=" form-control dropdown-item" AppendDataBoundItems="true" runat="server" Height="2.8em" AutoPostBack="true"  >
								</asp:DropDownList>
							</div>
						</div>
						<div class="form-group ">
							<label style="text-align: left" class="col-sm-8 control-label" for="txtmobile">Precio: </label>
							<div class="col-sm-6">
								<asp:TextBox class="form-control" ID="PrecioTextBox" step="0.001" min="0"  placeholder="Ingrese el precio" Enabled="true" TextMode="Number" runat="server"  Visible="true"></asp:TextBox>
								<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" MaxLength="200"
									ControlToValidate="PrecioTextBox"
									ErrorMessage="Campo  obligatorio" ForeColor="Red"
									Display="Dynamic" SetFocusOnError="True"
									ToolTip="Campo Numero obligatorio" ValidationGroup="Guardar">Por favor llenar el Precio
								</asp:RequiredFieldValidator>
							</div>
						</div>
						<div class=" btn btn-success glyphicon glyphicon-plus ">
							<asp:Button ID="AddButton" runat="server" Text="Add" ValidationGroup="Guardar" BackColor="Transparent" BorderWidth="0" OnClick="AddButton_Click"></asp:Button>

						</div>
						<hr />

						<asp:GridView ID="DatosGridView"
							runat="server"
							class="table table-condensed table-bordered table-responsive"
							CellPadding="4" ForeColor="#333333" GridLines="None">
							<AlternatingRowStyle BackColor="White" />
							<Columns>
								<asp:TemplateField ShowHeader="False" HeaderText="Remover">
									<ItemTemplate>
										<asp:Button ID="RemoveLinkButton" runat="server" CausesValidation="false" CommandName="Select"
											Text="REMOVE" OnClick="RemoveLinkButton_Click" class="btn btn-danger btn-sm" />
									</ItemTemplate>
								</asp:TemplateField>
							</Columns>
							<HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
							<RowStyle BackColor="#EFF3FB" />
						</asp:GridView>

						<hr />
						<div class="form-group float-left">
							<label style="text-align: left" class="col-sm-6 control-label" for="txtmobile">Total: </label>
							<div class="col-sm-6">
								<asp:TextBox class="form-control" ID="TotalTextBox" placeholder="0" Enabled="true" Enable="false" TextMode="Number" runat="server"></asp:TextBox>
							</div>
						</div>
						<hr />
						<div class="form-group float-left">
							<label style="text-align: left" class="col-sm-6 control-label" for="txtmobile">Cantidad Total de Mesas: </label>
							<div class="col-sm-6">
								<asp:TextBox class="form-control" ID="CntTextBox" placeholder="0" Enabled="true" Enable="false" TextMode="Number" runat="server"></asp:TextBox>
							</div>
						</div>
						<hr />

						<div class="form-group">
							<div class="col-sm-offset-2 col-sm-10">
								<div class=" btn btn-primary glyphicon glyphicon-plus ">
									<asp:Button ID="NuevoButton" runat="server" Text="Nuevo" BackColor="Transparent" BorderWidth="0"></asp:Button>
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
