@Code
    ViewData("Title") = "Eliminated"
    Dim recentlyEliminated = WineDraw.Foundation.Players.GetEliminated(False)
End Code

<div class="container">
    <div class="row">
        <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1 col-sm-12 text-center">
            <div class="panel panel-default">
                <div class="panel-heading"><h4>@ViewData("Title")</h4></div>
                <table class="table">
                    <tr><th>#</th><th>Name</th><th>Team</th><th>Eliminated On</th></tr>
                    @For Each p In recentlyEliminated
                        @<tr><td>@p.Id</td><td>@p.Name</td><td>@p.TeamNum</td><td>@p.elimDateStr</td></tr>
                    Next
                </table>
            </div>
        </div>
    </div>
</div>
   
