<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErroreGenerico.aspx.cs" Inherits="DemoAspx.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Errore Generico</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src='http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
</head>
<body>
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
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">Dropdown Menu
                        </a>
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

    <div class="container d-flex justify-content-center align-items-center" style="min-height: 100vh;">
        <div class="text-center">
            <img src="errore.png" alt="Errore" class="img-fluid" width="100" height="100">
            <p>Ups... Qualcosa è andato storto</p>
        </div>
    </div>
</body>
</html>
