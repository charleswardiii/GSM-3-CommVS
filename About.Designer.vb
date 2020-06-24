<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.tbxAbout = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'tbxAbout
        '
        Me.tbxAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAbout.Location = New System.Drawing.Point(0, -4)
        Me.tbxAbout.Margin = New System.Windows.Forms.Padding(6)
        Me.tbxAbout.Name = "tbxAbout"
        Me.tbxAbout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbxAbout.Size = New System.Drawing.Size(291, 137)
        Me.tbxAbout.TabIndex = 0
        Me.tbxAbout.Text = "GSM-3 v3.51" & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright 2019 CWE, Inc." & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved" & Global.Microsoft.VisualBasic.ChrW(10) & "www.cwe-inc.com"
        '
        'About
        '
        Me.AccessibleName = "frmAbout"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(296, 131)
        Me.Controls.Add(Me.tbxAbout)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbxAbout As RichTextBox

    Private Sub tbxAbout_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxAbout.MouseClick
        Me.Close()
    End Sub
End Class
