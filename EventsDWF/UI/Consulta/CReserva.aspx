<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CReserva.aspx.cs" Inherits="EventsDWF.UI.Consulta.CReserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	 <script type="text/javascript">
        function ShowReporte(title) {
            $("#ModalReporte .modal-title").html(title);
            $("#ModalReporte").modal("show");
        }
    </script>
    <%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
	<div class="container">
		<div style="max-width: 1000px;">
			<div class="panel panel-primary">
				<div class="panel-heading h4 text-primary text-center">
					Consulta Reserva
				</div>
				<div class="panel-body">

					<div>
						<div class="col-md-2">
							<asp:DropDownList ID="BuscarPorDropDownList" runat="server" CssClass="form-control input-sm">
								<asp:ListItem>Todos</asp:ListItem>
								<asp:ListItem>ReservaID</asp:ListItem>
								<asp:ListItem>Nombre</asp:ListItem>
								<asp:ListItem>Combo</asp:ListItem>
								<asp:ListItem>Precio</asp:ListItem>
							</asp:DropDownList>
						</div>

						<%--Criterio--%>
						<div class="col-md-6">
							<asp:TextBox ID="FiltroTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
						</div>
						<div class="col-md-4">
							<asp:Button ID="BuscarButton" runat="server" CssClass="btn btn-success input-sm" Text="Buscar" OnClick="BuscarButton_Click" />
						</div>
					</div>
					<%--Selercionar solo por fecha--%>
					<div class="input-group mb-3">
						<div class="input-group-prepend">
							<asp:CheckBox AutoPostBack="true" Checked="true" ID="fechaCheckBox" runat="server" Text="Filtrar solo por fecha" OnCheckedChanged="fechaCheckBox_CheckedChanged1" />
						</div>
					</div>

					<%--Rango fecha--%>
					<div class="form-row ">
						<div class="form-group ">
							<asp:Label Text="Desde" runat="server" />
							<asp:TextBox ID="DesdeTextBox" CssClass="form-control input-group" TextMode="Date" runat="server" />
						</div>
						<div class="form-group ">
							<asp:Label Text="Hasta" runat="server" />
							<asp:TextBox ID="HastaTextBox" CssClass="form-control input-group" TextMode="Date" runat="server" />
						</div>
					</div>
					<hr />
					<%--GRID--%>
					<div class="row">

						<asp:GridView ID="DatosGridView"
							runat="server"
							CssClass="table table-condensed table-bordered table-responsive"
							CellPadding="4" ForeColor="#333333" GridLines="None">

							<AlternatingRowStyle BackColor="White" />
							<Columns>
								<asp:HyperLinkField ControlStyle-ForeColor="blue"
									DataNavigateUrlFields="ReservaId"
									DataNavigateUrlFormatString="~/UI/Registros/RReserva.aspx?Id={0}"
									Text="Editar"></asp:HyperLinkField>
							</Columns>
							<HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
							<RowStyle BackColor="#EFF3FB" />
						</asp:GridView>
					</div>
					<hr />
					 <%--Imprimir--%>
            <div class="card-footer">
                <div class="justify-content-start">
                    <div class="form-group" style="display: inline-block">
                        <button type="button" class="btn btn-warning mt-4" data-toggle="modal" data-target=".bd-example-modal-lg">Imprimir</button>
                    </div>
                </div>
            </div>
					   <!-- Modal para mi Reporte.// -->
            <div class="modal fade bd-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
               <div class="modal-dialog" style="max-width: 1000px!important; min-width: 500px!important">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Reporte Para Reserva</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <%--Viewer--%>
                            <rsweb:ReportViewer ID="ReportReserva" runat="server" ProcessingMode="Local" Height="600px" Width="500px">
                                <ServerReport ReportPath="" ReportServerUrl="" />
                            </rsweb:ReportViewer>
                        </div>
                        <div class="modal-footer">
                        </div>
                    </div>
                </div>
          </div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
