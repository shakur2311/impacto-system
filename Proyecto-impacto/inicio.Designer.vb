<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxLuis = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPercy = New System.Windows.Forms.PictureBox()
        Me.BotonEditar = New FontAwesome.Sharp.IconButton()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuFlatButtonCancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButtonGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBoxPipo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLuis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPercy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(293, 630)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 46)
        Me.Label1.TabIndex = 0
        '
        'PictureBoxLuis
        '
        Me.PictureBoxLuis.Image = CType(resources.GetObject("PictureBoxLuis.Image"), System.Drawing.Image)
        Me.PictureBoxLuis.Location = New System.Drawing.Point(907, 228)
        Me.PictureBoxLuis.Name = "PictureBoxLuis"
        Me.PictureBoxLuis.Size = New System.Drawing.Size(164, 189)
        Me.PictureBoxLuis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLuis.TabIndex = 1
        Me.PictureBoxLuis.TabStop = False
        '
        'PictureBoxPercy
        '
        Me.PictureBoxPercy.Image = CType(resources.GetObject("PictureBoxPercy.Image"), System.Drawing.Image)
        Me.PictureBoxPercy.Location = New System.Drawing.Point(907, 228)
        Me.PictureBoxPercy.Name = "PictureBoxPercy"
        Me.PictureBoxPercy.Size = New System.Drawing.Size(164, 186)
        Me.PictureBoxPercy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPercy.TabIndex = 2
        Me.PictureBoxPercy.TabStop = False
        '
        'BotonEditar
        '
        Me.BotonEditar.FlatAppearance.BorderSize = 0
        Me.BotonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BotonEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonEditar.ForeColor = System.Drawing.Color.White
        Me.BotonEditar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.BotonEditar.IconColor = System.Drawing.Color.White
        Me.BotonEditar.IconSize = 40
        Me.BotonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonEditar.Location = New System.Drawing.Point(247, 194)
        Me.BotonEditar.Name = "BotonEditar"
        Me.BotonEditar.Rotation = 0R
        Me.BotonEditar.Size = New System.Drawing.Size(46, 58)
        Me.BotonEditar.TabIndex = 5
        Me.BotonEditar.UseVisualStyleBackColor = True
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(390, 242)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(284, 10)
        Me.BunifuSeparator2.TabIndex = 25
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(390, 212)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 40)
        Me.TextBox1.TabIndex = 24
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(390, 354)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(284, 10)
        Me.BunifuSeparator1.TabIndex = 27
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(390, 324)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(284, 40)
        Me.TextBox2.TabIndex = 26
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(390, 466)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(284, 10)
        Me.BunifuSeparator3.TabIndex = 29
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(390, 436)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(284, 40)
        Me.TextBox3.TabIndex = 28
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuFlatButtonCancelar
        '
        Me.BunifuFlatButtonCancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuFlatButtonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuFlatButtonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButtonCancelar.BorderRadius = 0
        Me.BunifuFlatButtonCancelar.ButtonText = "Cancelar"
        Me.BunifuFlatButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButtonCancelar.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButtonCancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButtonCancelar.Iconimage = CType(resources.GetObject("BunifuFlatButtonCancelar.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButtonCancelar.Iconimage_right = Nothing
        Me.BunifuFlatButtonCancelar.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButtonCancelar.Iconimage_Selected = Nothing
        Me.BunifuFlatButtonCancelar.IconMarginLeft = 0
        Me.BunifuFlatButtonCancelar.IconMarginRight = 0
        Me.BunifuFlatButtonCancelar.IconRightVisible = True
        Me.BunifuFlatButtonCancelar.IconRightZoom = 0R
        Me.BunifuFlatButtonCancelar.IconVisible = False
        Me.BunifuFlatButtonCancelar.IconZoom = 90.0R
        Me.BunifuFlatButtonCancelar.IsTab = False
        Me.BunifuFlatButtonCancelar.Location = New System.Drawing.Point(313, 556)
        Me.BunifuFlatButtonCancelar.Name = "BunifuFlatButtonCancelar"
        Me.BunifuFlatButtonCancelar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuFlatButtonCancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuFlatButtonCancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButtonCancelar.selected = False
        Me.BunifuFlatButtonCancelar.Size = New System.Drawing.Size(160, 48)
        Me.BunifuFlatButtonCancelar.TabIndex = 30
        Me.BunifuFlatButtonCancelar.Text = "Cancelar"
        Me.BunifuFlatButtonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButtonCancelar.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButtonCancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButtonCancelar.Visible = False
        '
        'BunifuFlatButtonGuardar
        '
        Me.BunifuFlatButtonGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButtonGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButtonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButtonGuardar.BorderRadius = 0
        Me.BunifuFlatButtonGuardar.ButtonText = "Guardar"
        Me.BunifuFlatButtonGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButtonGuardar.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButtonGuardar.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButtonGuardar.Iconimage = CType(resources.GetObject("BunifuFlatButtonGuardar.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButtonGuardar.Iconimage_right = Nothing
        Me.BunifuFlatButtonGuardar.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButtonGuardar.Iconimage_Selected = Nothing
        Me.BunifuFlatButtonGuardar.IconMarginLeft = 0
        Me.BunifuFlatButtonGuardar.IconMarginRight = 0
        Me.BunifuFlatButtonGuardar.IconRightVisible = True
        Me.BunifuFlatButtonGuardar.IconRightZoom = 0R
        Me.BunifuFlatButtonGuardar.IconVisible = False
        Me.BunifuFlatButtonGuardar.IconZoom = 90.0R
        Me.BunifuFlatButtonGuardar.IsTab = False
        Me.BunifuFlatButtonGuardar.Location = New System.Drawing.Point(566, 556)
        Me.BunifuFlatButtonGuardar.Name = "BunifuFlatButtonGuardar"
        Me.BunifuFlatButtonGuardar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButtonGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButtonGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButtonGuardar.selected = True
        Me.BunifuFlatButtonGuardar.Size = New System.Drawing.Size(160, 48)
        Me.BunifuFlatButtonGuardar.TabIndex = 31
        Me.BunifuFlatButtonGuardar.Text = "Guardar"
        Me.BunifuFlatButtonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButtonGuardar.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButtonGuardar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButtonGuardar.Visible = False
        '
        'PictureBoxPipo
        '
        Me.PictureBoxPipo.Image = CType(resources.GetObject("PictureBoxPipo.Image"), System.Drawing.Image)
        Me.PictureBoxPipo.Location = New System.Drawing.Point(907, 228)
        Me.PictureBoxPipo.Name = "PictureBoxPipo"
        Me.PictureBoxPipo.Size = New System.Drawing.Size(164, 189)
        Me.PictureBoxPipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPipo.TabIndex = 32
        Me.PictureBoxPipo.TabStop = False
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1221, 872)
        Me.Controls.Add(Me.PictureBoxPipo)
        Me.Controls.Add(Me.BunifuFlatButtonGuardar)
        Me.Controls.Add(Me.BunifuFlatButtonCancelar)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BotonEditar)
        Me.Controls.Add(Me.PictureBoxPercy)
        Me.Controls.Add(Me.PictureBoxLuis)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inicio"
        Me.Text = "inicio"
        CType(Me.PictureBoxLuis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPercy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxLuis As PictureBox
    Friend WithEvents PictureBoxPercy As PictureBox
    Friend WithEvents BotonEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuFlatButtonGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButtonCancelar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBoxPipo As PictureBox
End Class
