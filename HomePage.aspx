<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="DemoAspx.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Page</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src='http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>

    <script>
        function confirmDelete(id) {
            if (confirm("Sei sicuro di voler eliminare questo dipendente?")) {
                __doPostBack('btnDelete', id);
            }
        }
    </script>

</head>
<body class="bg-dark-subtle">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-/bQdsTh/da6pkI1MST/rWKFNjaCP5gBSY4sEBT38Q/9RBh9AH40zEOg7Hlq2THRZ" crossorigin="anonymous"></script>    


    <nav class="navbar navbar-expand-lg bg-body-tertiary bg-dark border-bottom border-bottom-dark" data-bs-theme="dark">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">DemoAspx</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavDropdown">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="HomePage.aspx">Elenco</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="AddDipendente.aspx">Aggiungi Dipendente</a>
                    </li>
                    <li class="nav-item dropdown" aria-labelledby="dropdownMenuButton">
                        <a class="nav-link dropdown-toggle" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Dropdown Menu</a>
                        <ul class="dropdown-menu">
                            <li><a class="dropdown-item" href="UpdateDipendente.aspx">Update Dipendente</a></li>
                            <li><a class="dropdown-item" href="GetDipendente.aspx">Get Dipendente</a></li>
                            <li><a class="dropdown-item" href="DeleteDipendente.aspx">Delete Dipendente</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <form id="form1" runat="server" class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <h1>Elenco Dipendenti</h1>
            </div>
            <div class="row text-center">
                <div class="align-items-center">
                    <asp:GridView ID="gvEmployees" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-dark-sbtle" OnRowCommand="gvEmployees_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="ID" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Cognome" HeaderText="Cognome" />
                            <asp:BoundField DataField="Eta" HeaderText="Età" />
                            <asp:TemplateField HeaderText="Azioni">
                                <ItemTemplate>
                                    <div class="align-items-center">
                                        <asp:Button ID="btnUpdate" runat="server" Text="Modifica" CommandName="Update_Dip" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-primary"  />
                                        <asp:Button ID="btnDelete" runat="server" Text="Elimina" CommandName="Delete_Dip" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-danger" OnClientClick='<%# "confirmDelete(" + Eval("Id") + "); return false;" %>' />
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
    </form>

</body>
</html>
