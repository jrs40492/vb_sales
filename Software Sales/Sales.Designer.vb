<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpQuantitySold = New System.Windows.Forms.GroupBox()
        Me.grandTotal = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblPackageCTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPackageBTotal = New System.Windows.Forms.Label()
        Me.lblPackageATotal = New System.Windows.Forms.Label()
        Me.txtPackageC = New System.Windows.Forms.TextBox()
        Me.txtPackageB = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPackageA = New System.Windows.Forms.TextBox()
        Me.lblPackageC = New System.Windows.Forms.Label()
        Me.lblPackageB = New System.Windows.Forms.Label()
        Me.lblPackageA = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpQuantitySold.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(18, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(775, 127)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sales"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpQuantitySold
        '
        Me.grpQuantitySold.Controls.Add(Me.grandTotal)
        Me.grpQuantitySold.Controls.Add(Me.lblGrandTotal)
        Me.grpQuantitySold.Controls.Add(Me.lblPackageCTotal)
        Me.grpQuantitySold.Controls.Add(Me.btnClear)
        Me.grpQuantitySold.Controls.Add(Me.lblPackageBTotal)
        Me.grpQuantitySold.Controls.Add(Me.lblPackageATotal)
        Me.grpQuantitySold.Controls.Add(Me.txtPackageC)
        Me.grpQuantitySold.Controls.Add(Me.txtPackageB)
        Me.grpQuantitySold.Controls.Add(Me.btnCalculate)
        Me.grpQuantitySold.Controls.Add(Me.txtPackageA)
        Me.grpQuantitySold.Controls.Add(Me.lblPackageC)
        Me.grpQuantitySold.Controls.Add(Me.lblPackageB)
        Me.grpQuantitySold.Controls.Add(Me.lblPackageA)
        Me.grpQuantitySold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpQuantitySold.Location = New System.Drawing.Point(19, 142)
        Me.grpQuantitySold.Margin = New System.Windows.Forms.Padding(6)
        Me.grpQuantitySold.Name = "grpQuantitySold"
        Me.grpQuantitySold.Padding = New System.Windows.Forms.Padding(6)
        Me.grpQuantitySold.Size = New System.Drawing.Size(775, 417)
        Me.grpQuantitySold.TabIndex = 3
        Me.grpQuantitySold.TabStop = False
        Me.grpQuantitySold.Text = "Quantity Sold"
        '
        'grandTotal
        '
        Me.grandTotal.AutoSize = True
        Me.grandTotal.Location = New System.Drawing.Point(28, 289)
        Me.grandTotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.grandTotal.Name = "grandTotal"
        Me.grandTotal.Size = New System.Drawing.Size(197, 37)
        Me.grandTotal.TabIndex = 13
        Me.grandTotal.Text = "Grand Total:"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrandTotal.Location = New System.Drawing.Point(450, 289)
        Me.lblGrandTotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(217, 44)
        Me.lblGrandTotal.TabIndex = 12
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPackageCTotal
        '
        Me.lblPackageCTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageCTotal.Location = New System.Drawing.Point(450, 221)
        Me.lblPackageCTotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPackageCTotal.Name = "lblPackageCTotal"
        Me.lblPackageCTotal.Size = New System.Drawing.Size(217, 44)
        Me.lblPackageCTotal.TabIndex = 11
        Me.lblPackageCTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(481, 355)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(186, 50)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPackageBTotal
        '
        Me.lblPackageBTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageBTotal.Location = New System.Drawing.Point(450, 143)
        Me.lblPackageBTotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPackageBTotal.Name = "lblPackageBTotal"
        Me.lblPackageBTotal.Size = New System.Drawing.Size(217, 44)
        Me.lblPackageBTotal.TabIndex = 10
        Me.lblPackageBTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPackageATotal
        '
        Me.lblPackageATotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageATotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPackageATotal.Location = New System.Drawing.Point(450, 61)
        Me.lblPackageATotal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPackageATotal.Name = "lblPackageATotal"
        Me.lblPackageATotal.Size = New System.Drawing.Size(217, 44)
        Me.lblPackageATotal.TabIndex = 9
        Me.lblPackageATotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPackageC
        '
        Me.txtPackageC.Location = New System.Drawing.Point(238, 222)
        Me.txtPackageC.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPackageC.Name = "txtPackageC"
        Me.txtPackageC.Size = New System.Drawing.Size(186, 44)
        Me.txtPackageC.TabIndex = 3
        '
        'txtPackageB
        '
        Me.txtPackageB.Location = New System.Drawing.Point(238, 141)
        Me.txtPackageB.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPackageB.Name = "txtPackageB"
        Me.txtPackageB.Size = New System.Drawing.Size(186, 44)
        Me.txtPackageB.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(238, 355)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(186, 50)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtPackageA
        '
        Me.txtPackageA.Location = New System.Drawing.Point(238, 61)
        Me.txtPackageA.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPackageA.Name = "txtPackageA"
        Me.txtPackageA.Size = New System.Drawing.Size(186, 44)
        Me.txtPackageA.TabIndex = 1
        '
        'lblPackageC
        '
        Me.lblPackageC.AutoSize = True
        Me.lblPackageC.Location = New System.Drawing.Point(45, 222)
        Me.lblPackageC.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPackageC.Name = "lblPackageC"
        Me.lblPackageC.Size = New System.Drawing.Size(182, 37)
        Me.lblPackageC.TabIndex = 4
        Me.lblPackageC.Text = "Package C:"
        '
        'lblPackageB
        '
        Me.lblPackageB.AutoSize = True
        Me.lblPackageB.Location = New System.Drawing.Point(45, 141)
        Me.lblPackageB.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPackageB.Name = "lblPackageB"
        Me.lblPackageB.Size = New System.Drawing.Size(180, 37)
        Me.lblPackageB.TabIndex = 2
        Me.lblPackageB.Text = "Package B:"
        '
        'lblPackageA
        '
        Me.lblPackageA.AutoSize = True
        Me.lblPackageA.Location = New System.Drawing.Point(45, 64)
        Me.lblPackageA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPackageA.Name = "lblPackageA"
        Me.lblPackageA.Size = New System.Drawing.Size(181, 37)
        Me.lblPackageA.TabIndex = 0
        Me.lblPackageA.Text = "Package A:"
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(18, 571)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(564, 50)
        Me.lblTime.TabIndex = 5
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(607, 571)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(186, 50)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 640)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.grpQuantitySold)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Sales"
        Me.Text = "Package Sales"
        Me.grpQuantitySold.ResumeLayout(False)
        Me.grpQuantitySold.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpQuantitySold As GroupBox
    Friend WithEvents lblPackageC As Label
    Friend WithEvents lblPackageB As Label
    Friend WithEvents lblPackageA As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtPackageC As TextBox
    Friend WithEvents txtPackageB As TextBox
    Friend WithEvents txtPackageA As TextBox
    Friend WithEvents lblPackageCTotal As Label
    Friend WithEvents lblPackageBTotal As Label
    Friend WithEvents lblPackageATotal As Label
    Friend WithEvents grandTotal As Label
    Friend WithEvents lblGrandTotal As Label
End Class
