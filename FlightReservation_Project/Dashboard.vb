Public Class Dashboard
    Private Sub btnManageFlight_EventClick(sender As Object, e As MouseEventArgs) Handles btnManageFlight.MouseClick
        ' Hide the Dashboard form
        Me.Hide()
        ' Show the ManageFlight form
        ManageFlight.Show()
    End Sub

    Private Sub btnManagePassenger_EventClick(sender As Object, e As MouseEventArgs) Handles btnManagePassenger.MouseClick
        ' Hide the Dashboard form
        Me.Hide()
        ' Show the ManagePassenger form
        ManagePassenger.Show()
    End Sub

    Private Sub BtnTicketBooking_EventClick(sender As Object, e As MouseEventArgs) Handles btnTicketBooking.MouseClick
        ' Hide the Dashboard form
        Me.Hide()
        ' Show the TicketBooking form
        TicketBooking.Show()
    End Sub

    Private Sub btnTicketCancellation_EventClick(sender As Object, e As MouseEventArgs) Handles btnTicketCancellation.MouseClick
        ' Hide the Dashboard form
        Me.Hide()
        ' Show the TicketCancellation form
        TicketCancellation.Show()
    End Sub
End Class