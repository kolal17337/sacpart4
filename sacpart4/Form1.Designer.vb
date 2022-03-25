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
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lblRead = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReward = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(56, 60)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(178, 23)
        Me.btnRead.TabIndex = 0
        Me.btnRead.Text = "Click here to read the file"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lblRead
        '
        Me.lblRead.AutoSize = True
        Me.lblRead.Location = New System.Drawing.Point(53, 86)
        Me.lblRead.Name = "lblRead"
        Me.lblRead.Size = New System.Drawing.Size(39, 13)
        Me.lblRead.TabIndex = 1
        Me.lblRead.Text = "Label1"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(56, 163)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(193, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Click here to find the highest student"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReward
        '
        Me.btnReward.Location = New System.Drawing.Point(325, 163)
        Me.btnReward.Name = "btnReward"
        Me.btnReward.Size = New System.Drawing.Size(75, 23)
        Me.btnReward.TabIndex = 3
        Me.btnReward.Text = "Exit"
        Me.btnReward.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReward)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblRead)
        Me.Controls.Add(Me.btnRead)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRead As Button
    Friend WithEvents lblRead As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReward As Button
End Class
