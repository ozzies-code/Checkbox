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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chPolimorfismo = New System.Windows.Forms.CheckBox()
        Me.chBucle = New System.Windows.Forms.CheckBox()
        Me.chHerencia = New System.Windows.Forms.CheckBox()
        Me.chObjeto = New System.Windows.Forms.CheckBox()
        Me.chClase = New System.Windows.Forms.CheckBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(537, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Que conceptos de los que se muestran a continuacion pertenecen al paradigma de l" &
    "a POO?"
        '
        'chPolimorfismo
        '
        Me.chPolimorfismo.AutoSize = True
        Me.chPolimorfismo.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chPolimorfismo.ForeColor = System.Drawing.Color.Gold
        Me.chPolimorfismo.Location = New System.Drawing.Point(26, 199)
        Me.chPolimorfismo.Name = "chPolimorfismo"
        Me.chPolimorfismo.Size = New System.Drawing.Size(101, 19)
        Me.chPolimorfismo.TabIndex = 1
        Me.chPolimorfismo.Text = "Polimorfismo"
        Me.chPolimorfismo.UseVisualStyleBackColor = True
        '
        'chBucle
        '
        Me.chBucle.AutoSize = True
        Me.chBucle.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBucle.ForeColor = System.Drawing.Color.Gold
        Me.chBucle.Location = New System.Drawing.Point(26, 164)
        Me.chBucle.Name = "chBucle"
        Me.chBucle.Size = New System.Drawing.Size(58, 19)
        Me.chBucle.TabIndex = 2
        Me.chBucle.Text = "Bucle"
        Me.chBucle.UseVisualStyleBackColor = True
        '
        'chHerencia
        '
        Me.chHerencia.AutoSize = True
        Me.chHerencia.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chHerencia.ForeColor = System.Drawing.Color.Gold
        Me.chHerencia.Location = New System.Drawing.Point(26, 131)
        Me.chHerencia.Name = "chHerencia"
        Me.chHerencia.Size = New System.Drawing.Size(77, 19)
        Me.chHerencia.TabIndex = 3
        Me.chHerencia.Text = "Herencia"
        Me.chHerencia.UseVisualStyleBackColor = True
        '
        'chObjeto
        '
        Me.chObjeto.AutoSize = True
        Me.chObjeto.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chObjeto.ForeColor = System.Drawing.Color.Gold
        Me.chObjeto.Location = New System.Drawing.Point(26, 95)
        Me.chObjeto.Name = "chObjeto"
        Me.chObjeto.Size = New System.Drawing.Size(63, 19)
        Me.chObjeto.TabIndex = 4
        Me.chObjeto.Text = "Objeto"
        Me.chObjeto.UseVisualStyleBackColor = True
        '
        'chClase
        '
        Me.chClase.AutoSize = True
        Me.chClase.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chClase.ForeColor = System.Drawing.Color.Gold
        Me.chClase.Location = New System.Drawing.Point(26, 59)
        Me.chClase.Name = "chClase"
        Me.chClase.Size = New System.Drawing.Size(57, 19)
        Me.chClase.TabIndex = 5
        Me.chClase.Text = "Clase"
        Me.chClase.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.DimGray
        Me.btnProcesar.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ForeColor = System.Drawing.Color.Gold
        Me.btnProcesar.Location = New System.Drawing.Point(434, 164)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(126, 57)
        Me.btnProcesar.TabIndex = 6
        Me.btnProcesar.Text = "Procesar Respuesta"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(575, 233)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.chClase)
        Me.Controls.Add(Me.chObjeto)
        Me.Controls.Add(Me.chHerencia)
        Me.Controls.Add(Me.chBucle)
        Me.Controls.Add(Me.chPolimorfismo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Checkbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chPolimorfismo As Windows.Forms.CheckBox
    Friend WithEvents chBucle As Windows.Forms.CheckBox
    Friend WithEvents chHerencia As Windows.Forms.CheckBox
    Friend WithEvents chObjeto As Windows.Forms.CheckBox
    Friend WithEvents chClase As Windows.Forms.CheckBox
    Friend WithEvents btnProcesar As Button
End Class
