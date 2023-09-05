Public Class Login
    Private Sub btnSubmit_EventClick(sender As Object, e As MouseEventArgs) Handles btnSubmit.MouseClick
        ' Hide the current form
        Me.Hide()
        ' Show the second form
        Dashboard.Show()
    End Sub

End Class
