Public Class Sales
    Const packageACost As Integer = 99
    Const packageBCost As Integer = 199
    Const packageCCost As Integer = 299

    Function validatInput(tBox As TextBox, label As String)
        Dim stringVal As String = tBox.Text
        Dim amount As Integer = 0

        If IsNumeric(stringVal) Then
            amount = CInt(stringVal)
        Else
            Return "Package " & label & " must be less than 0"
        End If

        If amount < 0 Then
            Return "Package " & label & " must be less than 0"
        End If

        Return amount
    End Function

    Function calculateDiscount(tBox As TextBox, cost As Integer, label As String)
        Dim amount = validatInput(tBox, label)

        If Not IsNumeric(amount) Then
            MessageBox.Show(amount)
            Return False
        End If

        ' Default to 1 (no discount/100% cost)
        Dim discountPercent As Decimal = 1

        Select Case amount
            Case 10 To 19
                discountPercent = 0.2
            Case 20 To 49
                discountPercent = 0.3
            Case 50 To 99
                discountPercent = 0.4
            Case > 100
                discountPercent = 0.5
        End Select

        ' Total cost of item before discount
        Dim total As Decimal = amount * cost

        ' Get discount amount
        Dim discount As Decimal = total * discountPercent

        Return total - discount
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear inputs
        txtPackageA.Clear()
        txtPackageB.Clear()
        txtPackageC.Clear()

        ' Clear total boxes
        lblPackageATotal.Text = ""
        lblPackageBTotal.Text = ""
        lblPackageCTotal.Text = ""
        lblGrandTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close form
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculate discount for each package
        Dim finalA As Decimal = calculateDiscount(txtPackageA, packageACost, "A")
        Dim finalB As Decimal = calculateDiscount(txtPackageB, packageBCost, "A")
        Dim finalC As Decimal = calculateDiscount(txtPackageC, packageCCost, "A")

        'Display Totals
        lblPackageATotal.Text = finalA.ToString("C")
        lblPackageBTotal.Text = finalB.ToString("C")
        lblPackageCTotal.Text = finalC.ToString("C")

        Dim grandTotal As Decimal = finalA + finalB + finalC

        lblGrandTotal.Text += grandTotal.ToString("C")
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTime.Text = "Jacob Swanson " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
End Class