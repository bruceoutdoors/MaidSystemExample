Public Class Form1

    Private Sub MaidBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MaidBindingNavigatorSaveItem.Click
        SaveDataGridViewChanges()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.Maid' table. You can move, or remove it, as needed.
        MaidTableAdapter.Fill(DBDataSet.Maid)
    End Sub

    Private Sub MaidDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MaidDataGridView.DataError
        e.ThrowException = False

        Dim txt As String
        txt = ("Validation Error in column '" &
                MaidDataGridView.Columns(e.ColumnIndex).HeaderText & "'." &
                vbCrLf & vbCrLf & e.Exception.Message)
        MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        e.Cancel = False
    End Sub

    Private Sub AddMaidBtn_Click(sender As Object, e As EventArgs) Handles AddMaidBtn.Click
        Try
            MaidTableAdapter.Insert(NameTxt.Text, AgeTxt.Text, PriceTxt.Text)
            ' Update the DataGridView:
            MaidTableAdapter.Fill(DBDataSet.Maid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DelRowBtn_Click(sender As Object, e As EventArgs) Handles DelRowBtn.Click
        For Each row As DataGridViewRow In MaidDataGridView.SelectedRows
            MaidDataGridView.Rows.RemoveAt(row.Index)
        Next

        ' Update the TableAdapter:
        Try
            SaveDataGridViewChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PeanutBtn_Click(sender As Object, e As EventArgs) Handles PeanutBtn.Click
        For Each row As DataGridViewRow In MaidDataGridView.SelectedRows
            Try
                ' 0 here is the column index. Alternatively you can use name which you can
                ' set in DataGridView Tasks-> Edit Columns... -> Column Bound Type -> Design -> Name
                row.Cells(0).Value = "Peanut"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next

        Dim i As Integer
        Try
            i = SaveDataGridViewChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Displays number of rows updated.
        MessageBox.Show("no of rows updated: " & i)
    End Sub

    ' returns the number of rows updated
    Private Function SaveDataGridViewChanges()
        Validate()
        MaidBindingSource.EndEdit()
        Return TableAdapterManager.UpdateAll(DBDataSet)
    End Function

    Private Sub DelPeanutBtn_Click(sender As Object, e As EventArgs) Handles DelPeanutBtn.Click
        Try
            MaidTableAdapter.DeleteByNameQuery("Peanut")
            ' Update the DataGridView:
            MaidTableAdapter.Fill(DBDataSet.Maid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Console.WriteLine(MaidTableAdapter.ScalarQuery() & " maids remaining...")
    End Sub
End Class
