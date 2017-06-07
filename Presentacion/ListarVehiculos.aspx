﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarVehiculos.aspx.cs" Inherits="Presentacion.ListarVehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
        <div class="form-group">
            <asp:GridView ID="gdvVehiculos" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" OnRowCommand="gdvVehiculos_RowCommand">

                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="vehiculoId" />
                    <asp:BoundField HeaderText="Dominio" DataField="vehiculoDominio" />
                    <asp:BoundField HeaderText="Año" DataField="vehiculoAnio" />
                    <asp:BoundField HeaderText="Modelo" DataField="modeloId" />
                    <asp:BoundField HeaderText="Chasis" DataField="vehiculoNumeroChasis" />
                    <asp:BoundField HeaderText="Motor" DataField="vehiculoNumeroMotor" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="Modificar" runat="server" CommandName="Modificar" CommandArgument='<%# Eval("vehiculoId")%>' Text="Modificar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>