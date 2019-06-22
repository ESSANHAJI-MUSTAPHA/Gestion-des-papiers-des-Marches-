Public Class login

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim n As Integer
        Dim nb As Integer

        If TextBox2.Text = "12345" Then

            If ProgressBar1.Value < ProgressBar1.Maximum Then
                ProgressBar1.Increment(100)
                Timer1.Enabled = False
                Index.Show()
                Me.Hide()
            End If

        Else : n += 1
            nb -= 1
            If n < 4 Then
                MessageBox.Show("Mot de passe Erroné! Il reste" & n & "Essais", "Erreur", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Else
                MessageBox.Show("Impossible de Continue", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Application.Exit()
            End If

        End If

       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        confirmation.Show()
    End Sub
End Class