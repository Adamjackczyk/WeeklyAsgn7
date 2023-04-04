Public Class Form1

    Private decPerSong As Decimal = 2.99D
    Private decPerHour As Decimal = 8.99D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCost.Text = ""
        lblShowCost.Text = ""
    End Sub

    Private Sub cboUserChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUserChoice.SelectedIndexChanged
        If cboUserChoice.SelectedItem IsNot Nothing Then
            Dim selectedValue As String = cboUserChoice.SelectedItem.ToString()
            lblHourlyOrSong.Visible = True
            txtNum.Visible = True
            btnTotalCost.Visible = True
            BtnClear.Visible = True
            txtNum.Focus()
            If selectedValue = "Karaoke Room ($8.99/hour)" Then
                lblHourlyOrSong.Text = "Number of hours?"
            ElseIf selectedValue = "Individual Song ($2.99/song)" Then
                lblHourlyOrSong.Text = "Number of songs?"
            End If
        Else
            lblHourlyOrSong.Visible = False
            txtNum.Visible = False
            btnTotalCost.Visible = False
            BtnClear.Visible = False
        End If
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim selectedValue As String = cboUserChoice.SelectedItem.ToString()

        If selectedValue = "Karaoke Room ($8.99/hour)" Then
            Try
                Dim hours As Integer = CInt(txtNum.Text)
                Dim totalCost As Decimal = decPerHour * hours
                lblTotalCost.Text = "Total cost of room: "
                lblShowCost.Text = totalCost.ToString("C")
                lblTotalCost.Visible = True
                lblShowCost.Visible = True
            Catch ex As Exception
                MessageBox.Show("Please enter a valid number of hours.")
            End Try
        ElseIf selectedValue = "Individual Song ($2.99/song)" Then
            Try
                Dim songs As Integer = CInt(txtNum.Text)
                Dim totalCost As Decimal = decPerSong * songs
                lblTotalCost.Text = "Total Cost of songs: "
                lblShowCost.Text = totalCost.ToString("C")
                lblTotalCost.Visible = True
                lblShowCost.Visible = True
            Catch ex As Exception
                MessageBox.Show("Please enter a valid number of songs.")
            End Try
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        cboUserChoice.SelectedItem = Nothing
        txtNum.Text = ""
        lblTotalCost.Visible = False
        lblShowCost.Visible = False
    End Sub
End Class
