@Code
    ViewData("Title") = "Teams"
    Dim teams = WineDraw.Foundation.TeamCollection.FetchTeams
End Code


    <div class="container">
        <div class="row">
            <div class="col-lg-12 text-center">
                <div class="intro-text">
                    <h2>@ViewData("Title")</h2>
                    <hr class="star-primary">
                </div>
            </div>
        </div>
        <div class="row row-cols-1 row-cols-md-2 row-cols-lg-3 g-4">
          
            @For Each t As WineDraw.Foundation.Team In teams
                @<div class="col">
			<div class="card">
                        <div class="card-header">
			    @If t.IsEliminated Then
                                @<h4 class="card-title text-danger">Team @t.TeamNum</h4>
                            Else
                                @<h4 class="card-title">Team @t.TeamNum</h4>
                            End If
                        </div>
                        <div class="card-body">
                          <div class="table-responsive card-text">
                              <table class="table mb-0">
                                  @For Each p As WineDraw.Foundation.Player In t.Players
                                    If p.isElim Then
                                      @<tr>
                                          <td class="text-danger">@p.Id</td>
                                          <td class="text-danger">@p.Name</td>
                                          <td class="text-danger">@p.elimDateStr</td>
                                        </tr>
                                    Else
                                        @<tr>
                                          <td>@p.Id</td>
                                          <td>@p.Name</td>
                                          <td>@p.elimDateStr</td>
                                        </tr>
                                    End If
                                  Next
                              </table>
                          </div>
                    </div>
                </div>
		</div>
            Next
        </div>
    </div>
