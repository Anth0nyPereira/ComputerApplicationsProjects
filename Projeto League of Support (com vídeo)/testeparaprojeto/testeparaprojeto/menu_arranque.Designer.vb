<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu_arranque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_arranque))
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.PictureBox_avançar = New System.Windows.Forms.PictureBox()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_avançar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(0, 0)
        Me.AxVLCPlugin21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(1190, 691)
        Me.AxVLCPlugin21.TabIndex = 0
        '
        'PictureBox_avançar
        '
        Me.PictureBox_avançar.BackgroundImage = CType(resources.GetObject("PictureBox_avançar.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox_avançar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_avançar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_avançar.Location = New System.Drawing.Point(0, 608)
        Me.PictureBox_avançar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox_avançar.Name = "PictureBox_avançar"
        Me.PictureBox_avançar.Size = New System.Drawing.Size(1190, 106)
        Me.PictureBox_avançar.TabIndex = 2
        Me.PictureBox_avançar.TabStop = False
        '
        'menu_arranque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 691)
        Me.Controls.Add(Me.PictureBox_avançar)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu_arranque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu_arranque"
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_avançar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents PictureBox_avançar As PictureBox
End Class
