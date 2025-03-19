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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUnitToCube = New System.Windows.Forms.Label()
        Me.bttnConvertToCube = New System.Windows.Forms.Button()
        Me.radUnitToCube_MPA = New System.Windows.Forms.RadioButton()
        Me.radUnitToCube_PSI = New System.Windows.Forms.RadioButton()
        Me.outputCubeStrength = New System.Windows.Forms.TextBox()
        Me.inputCylinderStrength = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUnitToCylinder = New System.Windows.Forms.Label()
        Me.bttnConvertToCylinder = New System.Windows.Forms.Button()
        Me.radUnitToCylinder_MPA = New System.Windows.Forms.RadioButton()
        Me.radUnitToCylinder_PSI = New System.Windows.Forms.RadioButton()
        Me.outputCylinderStrength = New System.Windows.Forms.TextBox()
        Me.inputCubeStrength = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUnitToCube)
        Me.GroupBox1.Controls.Add(Me.bttnConvertToCube)
        Me.GroupBox1.Controls.Add(Me.radUnitToCube_MPA)
        Me.GroupBox1.Controls.Add(Me.radUnitToCube_PSI)
        Me.GroupBox1.Controls.Add(Me.outputCubeStrength)
        Me.GroupBox1.Controls.Add(Me.inputCylinderStrength)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(444, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cylinder to Cube"
        '
        'lblUnitToCube
        '
        Me.lblUnitToCube.AutoSize = True
        Me.lblUnitToCube.Location = New System.Drawing.Point(311, 104)
        Me.lblUnitToCube.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnitToCube.Name = "lblUnitToCube"
        Me.lblUnitToCube.Size = New System.Drawing.Size(24, 15)
        Me.lblUnitToCube.TabIndex = 5
        Me.lblUnitToCube.Text = "Psi"
        '
        'bttnConvertToCube
        '
        Me.bttnConvertToCube.Location = New System.Drawing.Point(11, 56)
        Me.bttnConvertToCube.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnConvertToCube.Name = "bttnConvertToCube"
        Me.bttnConvertToCube.Size = New System.Drawing.Size(200, 26)
        Me.bttnConvertToCube.TabIndex = 4
        Me.bttnConvertToCube.Text = "Convert to Cube Strength"
        Me.bttnConvertToCube.UseVisualStyleBackColor = True
        '
        'radUnitToCube_MPA
        '
        Me.radUnitToCube_MPA.AutoSize = True
        Me.radUnitToCube_MPA.Location = New System.Drawing.Point(361, 21)
        Me.radUnitToCube_MPA.Margin = New System.Windows.Forms.Padding(4)
        Me.radUnitToCube_MPA.Name = "radUnitToCube_MPA"
        Me.radUnitToCube_MPA.Size = New System.Drawing.Size(51, 19)
        Me.radUnitToCube_MPA.TabIndex = 3
        Me.radUnitToCube_MPA.Text = "MPa"
        Me.radUnitToCube_MPA.UseVisualStyleBackColor = True
        '
        'radUnitToCube_PSI
        '
        Me.radUnitToCube_PSI.AutoSize = True
        Me.radUnitToCube_PSI.Checked = True
        Me.radUnitToCube_PSI.Location = New System.Drawing.Point(309, 21)
        Me.radUnitToCube_PSI.Margin = New System.Windows.Forms.Padding(4)
        Me.radUnitToCube_PSI.Name = "radUnitToCube_PSI"
        Me.radUnitToCube_PSI.Size = New System.Drawing.Size(42, 19)
        Me.radUnitToCube_PSI.TabIndex = 2
        Me.radUnitToCube_PSI.TabStop = True
        Me.radUnitToCube_PSI.Text = "Psi"
        Me.radUnitToCube_PSI.UseVisualStyleBackColor = True
        '
        'outputCubeStrength
        '
        Me.outputCubeStrength.BackColor = System.Drawing.Color.White
        Me.outputCubeStrength.Location = New System.Drawing.Point(186, 100)
        Me.outputCubeStrength.Margin = New System.Windows.Forms.Padding(4)
        Me.outputCubeStrength.Name = "outputCubeStrength"
        Me.outputCubeStrength.ReadOnly = True
        Me.outputCubeStrength.Size = New System.Drawing.Size(116, 21)
        Me.outputCubeStrength.TabIndex = 1
        Me.outputCubeStrength.TabStop = False
        '
        'inputCylinderStrength
        '
        Me.inputCylinderStrength.Location = New System.Drawing.Point(186, 20)
        Me.inputCylinderStrength.Margin = New System.Windows.Forms.Padding(4)
        Me.inputCylinderStrength.Name = "inputCylinderStrength"
        Me.inputCylinderStrength.Size = New System.Drawing.Size(116, 21)
        Me.inputCylinderStrength.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Approximate Cube Strength"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Specified Cylinder Strength"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUnitToCylinder)
        Me.GroupBox2.Controls.Add(Me.bttnConvertToCylinder)
        Me.GroupBox2.Controls.Add(Me.radUnitToCylinder_MPA)
        Me.GroupBox2.Controls.Add(Me.radUnitToCylinder_PSI)
        Me.GroupBox2.Controls.Add(Me.outputCylinderStrength)
        Me.GroupBox2.Controls.Add(Me.inputCubeStrength)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 175)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(444, 143)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cube to Cylinder"
        '
        'lblUnitToCylinder
        '
        Me.lblUnitToCylinder.AutoSize = True
        Me.lblUnitToCylinder.Location = New System.Drawing.Point(311, 104)
        Me.lblUnitToCylinder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnitToCylinder.Name = "lblUnitToCylinder"
        Me.lblUnitToCylinder.Size = New System.Drawing.Size(24, 15)
        Me.lblUnitToCylinder.TabIndex = 5
        Me.lblUnitToCylinder.Text = "Psi"
        '
        'bttnConvertToCylinder
        '
        Me.bttnConvertToCylinder.Location = New System.Drawing.Point(11, 56)
        Me.bttnConvertToCylinder.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnConvertToCylinder.Name = "bttnConvertToCylinder"
        Me.bttnConvertToCylinder.Size = New System.Drawing.Size(200, 26)
        Me.bttnConvertToCylinder.TabIndex = 4
        Me.bttnConvertToCylinder.Text = "Convert to Cylinder Strength"
        Me.bttnConvertToCylinder.UseVisualStyleBackColor = True
        '
        'radUnitToCylinder_MPA
        '
        Me.radUnitToCylinder_MPA.AutoSize = True
        Me.radUnitToCylinder_MPA.Location = New System.Drawing.Point(361, 21)
        Me.radUnitToCylinder_MPA.Margin = New System.Windows.Forms.Padding(4)
        Me.radUnitToCylinder_MPA.Name = "radUnitToCylinder_MPA"
        Me.radUnitToCylinder_MPA.Size = New System.Drawing.Size(51, 19)
        Me.radUnitToCylinder_MPA.TabIndex = 3
        Me.radUnitToCylinder_MPA.Text = "MPa"
        Me.radUnitToCylinder_MPA.UseVisualStyleBackColor = True
        '
        'radUnitToCylinder_PSI
        '
        Me.radUnitToCylinder_PSI.AutoSize = True
        Me.radUnitToCylinder_PSI.Checked = True
        Me.radUnitToCylinder_PSI.Location = New System.Drawing.Point(309, 21)
        Me.radUnitToCylinder_PSI.Margin = New System.Windows.Forms.Padding(4)
        Me.radUnitToCylinder_PSI.Name = "radUnitToCylinder_PSI"
        Me.radUnitToCylinder_PSI.Size = New System.Drawing.Size(42, 19)
        Me.radUnitToCylinder_PSI.TabIndex = 2
        Me.radUnitToCylinder_PSI.TabStop = True
        Me.radUnitToCylinder_PSI.Text = "Psi"
        Me.radUnitToCylinder_PSI.UseVisualStyleBackColor = True
        '
        'outputCylinderStrength
        '
        Me.outputCylinderStrength.BackColor = System.Drawing.Color.White
        Me.outputCylinderStrength.Location = New System.Drawing.Point(186, 100)
        Me.outputCylinderStrength.Margin = New System.Windows.Forms.Padding(4)
        Me.outputCylinderStrength.Name = "outputCylinderStrength"
        Me.outputCylinderStrength.ReadOnly = True
        Me.outputCylinderStrength.Size = New System.Drawing.Size(116, 21)
        Me.outputCylinderStrength.TabIndex = 1
        Me.outputCylinderStrength.TabStop = False
        '
        'inputCubeStrength
        '
        Me.inputCubeStrength.Location = New System.Drawing.Point(186, 20)
        Me.inputCubeStrength.Margin = New System.Windows.Forms.Padding(4)
        Me.inputCubeStrength.Name = "inputCubeStrength"
        Me.inputCubeStrength.Size = New System.Drawing.Size(116, 21)
        Me.inputCubeStrength.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Approximate Cylinder Strength"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Specified Cube Strength"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(348, 90)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Reference(s):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[1] - Structural Concrete - Theory and Design - Sixth Edition" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by " & _
    "M. Nadim Hassoun / Akthem Al-Manaseer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Source code:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://github.com/usmans" & _
    "hamsi/Concrete_Strength_Converter"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 439)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Concrete Strength Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUnitToCube As System.Windows.Forms.Label
    Friend WithEvents bttnConvertToCube As System.Windows.Forms.Button
    Friend WithEvents radUnitToCube_MPA As System.Windows.Forms.RadioButton
    Friend WithEvents radUnitToCube_PSI As System.Windows.Forms.RadioButton
    Friend WithEvents outputCubeStrength As System.Windows.Forms.TextBox
    Friend WithEvents inputCylinderStrength As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUnitToCylinder As System.Windows.Forms.Label
    Friend WithEvents bttnConvertToCylinder As System.Windows.Forms.Button
    Friend WithEvents radUnitToCylinder_MPA As System.Windows.Forms.RadioButton
    Friend WithEvents radUnitToCylinder_PSI As System.Windows.Forms.RadioButton
    Friend WithEvents outputCylinderStrength As System.Windows.Forms.TextBox
    Friend WithEvents inputCubeStrength As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
