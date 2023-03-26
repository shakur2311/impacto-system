<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.BotonRegistrar = New FontAwesome.Sharp.IconButton()
        Me.BotonBuscar = New FontAwesome.Sharp.IconButton()
        Me.BotonInicio = New FontAwesome.Sharp.IconButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BotonSalirApp = New FontAwesome.Sharp.IconButton()
        Me.BotonMinimizar = New FontAwesome.Sharp.IconButton()
        Me.BotonMaximizar = New FontAwesome.Sharp.IconButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuAbrir = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuCerrar = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.BotonRegistrar)
        Me.Panel2.Controls.Add(Me.BotonBuscar)
        Me.Panel2.Controls.Add(Me.BotonInicio)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.MenuCerrar.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(50, 971)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.IconButton1)
        Me.MenuCerrar.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(3, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(180, 40)
        Me.Panel4.TabIndex = 7
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuCerrar.SetDecoration(Me.IconButton1, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.IconButton1, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(3, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(36, 36)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'BotonRegistrar
        '
        Me.MenuCerrar.SetDecoration(Me.BotonRegistrar, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.BotonRegistrar, BunifuAnimatorNS.DecorationType.None)
        Me.BotonRegistrar.FlatAppearance.BorderSize = 0
        Me.BotonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonRegistrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BotonRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRegistrar.ForeColor = System.Drawing.Color.White
        Me.BotonRegistrar.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp
        Me.BotonRegistrar.IconColor = System.Drawing.Color.White
        Me.BotonRegistrar.IconSize = 40
        Me.BotonRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonRegistrar.Location = New System.Drawing.Point(0, 199)
        Me.BotonRegistrar.Name = "BotonRegistrar"
        Me.BotonRegistrar.Rotation = 0R
        Me.BotonRegistrar.Size = New System.Drawing.Size(180, 69)
        Me.BotonRegistrar.TabIndex = 5
        Me.BotonRegistrar.Text = "     Registrar"
        Me.BotonRegistrar.UseVisualStyleBackColor = True
        '
        'BotonBuscar
        '
        Me.MenuCerrar.SetDecoration(Me.BotonBuscar, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.BotonBuscar, BunifuAnimatorNS.DecorationType.None)
        Me.BotonBuscar.FlatAppearance.BorderSize = 0
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BotonBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBuscar.ForeColor = System.Drawing.Color.White
        Me.BotonBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.BotonBuscar.IconColor = System.Drawing.Color.White
        Me.BotonBuscar.IconSize = 40
        Me.BotonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBuscar.Location = New System.Drawing.Point(0, 124)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Rotation = 0R
        Me.BotonBuscar.Size = New System.Drawing.Size(183, 69)
        Me.BotonBuscar.TabIndex = 4
        Me.BotonBuscar.Text = "Buscar"
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'BotonInicio
        '
        Me.MenuCerrar.SetDecoration(Me.BotonInicio, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.BotonInicio, BunifuAnimatorNS.DecorationType.None)
        Me.BotonInicio.FlatAppearance.BorderSize = 0
        Me.BotonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BotonInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonInicio.ForeColor = System.Drawing.Color.White
        Me.BotonInicio.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.BotonInicio.IconColor = System.Drawing.Color.White
        Me.BotonInicio.IconSize = 40
        Me.BotonInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonInicio.Location = New System.Drawing.Point(0, 49)
        Me.BotonInicio.Name = "BotonInicio"
        Me.BotonInicio.Rotation = 0R
        Me.BotonInicio.Size = New System.Drawing.Size(180, 69)
        Me.BotonInicio.TabIndex = 3
        Me.BotonInicio.Text = "Inicio"
        Me.BotonInicio.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuAbrir.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.MenuCerrar.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(25, 882)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(0, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'BotonSalirApp
        '
        Me.BotonSalirApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuCerrar.SetDecoration(Me.BotonSalirApp, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.BotonSalirApp, BunifuAnimatorNS.DecorationType.None)
        Me.BotonSalirApp.FlatAppearance.BorderSize = 0
        Me.BotonSalirApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonSalirApp.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BotonSalirApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSalirApp.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.BotonSalirApp.IconColor = System.Drawing.Color.White
        Me.BotonSalirApp.IconSize = 35
        Me.BotonSalirApp.Location = New System.Drawing.Point(1242, 3)
        Me.BotonSalirApp.Name = "BotonSalirApp"
        Me.BotonSalirApp.Rotation = 0R
        Me.BotonSalirApp.Size = New System.Drawing.Size(36, 37)
        Me.BotonSalirApp.TabIndex = 4
        Me.BotonSalirApp.UseVisualStyleBackColor = True
        '
        'BotonMinimizar
        '
        Me.BotonMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuCerrar.SetDecoration(Me.BotonMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.BotonMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.BotonMinimizar.FlatAppearance.BorderSize = 0
        Me.BotonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BotonMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.BotonMinimizar.IconColor = System.Drawing.Color.White
        Me.BotonMinimizar.IconSize = 35
        Me.BotonMinimizar.Location = New System.Drawing.Point(1158, 0)
        Me.BotonMinimizar.Name = "BotonMinimizar"
        Me.BotonMinimizar.Rotation = 0R
        Me.BotonMinimizar.Size = New System.Drawing.Size(36, 37)
        Me.BotonMinimizar.TabIndex = 6
        Me.BotonMinimizar.UseVisualStyleBackColor = True
        '
        'BotonMaximizar
        '
        Me.BotonMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuCerrar.SetDecoration(Me.BotonMaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.BotonMaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.BotonMaximizar.FlatAppearance.BorderSize = 0
        Me.BotonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BotonMaximizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.BotonMaximizar.IconColor = System.Drawing.Color.White
        Me.BotonMaximizar.IconSize = 35
        Me.BotonMaximizar.Location = New System.Drawing.Point(1200, 1)
        Me.BotonMaximizar.Name = "BotonMaximizar"
        Me.BotonMaximizar.Rotation = 0R
        Me.BotonMaximizar.Size = New System.Drawing.Size(36, 39)
        Me.BotonMaximizar.TabIndex = 5
        Me.BotonMaximizar.UseVisualStyleBackColor = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel4
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuCerrar.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(86, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1221, 872)
        Me.Panel3.TabIndex = 4
        '
        'MenuAbrir
        '
        Me.MenuAbrir.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind
        Me.MenuAbrir.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.MenuAbrir.DefaultAnimation = Animation2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.BotonMinimizar)
        Me.Panel1.Controls.Add(Me.BotonSalirApp)
        Me.Panel1.Controls.Add(Me.BotonMaximizar)
        Me.MenuCerrar.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(56, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1281, 40)
        Me.Panel1.TabIndex = 7
        '
        'MenuCerrar
        '
        Me.MenuCerrar.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.MenuCerrar.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.MenuCerrar.DefaultAnimation = Animation1
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Panel1
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuDragControl3
        '
        Me.BunifuDragControl3.Fixed = True
        Me.BunifuDragControl3.Horizontal = True
        Me.BunifuDragControl3.TargetControl = Nothing
        Me.BunifuDragControl3.Vertical = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1349, 971)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.MenuCerrar.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.MenuAbrir.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BotonSalirApp As FontAwesome.Sharp.IconButton
    Friend WithEvents BotonMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents BotonMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BotonRegistrar As FontAwesome.Sharp.IconButton
    Friend WithEvents BotonBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents BotonInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MenuCerrar As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents MenuAbrir As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
End Class
