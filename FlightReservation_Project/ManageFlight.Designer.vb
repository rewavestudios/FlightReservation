<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageFlight
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
        lblFlightCode = New Label()
        lvlSource = New Label()
        lblTakeOf = New Label()
        lblNoOfSeats = New Label()
        lvlDestinainon = New Label()
        tbFC = New TextBox()
        tbS = New TextBox()
        tbD = New TextBox()
        tbTof = New TextBox()
        tbNofS = New TextBox()
        HelpProvider1 = New HelpProvider()
        Button1 = New Button()
        btnInsert = New Button()
        btnUpdate = New Button()
        btnSearch = New Button()
        btnDelete = New Button()
        DataGridView1 = New DataGridView()
        tblFlightCode = New DataGridViewTextBoxColumn()
        tblSource = New DataGridViewTextBoxColumn()
        tblDestination = New DataGridViewTextBoxColumn()
        tblTakeOf = New DataGridViewTextBoxColumn()
        tblNoOfSeats = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblDashboard.Location = New Point(337, 55)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(320, 50)
        lblDashboard.TabIndex = 1
        lblDashboard.Text = "MANAGE FLIGHT"
        ' 
        ' lblFlightCode
        ' 
        lblFlightCode.AutoSize = True
        lblFlightCode.Location = New Point(12, 147)
        lblFlightCode.Name = "lblFlightCode"
        lblFlightCode.Size = New Size(71, 15)
        lblFlightCode.TabIndex = 2
        lblFlightCode.Text = "Flight Code:"
        ' 
        ' lvlSource
        ' 
        lvlSource.AutoSize = True
        lvlSource.Location = New Point(221, 147)
        lvlSource.Name = "lvlSource"
        lvlSource.Size = New Size(46, 15)
        lvlSource.TabIndex = 2
        lvlSource.Text = "Source:"
        ' 
        ' lblTakeOf
        ' 
        lblTakeOf.AutoSize = True
        lblTakeOf.Location = New Point(642, 147)
        lblTakeOf.Name = "lblTakeOf"
        lblTakeOf.Size = New Size(47, 15)
        lblTakeOf.TabIndex = 2
        lblTakeOf.Text = "Take of:"
        ' 
        ' lblNoOfSeats
        ' 
        lblNoOfSeats.AutoSize = True
        lblNoOfSeats.Location = New Point(847, 147)
        lblNoOfSeats.Name = "lblNoOfSeats"
        lblNoOfSeats.Size = New Size(73, 15)
        lblNoOfSeats.TabIndex = 2
        lblNoOfSeats.Text = "No. of Seats:"
        ' 
        ' lvlDestinainon
        ' 
        lvlDestinainon.AutoSize = True
        lvlDestinainon.Location = New Point(432, 147)
        lvlDestinainon.Name = "lvlDestinainon"
        lvlDestinainon.Size = New Size(73, 15)
        lvlDestinainon.TabIndex = 2
        lvlDestinainon.Text = "Destinainon:"
        ' 
        ' tbFC
        ' 
        tbFC.Location = New Point(12, 165)
        tbFC.MaxLength = 33000
        tbFC.Name = "tbFC"
        tbFC.Size = New Size(175, 23)
        tbFC.TabIndex = 3
        ' 
        ' tbS
        ' 
        tbS.Location = New Point(221, 165)
        tbS.MaxLength = 33000
        tbS.Name = "tbS"
        tbS.Size = New Size(175, 23)
        tbS.TabIndex = 3
        ' 
        ' tbD
        ' 
        tbD.Location = New Point(432, 165)
        tbD.MaxLength = 33000
        tbD.Name = "tbD"
        tbD.Size = New Size(175, 23)
        tbD.TabIndex = 3
        ' 
        ' tbTof
        ' 
        tbTof.Location = New Point(642, 165)
        tbTof.Name = "tbTof"
        tbTof.Size = New Size(175, 23)
        tbTof.TabIndex = 3
        ' 
        ' tbNofS
        ' 
        tbNofS.AcceptsTab = True
        tbNofS.Location = New Point(847, 165)
        tbNofS.Name = "tbNofS"
        tbNofS.Size = New Size(175, 23)
        tbNofS.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(200, 218)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(75, 23)
        btnInsert.TabIndex = 6
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(391, 218)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(587, 218)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(778, 218)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.CausesValidation = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {tblFlightCode, tblSource, tblDestination, tblTakeOf, tblNoOfSeats})
        DataGridView1.Location = New Point(12, 267)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1010, 307)
        DataGridView1.TabIndex = 7
        DataGridView1.Visible = False
        ' 
        ' tblFlightCode
        ' 
        tblFlightCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tblFlightCode.HeaderText = "FlightCode"
        tblFlightCode.Name = "tblFlightCode"
        ' 
        ' tblSource
        ' 
        tblSource.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tblSource.HeaderText = "Source"
        tblSource.Name = "tblSource"
        ' 
        ' tblDestination
        ' 
        tblDestination.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tblDestination.HeaderText = "Destination"
        tblDestination.Name = "tblDestination"
        ' 
        ' tblTakeOf
        ' 
        tblTakeOf.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tblTakeOf.HeaderText = "Take of"
        tblTakeOf.Name = "tblTakeOf"
        ' 
        ' tblNoOfSeats
        ' 
        tblNoOfSeats.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tblNoOfSeats.HeaderText = "No. of Seats"
        tblNoOfSeats.Name = "tblNoOfSeats"
        ' 
        ' ManageFlight
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1034, 586)
        Controls.Add(DataGridView1)
        Controls.Add(btnDelete)
        Controls.Add(btnSearch)
        Controls.Add(btnUpdate)
        Controls.Add(btnInsert)
        Controls.Add(Button1)
        Controls.Add(tbNofS)
        Controls.Add(tbTof)
        Controls.Add(tbD)
        Controls.Add(tbS)
        Controls.Add(tbFC)
        Controls.Add(lblNoOfSeats)
        Controls.Add(lblTakeOf)
        Controls.Add(lvlDestinainon)
        Controls.Add(lvlSource)
        Controls.Add(lblFlightCode)
        Controls.Add(lblDashboard)
        Name = "ManageFlight"
        Text = "ManageFlight"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblFlightCode As Label
    Friend WithEvents lvlSource As Label
    Friend WithEvents lblTakeOf As Label
    Friend WithEvents lblNoOfSeats As Label
    Friend WithEvents lvlDestinainon As Label
    Friend WithEvents tbFC As TextBox
    Friend WithEvents tbS As TextBox
    Friend WithEvents tbD As TextBox
    Friend WithEvents tbTof As TextBox
    Friend WithEvents tbNofS As TextBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tblFlightCode As DataGridViewTextBoxColumn
    Friend WithEvents tblSource As DataGridViewTextBoxColumn
    Friend WithEvents tblDestination As DataGridViewTextBoxColumn
    Friend WithEvents tblTakeOf As DataGridViewTextBoxColumn
    Friend WithEvents tblNoOfSeats As DataGridViewTextBoxColumn
End Class
