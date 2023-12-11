<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="test.aspx.vb" Inherits="WineDraw.test" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<!DOCTYPE html>
<script runat="server">
    Protected Overloads Sub Page_Load(sender As Object, e As EventArgs)
        Using cn As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("MyDbConn").ToString())
            Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) FROM Players", cn)
            cn.Open()
            Using dr As SqlDataReader = cmd.ExecuteReader(Data.CommandBehavior.CloseConnection)
                If dr.Read Then
                    Console.WriteLine("Test: " & dr(0).ToString)
                End If
            End Using
        End Using
            
    End Sub
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SQL Authentication</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
