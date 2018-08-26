<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.movimiento = New System.Windows.Forms.Timer(Me.components)
        Me.gravedad = New System.Windows.Forms.Timer(Me.components)
        Me.caida = New System.Windows.Forms.Timer(Me.components)
        Me.Animacion = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.vida2 = New System.Windows.Forms.Panel()
        Me.vida1 = New System.Windows.Forms.Panel()
        Me.poder = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Player2 = New game2.PictureBoxTransparente()
        Me.Player1 = New game2.PictureBoxTransparente()
        Me.Panel7 = New System.Windows.Forms.Panel()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'movimiento
        '
        Me.movimiento.Interval = 1
        '
        'gravedad
        '
        Me.gravedad.Interval = 1
        '
        'caida
        '
        Me.caida.Interval = 1
        '
        'Animacion
        '
        Me.Animacion.Enabled = True
        Me.Animacion.Interval = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(4, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 100)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Location = New System.Drawing.Point(765, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(93, 369)
        Me.Panel2.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'vida2
        '
        Me.vida2.BackColor = System.Drawing.Color.Red
        Me.vida2.Location = New System.Drawing.Point(84, 12)
        Me.vida2.Name = "vida2"
        Me.vida2.Size = New System.Drawing.Size(200, 32)
        Me.vida2.TabIndex = 9
        '
        'vida1
        '
        Me.vida1.BackColor = System.Drawing.Color.Lime
        Me.vida1.Location = New System.Drawing.Point(84, 12)
        Me.vida1.Name = "vida1"
        Me.vida1.Size = New System.Drawing.Size(200, 32)
        Me.vida1.TabIndex = 10
        '
        'poder
        '
        Me.poder.BackColor = System.Drawing.Color.Cyan
        Me.poder.Location = New System.Drawing.Point(84, 50)
        Me.poder.Name = "poder"
        Me.poder.Size = New System.Drawing.Size(200, 11)
        Me.poder.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Location = New System.Drawing.Point(4, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(74, 419)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Lime
        Me.Panel4.Location = New System.Drawing.Point(559, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 32)
        Me.Panel4.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.Location = New System.Drawing.Point(559, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 11)
        Me.Panel5.TabIndex = 14
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Red
        Me.Panel6.Location = New System.Drawing.Point(559, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 32)
        Me.Panel6.TabIndex = 12
        '
        'Player2
        '
        Me.Player2.BackColor = System.Drawing.Color.Transparent
        Me.Player2.ErrorImage = Nothing
        Me.Player2.Image = Nothing
        Me.Player2.InitialImage = Nothing
        Me.Player2.Location = New System.Drawing.Point(550, 156)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(142, 201)
        Me.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2.TabIndex = 18
        Me.Player2.TabStop = False
        '
        'Player1
        '
        Me.Player1.BackColor = System.Drawing.Color.Transparent
        Me.Player1.ErrorImage = Nothing
        Me.Player1.Image = Nothing
        Me.Player1.InitialImage = Nothing
        Me.Player1.Location = New System.Drawing.Point(159, 156)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(142, 201)
        Me.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1.TabIndex = 17
        Me.Player1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Location = New System.Drawing.Point(390, 156)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(118, 195)
        Me.Panel7.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(858, 491)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.vida1)
        Me.Controls.Add(Me.poder)
        Me.Controls.Add(Me.vida2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents movimiento As System.Windows.Forms.Timer
    Friend WithEvents gravedad As System.Windows.Forms.Timer
    Friend WithEvents caida As System.Windows.Forms.Timer
    Friend WithEvents Animacion As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents vida2 As System.Windows.Forms.Panel
    Friend WithEvents vida1 As System.Windows.Forms.Panel
    Friend WithEvents poder As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Player1 As game2.PictureBoxTransparente
    Friend WithEvents Player2 As game2.PictureBoxTransparente
    Friend WithEvents Panel7 As System.Windows.Forms.Panel

End Class
