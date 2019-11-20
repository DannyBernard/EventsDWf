<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RReserva.aspx.cs" Inherits="EventsDWF.UI.Registros.RReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<div style="max-width: 600px;">
			<div class="panel panel-default">
				<div class="panel-heading h4 text-primary text-center panel-primary">
					Registro de Reserva
				</div>
				<div class="panel-body">
					<div class="form-horizontal" role="form">
						<div class="form-group">
								<label style="text-align:left" class="col-sm-2 control-label" for="txtmobile">Fecha: </label>
								<div class="col-sm-10">
										<asp:TextBox class="form-control" TextMode="Date" ID="FechaTextBox" placeholder=" " Enabled="true"  runat="server"></asp:TextBox>
								</div>
								</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">ID: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="IDTexBox" placeholder="0" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
								<div class=" btn btn-primary glyphicon glyphicon-search">
									<asp:Button ID="BuscarButton" runat="server" Text="Buscar" BackColor="Transparent" BorderWidth="0" OnClick="BuscarButton_Click"></asp:Button>
								</div>
							</div>
						</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">Nombre: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="NombreTextBox" placeholder="Ingrese el Nombre" Enabled="true" runat="server"></asp:TextBox>
							</div>
						</div>
						<div class="form-group">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">NumeroMesa: </label>
							<div class="col-sm-10">
								<asp:DropDownList ID="NumeroMesaDropdownList" CssClass=" form-control dropdown-item" AppendDataBoundItems="true" runat="server" Height="2.8em" OnSelectedIndexChanged="NumeroMesaDropdownList_SelectedIndexChanged" >
								</asp:DropDownList>
							</div>
						</div>
						<div class="form-group float-left">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">Reserva No: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="NumeroTextBox" placeholder="Numero de Reserva" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
							</div>
						</div>
						<div class="form-group ">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">Cantidad: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="CantidadTextBox" placeholder="de Reserva" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
							</div>
						</div>
						<div class="form-group float-left">
							<label style="text-align: left" class="col-sm-4 control-label" for="txtmobile">Precio: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="PrecioTextBox" placeholder="Numero de Reserva" Enabled="true" TextMode="Number" runat="server"></asp:TextBox>
							</div>
						</div>
							<div class=" btn btn-success glyphicon glyphicon-plus ">
									<asp:Button ID="AddButton" runat="server" Text="Add" BackColor="Transparent" BorderWidth="0" OnClick="AddButton_Click" ></asp:Button>
								</div>
						<hr />
						<div class="row">
							<asp:GridView ID="DatosGridView"
								runat="server"
								class="table table-condensed table-bordered table-responsive"
								CellPadding="4" ForeColor="#333333" GridLines="None">
								<alternatingrowstyle backcolor="White" />
								<columns>
                                <asp:TemplateField ShowHeader="False" HeaderText="Remover">
                                    <ItemTemplate>
                                        <asp:Button ID="RemoveLinkButton" runat="server" CausesValidation="false" CommandName="Select"
                                            Text="REMOVE"  OnClick="RemoveLinkButton_Click" class="btn btn-danger btn-sm"  />
                                    </ItemTemplate>
                                </asp:TemplateField>
                             </columns>
								<headerstyle backcolor="#507CD1" font-bold="True" forecolor="White" />
								<rowstyle backcolor="#EFF3FB" />
							</asp:GridView>
						</div>
						<hr />
						<div class="form-group float-left">
							<label style="text-align: left" class="col-sm-6 control-label" for="txtmobile">Total: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="TotalTextBox" placeholder="0" Enabled="true" Enable="false" TextMode="Number" runat="server"></asp:TextBox>
							</div>
						</div>
						<hr />
						<div class="form-group float-left">
							<label style="text-align: left" class="col-sm-6 control-label" for="txtmobile">Total: </label>
							<div class="col-sm-10">
								<asp:TextBox class="form-control" ID="CntTextBox" placeholder="0" Enabled="true" Enable="false" TextMode="Number" runat="server"></asp:TextBox>
							</div>
						</div>
						<hr />	
					</div>
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
</asp:Content>
