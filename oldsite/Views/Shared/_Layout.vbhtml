@Code
'Dim jokeOfTheDay = WineDraw.Foundation.Joke.FetchLatest
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="ICON" href="~/Images/wineswirly.jfif"  />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css">
    <title>@ViewBag.Title - Mackey Wine Draw</title>
    @Styles.Render("~/Content/css")

</head>
<body style="background-color: #600;color: white;">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <div class="container">

<div class="container col-xxl-8 px-4 py-5">
<div class="card rounded-3" style="width: 100%;margin-bottom: 25px;">
   <div class="card-header">
   	@DateTime.Now.Year Mackey Wine Draw and Party
	</div>
  <img src="~/Images/banner.jpg" class="card-img-top" alt="Wine Bottles">
  <div class="card-body">
    <div class="d-grid gap-4 d-md-flex justify-content-md-center">
          <a class="btn btn-primary" href="../Home/Recent">Eliminated</a>
          <a class="btn btn-primary" href="../Home/Teams">Teams</a>
          <a class="btn btn-primary" href="../Home/Rules">Rules</a>
          <a class="btn btn-primary" href="../Home/Party">Party</a>
          <a class="btn btn-primary" href="../Home/Winners">Previous Winners</a>
        </div>
  </div>       
  </div> 

        <div class="container body-content">
            @RenderBody()
        </div>
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year </p>
        </footer>

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
    </div>
</body>
</html>
