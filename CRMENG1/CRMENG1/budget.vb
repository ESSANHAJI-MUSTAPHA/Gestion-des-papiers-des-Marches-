Public Class budget

    Private Sub budget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'PlancontaDataSet.plan'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PlanTableAdapter.Fill(Me.PlancontaDataSet.plan)

    End Sub
End Class