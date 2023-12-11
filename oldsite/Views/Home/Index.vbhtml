@Code
    ViewData("Title") = "Home"
    Dim players = WineDraw.Foundation.Players.GetEliminated(True)
    Dim jokeOfTheDay = WineDraw.Foundation.Jokes.FetchLatest
End Code

<div class="container">
    <div class="row">
        <div class="col text-center">
            <div class="card">
                <div class="card-header">
                  <h4>Latest Names Drawn</h4>
                </div>
                <div class="card-body">
                  <table class="table">
                      <tr><th>#</th><th>Name</th><th>Team</th><th>Drawn On</th></tr>
                      @For Each p In players
                          @<tr><td>@p.Id</td><td>@p.Name</td><td>@p.TeamNum</td><td>@p.elimDateStr</td></tr>
                      Next
                  </table>
                </div>
            </div>
        </div>
	<div class="col text-center">
            <div class="card">
                <div class="card-header">
                  <h4>@jokeOfTheDay.Title</h4>
                </div>
                <div class="card-body">
                  @jokeOfTheDay.Text
                </div>
            </div>
        </div>
    </div>
</div>
