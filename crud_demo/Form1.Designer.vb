<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextAge = New System.Windows.Forms.TextBox()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(12, 12)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(147, 60)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'TextName
        '
        Me.TextName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextName.Location = New System.Drawing.Point(88, 90)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(262, 20)
        Me.TextName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'TextAge
        '
        Me.TextAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAge.Location = New System.Drawing.Point(88, 130)
        Me.TextAge.Name = "TextAge"
        Me.TextAge.Size = New System.Drawing.Size(262, 20)
        Me.TextAge.TabIndex = 6
        '
        'TextEmail
        '
        Me.TextEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextEmail.Location = New System.Drawing.Point(88, 168)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(262, 20)
        Me.TextEmail.TabIndex = 7
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(12, 213)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(147, 60)
        Me.CreateButton.TabIndex = 8
        Me.CreateButton.Text = "CREATE (insert data)"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(775, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'ReadButton
        '
        Me.ReadButton.Location = New System.Drawing.Point(165, 213)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(147, 60)
        Me.ReadButton.TabIndex = 10
        Me.ReadButton.Text = "READ (Retrieve Data)"
        Me.ReadButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(318, 213)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(147, 60)
        Me.EditButton.TabIndex = 11
        Me.EditButton.Text = "EDIT (Edit Selected Data)"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(471, 213)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(147, 60)
        Me.UpdateButton.TabIndex = 12
        Me.UpdateButton.Text = "UPDATE (Update Data)"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(624, 213)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(147, 60)
        Me.DeleteButton.TabIndex = 13
        Me.DeleteButton.Text = "DELETE (Delete Data)"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.ReadButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.TextAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextAge As TextBox
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReadButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
End Class
