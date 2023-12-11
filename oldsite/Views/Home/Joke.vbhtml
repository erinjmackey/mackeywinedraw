@Code
    ViewData("Title") = "Jokes"
    Dim jokes = WineDraw.Foundation.Jokes.Fetch
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
        <div class="col-md-6 col-md-offset-3">
            <h3>Submit Joke</h3>
            @If IsPost Then
                If Request("password") = "golf4fun" Then
                    If WineDraw.Foundation.Jokes.SubmitJoke(Request("title"), Request("joke")) Then
                        @<p>Joke is submitted</p>
                    Else
                        @<p>Submission failed</p>
                    End If
                Else
                    @<p>Invalid password</p>
                End If
            End If
            <form method="post" action="">
                <div class="form-group">
                    <input type="text" name="title" class="form-control" placeholder="Title" required>
                    <textarea class="form-control" name="joke" rows="3" placeholder="Joke Text" required></textarea>                    
                    <input placeholder="Password" type="password" class="form-control" name="password" value="" /><br />
                </div>
                <button type="submit" class="btn btn-default">Submit</button>
            </form>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12 text-center">
            <div class="intro-text">
                <hr class="star-primary">
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-8 col-lg-offset-2">
            @For Each j In jokes
		@<div class="card">
                <div class="card-header">
                  <h4>@j.Title</h4>
                </div>
                <div class="card-body">
                  @j.Text
                </div>
            </div>
            Next
        </div>
    </div>
</div>
