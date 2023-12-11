@Code
    ViewData("Title") = "Admin"
End Code

<div class="container">
    <div class="row">
        <div class="col-lg-12 text-center">
            <div class="intro-text">
                <h2>@ViewBag.Title</h2>
                <hr class="star-primary">
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col">
          <div>
              <p>Eliminate by player id</p>
              @If IsPost Then
                  If Request("password") = "golf4fun" Then
                      Dim elims = WineDraw.Foundation.Players.EliminateMultiple(Request("playerId"))
                      If elims.Count > 0 Then
                         @<p>
                          @For Each e In elims
                              @e @<br/>
                          Next
                          </p>
                          End If
                  Else
                      @<p>Invalid password</p>
                  End If
              End If
              <form method="post" action="">
                  <input type="text" class="form-control" name="playerId" value="" placeholder="Ticket Numbers (e.g. 1,3,7)"/>
                  <input type="password" class="form-control" name="password" value="" placeholder="password"/>
                  <input type="submit" value="Submit" class="btn btn-default" />
              </form>
          </div>
        </div>
        <div>
            <p>Eliminate random </p>
            @If IsPost Then
                If Request("password") = "golf4fun" Then
                    Dim elims = WineDraw.Foundation.Players.EliminateRandom(Request("quantity"))
                    If elims.Count > 0 Then
                        @<p>
                            @For Each e In elims
                                @e @<br />
                            Next
                        </p>
                    End If
                Else
                    @<p>Invalid password</p>
                End If
            End If
            <form method="post" action="">
                <input type="number" class="form-control" name="quantity" value="" placeholder="qty to eliminate" />
                <input type="password" class="form-control" name="password" value="" placeholder="password" />
                <input type="submit" value="Submit" class="btn btn-default" />
            </form>
        </div>
    </div>
    <div class="row">
        <a class="navbar-brand" href="../Home/Joke">Submit Joke</a>
    </div>
</div>
