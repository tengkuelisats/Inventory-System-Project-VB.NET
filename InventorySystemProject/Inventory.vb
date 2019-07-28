Public Class Inventory

    Private Sub TudungBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TudungBindingNavigatorSaveItem.Click
    'Private Sub TudungBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TudungBindingNavigatorSaveItem.Click
        'The coding to connect the database into the system
        Me.Validate()
        Me.TudungBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InventorySystemDatabase2DataSet)

    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Private Sub Inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'InventorySystemDatabase2DataSet.Tudung' table. 
        'You can move, or remove it, as needed.
        Me.TudungTableAdapter.Fill(Me.InventorySystemDatabase2DataSet.Tudung)

        ComboBoxOrderMade.Items.Add("Select Course")
        ComboBoxOrderMade.Items.Add("Whatsapp")
        ComboBoxOrderMade.Items.Add("Instore Order")
        ComboBoxOrderMade.Items.Add("Online Order")

        ComboBoxPayment.Items.Add("Select Type")
        ComboBoxPayment.Items.Add("Cash Deposit Machine")
        ComboBoxPayment.Items.Add("Cash")
        ComboBoxPayment.Items.Add("Master Card")
        ComboBoxPayment.Items.Add("Debit Card")
        ComboBoxPayment.Items.Add("Visa Vard")

        ListBoxTudung.Items.Add("Shawl Chiffon")
        ListBoxTudung.Items.Add("Bawal Plain")
        ListBoxTudung.Items.Add("Shawl Bubble")
        ListBoxTudung.Items.Add("Bawal Crepe")
        ListBoxTudung.Items.Add("Shawl Keknis")
        ListBoxTudung.Items.Add("Bawal Cotton")

        ComboBoxOrderMade.Text = "Select Course"
        ComboBoxPayment.Text = "Select Type"

        ComboBoxColor.Items.Add("Pink")
        ComboBoxColor.Items.Add("Baby Blue")
        ComboBoxColor.Items.Add("Beige")
        ComboBoxColor.Items.Add("Cream")
        ComboBoxColor.Items.Add("Turqoise")

        ComboBoxQuantity.Items.Add("1")
        ComboBoxQuantity.Items.Add("2")
        ComboBoxQuantity.Items.Add("3")
        ComboBoxQuantity.Items.Add("4")

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        'Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        'The coding to exit the system
        Dim exitMessage As DialogResult
        exitMessage = MessageBox.Show("Do you want to exit ?", "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If exitMessage = DialogResult.Yes Then
            Close()
        End If

    End Sub

    Private Sub ButtonUpdateData_Click(sender As Object, e As EventArgs) Handles ButtonUpdateData.Click
        'Private Sub ButtonUpdateData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdateData.Click
        'The coding to update the database
        On Error GoTo errsave
        TudungBindingSource.EndEdit()
        TudungTableAdapter.Update(InventorySystemDatabase2DataSet)
        MessageBox.Show("Save")

errsave:
        Exit Sub

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        'Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        'The coding to clear data in the system
        Customer_IDTextBox.Text = ""
        First_NameTextBox.Text = ""
        SurnameTextBox.Text = ""
        ComboBoxOrderMade.Text = "Select Course"
        ComboBoxPayment.Text = "Select Type"
        ComboBoxColor.Text = "Select Color"
        ComboBoxQuantity.Text = "Select Quantity"
        PriceTextBox.Text = ""
        ListBoxTudung.ClearSelected()

    End Sub

    Private Sub ButtonAddMore_Click(sender As Object, e As EventArgs) Handles ButtonAddMore.Click
        'Private Sub ButtonAddMore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddMore.Click
        'The coding to add data into the database
        TudungBindingSource.AddNew()

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        'Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        'The coding to delete data from the database
        TudungBindingSource.RemoveCurrent()

    End Sub

    Private Sub Quantity()

        Dim totalprice As Integer
        Dim quantity As Integer

        quantity = ComboBoxQuantity.SelectedItem
        totalprice = quantity * 10

        PriceTextBox.Text = totalprice

    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalculate.Click
        'The coding of the formula to calculate the total price
        Quantity()

    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'The coding for the Search feature in the system. 
        'This feature allows the admin to search Surname as the keyword to display data.
        Try
            Me.TudungTableAdapter.Surname(Me.InventorySystemDatabase2DataSet.Tudung)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        'The coding to change the Font
        With FontDialog1
            .ShowDialog()
            Me.LabelTitle.Font = .Font
        End With

    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        'The coding to change the colour of the backcolour
        With TitleColorDialog
            .ShowDialog()
            Me.LabelTitle.BackColor = .Color
        End With

    End Sub

    Private Sub Surname2ToolStripButton_Click(sender As Object, e As EventArgs) Handles Surname2ToolStripButton.Click
        Try
            Me.TudungTableAdapter.Surname2(Me.InventorySystemDatabase2DataSet.Tudung, SurnameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SurnameToolStripTextBox_TextChanged(sender As Object, e As EventArgs) Handles SurnameToolStripTextBox.TextChanged
        Try
            Me.TudungTableAdapter.Surname2(Me.InventorySystemDatabase2DataSet.Tudung, SurnameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim exitMessage As DialogResult
        exitMessage = MessageBox.Show("Do you want to exit ?", "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If exitMessage = DialogResult.Yes Then
            Close()
        End If

    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        'The coding for First button
        Me.TudungBindingSource.MoveFirst()

    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        'The coding for Last button
        Me.TudungBindingSource.MoveLast()

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        'The coding for Next button
        Me.TudungBindingSource.MoveNext()

    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        'the coding for Previous button
        Me.TudungBindingSource.MovePrevious()

    End Sub

End Class