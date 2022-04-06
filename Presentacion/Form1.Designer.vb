<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panTit = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panleBusqueda = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNacimiento = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.listaEstudiantes = New System.Windows.Forms.DataGridView()
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.panTit.SuspendLayout()
        Me.panleBusqueda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenido.SuspendLayout()
        Me.panelDatos.SuspendLayout()
        CType(Me.listaEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLateral.SuspendLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panTit
        '
        Me.panTit.BackColor = System.Drawing.Color.Gold
        Me.panTit.Controls.Add(Me.btnCerrar)
        Me.panTit.Controls.Add(Me.lblTitulo)
        Me.panTit.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTit.Location = New System.Drawing.Point(0, 0)
        Me.panTit.Name = "panTit"
        Me.panTit.Size = New System.Drawing.Size(800, 37)
        Me.panTit.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Red
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(767, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(113, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Estudiantes"
        '
        'panleBusqueda
        '
        Me.panleBusqueda.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panleBusqueda.Controls.Add(Me.txtBuscar)
        Me.panleBusqueda.Controls.Add(Me.PictureBox1)
        Me.panleBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.panleBusqueda.Location = New System.Drawing.Point(0, 37)
        Me.panleBusqueda.Name = "panleBusqueda"
        Me.panleBusqueda.Size = New System.Drawing.Size(800, 45)
        Me.panleBusqueda.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBuscar.Location = New System.Drawing.Point(56, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(314, 29)
        Me.txtBuscar.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.Color.White
        Me.panelContenido.Controls.Add(Me.panelDatos)
        Me.panelContenido.Controls.Add(Me.listaEstudiantes)
        Me.panelContenido.Controls.Add(Me.panelLateral)
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(0, 82)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(800, 498)
        Me.panelContenido.TabIndex = 2
        '
        'panelDatos
        '
        Me.panelDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelDatos.Controls.Add(Me.Button2)
        Me.panelDatos.Controls.Add(Me.Button1)
        Me.panelDatos.Controls.Add(Me.btnGuardar)
        Me.panelDatos.Controls.Add(Me.txtObservaciones)
        Me.panelDatos.Controls.Add(Me.Label3)
        Me.panelDatos.Controls.Add(Me.Label10)
        Me.panelDatos.Controls.Add(Me.Label9)
        Me.panelDatos.Controls.Add(Me.Label8)
        Me.panelDatos.Controls.Add(Me.Label7)
        Me.panelDatos.Controls.Add(Me.Label6)
        Me.panelDatos.Controls.Add(Me.Label5)
        Me.panelDatos.Controls.Add(Me.Label4)
        Me.panelDatos.Controls.Add(Me.Label2)
        Me.panelDatos.Controls.Add(Me.Label1)
        Me.panelDatos.Controls.Add(Me.txtNacimiento)
        Me.panelDatos.Controls.Add(Me.txtDireccion)
        Me.panelDatos.Controls.Add(Me.txtEmail)
        Me.panelDatos.Controls.Add(Me.txtPrimerNombre)
        Me.panelDatos.Controls.Add(Me.txtCelular)
        Me.panelDatos.Controls.Add(Me.txtPrimerApellido)
        Me.panelDatos.Controls.Add(Me.txtSegundoApellido)
        Me.panelDatos.Controls.Add(Me.txtTelefono)
        Me.panelDatos.Controls.Add(Me.txtSegundoNombre)
        Me.panelDatos.Location = New System.Drawing.Point(12, 6)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(776, 480)
        Me.panelDatos.TabIndex = 1
        Me.panelDatos.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(175, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 35)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(332, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 35)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.Location = New System.Drawing.Point(485, 434)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(131, 35)
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Cancelar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtObservaciones.Location = New System.Drawing.Point(384, 328)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(232, 88)
        Me.txtObservaciones.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(165, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Observaciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(165, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 25)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Primer apellido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(165, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Teléfono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(165, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Celular"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(165, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(165, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Segundo apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(165, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(165, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha de nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(165, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Segundo nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(165, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Primer nombre"
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNacimiento.Location = New System.Drawing.Point(384, 291)
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.Size = New System.Drawing.Size(232, 29)
        Me.txtNacimiento.TabIndex = 12
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDireccion.Location = New System.Drawing.Point(384, 221)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(232, 29)
        Me.txtDireccion.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(384, 256)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(232, 29)
        Me.txtEmail.TabIndex = 10
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPrimerNombre.Location = New System.Drawing.Point(384, 11)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(232, 29)
        Me.txtPrimerNombre.TabIndex = 9
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCelular.Location = New System.Drawing.Point(384, 186)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(232, 29)
        Me.txtCelular.TabIndex = 8
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPrimerApellido.Location = New System.Drawing.Point(384, 81)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(232, 29)
        Me.txtPrimerApellido.TabIndex = 7
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSegundoApellido.Location = New System.Drawing.Point(384, 116)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(232, 29)
        Me.txtSegundoApellido.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTelefono.Location = New System.Drawing.Point(384, 151)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(232, 29)
        Me.txtTelefono.TabIndex = 5
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSegundoNombre.Location = New System.Drawing.Point(384, 46)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(232, 29)
        Me.txtSegundoNombre.TabIndex = 4
        '
        'listaEstudiantes
        '
        Me.listaEstudiantes.AllowUserToAddRows = False
        Me.listaEstudiantes.AllowUserToDeleteRows = False
        Me.listaEstudiantes.AllowUserToResizeColumns = False
        Me.listaEstudiantes.BackgroundColor = System.Drawing.Color.White
        Me.listaEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listaEstudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.listaEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaEstudiantes.EnableHeadersVisualStyles = False
        Me.listaEstudiantes.Location = New System.Drawing.Point(12, 6)
        Me.listaEstudiantes.Name = "listaEstudiantes"
        Me.listaEstudiantes.RowHeadersVisible = False
        Me.listaEstudiantes.RowTemplate.Height = 25
        Me.listaEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listaEstudiantes.Size = New System.Drawing.Size(616, 350)
        Me.listaEstudiantes.TabIndex = 1
        '
        'panelLateral
        '
        Me.panelLateral.Controls.Add(Me.btnNuevo)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelLateral.Location = New System.Drawing.Point(634, 0)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(166, 498)
        Me.panelLateral.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(72, 201)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(82, 86)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 580)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panleBusqueda)
        Me.Controls.Add(Me.panTit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panTit.ResumeLayout(False)
        Me.panTit.PerformLayout()
        Me.panleBusqueda.ResumeLayout(False)
        Me.panleBusqueda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenido.ResumeLayout(False)
        Me.panelDatos.ResumeLayout(False)
        Me.panelDatos.PerformLayout()
        CType(Me.listaEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLateral.ResumeLayout(False)
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panTit As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents panleBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelContenido As Panel
    Friend WithEvents panelLateral As Panel
    Friend WithEvents listaEstudiantes As DataGridView
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents panelDatos As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNacimiento As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
