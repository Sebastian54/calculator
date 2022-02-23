<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(30, 34)
        Me.lblNum1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(78, 20)
        Me.lblNum1.TabIndex = 0
        Me.lblNum1.Text = "First Number:"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(30, 99)
        Me.lblNum2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(94, 20)
        Me.lblNum2.TabIndex = 1
        Me.lblNum2.Text = "Second Number:"
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(136, 31)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(184, 28)
        Me.txtNum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(136, 96)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(184, 28)
        Me.txtNum2.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(44, 160)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(49, 44)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.Location = New System.Drawing.Point(136, 160)
        Me.btnSubtract.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(49, 44)
        Me.btnSubtract.TabIndex = 5
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.Location = New System.Drawing.Point(318, 160)
        Me.btnDiv.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(49, 44)
        Me.btnDiv.TabIndex = 6
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(227, 160)
        Me.btnMultiply.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(49, 44)
        Me.btnMultiply.TabIndex = 7
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(30, 254)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(44, 20)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Result:"
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 376)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents lblResult As Label
End Class
