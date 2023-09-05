<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblDashboard = New Label()
        btnManageFlight = New Button()
        lblBACK = New Label()
        btnManagePassenger = New Button()
        btnTicketBooking = New Button()
        btnTicketCancellation = New Button()
        SuspendLayout()
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblDashboard.Location = New Point(373, 85)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(251, 50)
        lblDashboard.TabIndex = 0
        lblDashboard.Text = "DASHBOARD"
        ' 
        ' btnManageFlight
        ' 
        btnManageFlight.Location = New Point(373, 213)
        btnManageFlight.Name = "btnManageFlight"
        btnManageFlight.Size = New Size(245, 58)
        btnManageFlight.TabIndex = 1
        btnManageFlight.Text = "Manage Flight"
        btnManageFlight.UseVisualStyleBackColor = True
        ' 
        ' lblBACK
        ' 
        lblBACK.AutoSize = True
        lblBACK.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblBACK.Location = New Point(895, 9)
        lblBACK.Name = "lblBACK"
        lblBACK.Size = New Size(127, 40)
        lblBACK.TabIndex = 0
        lblBACK.Text = "<- BACK"
        ' 
        ' btnManagePassenger
        ' 
        btnManagePassenger.Location = New Point(373, 296)
        btnManagePassenger.Name = "btnManagePassenger"
        btnManagePassenger.Size = New Size(245, 58)
        btnManagePassenger.TabIndex = 1
        btnManagePassenger.Text = "Manage Passenger"
        btnManagePassenger.UseVisualStyleBackColor = True
        ' 
        ' btnTicketBooking
        ' 
        btnTicketBooking.Location = New Point(373, 379)
        btnTicketBooking.Name = "btnTicketBooking"
        btnTicketBooking.Size = New Size(245, 58)
        btnTicketBooking.TabIndex = 1
        btnTicketBooking.Text = "Ticket Booking"
        btnTicketBooking.UseVisualStyleBackColor = True
        ' 
        ' btnTicketCancellation
        ' 
        btnTicketCancellation.Location = New Point(373, 462)
        btnTicketCancellation.Name = "btnTicketCancellation"
        btnTicketCancellation.Size = New Size(245, 58)
        btnTicketCancellation.TabIndex = 1
        btnTicketCancellation.Text = "Ticket Cancellation"
        btnTicketCancellation.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1034, 586)
        Controls.Add(btnTicketCancellation)
        Controls.Add(btnTicketBooking)
        Controls.Add(btnManagePassenger)
        Controls.Add(btnManageFlight)
        Controls.Add(lblBACK)
        Controls.Add(lblDashboard)
        Name = "Dashboard"
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDashboard As Label
    Friend WithEvents btnManageFlight As Button
    Friend WithEvents lblBACK As Label
    Friend WithEvents btnManagePassenger As Button
    Friend WithEvents btnTicketBooking As Button
    Friend WithEvents btnTicketCancellation As Button
End Class
