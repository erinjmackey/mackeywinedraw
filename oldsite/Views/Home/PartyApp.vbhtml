@Code
    ViewData("Title") = "Standings"
    Dim teams = WineDraw.Foundation.TeamCollection.FetchTeams
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="ICON" href="~/Images/favicon.ico" type="image/ico" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <title>@ViewBag.Title - Mackey Wine Draw</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <script>
      setInterval(function(){location.reload()}, 60000)
    </script>
    <style>
        body {
            font-size: 16px;
            font-weight: bold;
        }
        .card-deck .card {
            background-color: white;
            min-width: 15%;
            max-width: 15%;
            margin-top: 0;
            margin-bottom: 5px;
            margin-left: 5px;
            margin-right: 0;
        }
        .card-header{
            text-align:center;
            font-size:large;
        }
        .list-group {
            padding-left: 0;
            margin-bottom: 0;
        }
        .list-group-flush>.list-group-item {
            position: relative;
            display: block;
            padding: 5px 5px;
            margin-bottom: -1px;
            background-color: transparent;
            border: 1px solid transparent;
        }
		.card{
			margin-bottom: 10px;
		}
		.card-body{
			padding-left: 10px;
		}
    </style>
</head>
<body style="background-color:#600; margin-left:15px; margin-right:15px;">
  <h1 style="color:white;text-align: center;margin-top:55px;margin-bottom:30px;">2023 Mackey Wine Draw</h1>
  <div class="row row-cols-auto justify-content-center">
  @For Each t As WineDraw.Foundation.Team In teams
    @<div class="col" style="width: 11%;padding:1px;">
      <div class="card" >
        @If t.IsEliminated Then
         @<div class="card-header text-danger">Team @t.TeamNum</div>
        Else
         @<div class="card-header">Team @t.TeamNum</div>
       End If
        @If t.IsEliminated Then
          @<div class="card-body" style="background-image: url('https://mackeywinedraw.azurewebsites.net/images/eliminated.png');background-repeat: no-repeat;background-size:contain; background-position:center;">
            <ul class="list-group list-group-flush">
             @For Each p As WineDraw.Foundation.Player In t.Players
               If p.isElim Then
                 @<li class="list-group-item text-danger" style="text-decoration: line-through;">@p.Name</li>
               Else
                 @<li class="list-group-item">   @p.Name</li>
               End If
             Next
           </ul>
         </div>
        Else
          @<div class="card-body">
            <ul class="list-group list-group-flush">
             @For Each p As WineDraw.Foundation.Player In t.Players
               If p.isElim Then
                 @<li class="list-group-item text-danger" style="text-decoration: line-through;">@p.Name</li>
               Else
                 @<li class="list-group-item">   @p.Name</li>
               End If
             Next
           </ul>
         </div>
        End If

       </div>
      </div>
    Next
  </div>


    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

</body>
</html>
