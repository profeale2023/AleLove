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
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtRuedas = New System.Windows.Forms.TextBox()
        Me.TxtAsientos = New System.Windows.Forms.TextBox()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.TxtTurbinas = New System.Windows.Forms.TextBox()
        Me.BtnCarga = New System.Windows.Forms.Button()
        Me.TxtResultado1 = New System.Windows.Forms.TextBox()
        Me.CboTransp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtResultado2 = New System.Windows.Forms.TextBox()
        Me.TxtResultado3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTipo.Location = New System.Drawing.Point(87, 12)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(181, 31)
        Me.LblTipo.TabIndex = 0
        Me.LblTipo.Text = "Tipo transporte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(88, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(87, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ruedas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(87, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Asiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(390, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Turbinas"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(216, 75)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(113, 23)
        Me.TxtMarca.TabIndex = 5
        '
        'TxtRuedas
        '
        Me.TxtRuedas.Location = New System.Drawing.Point(216, 122)
        Me.TxtRuedas.Name = "TxtRuedas"
        Me.TxtRuedas.Size = New System.Drawing.Size(113, 23)
        Me.TxtRuedas.TabIndex = 5
        '
        'TxtAsientos
        '
        Me.TxtAsientos.Location = New System.Drawing.Point(216, 175)
        Me.TxtAsientos.Name = "TxtAsientos"
        Me.TxtAsientos.Size = New System.Drawing.Size(113, 23)
        Me.TxtAsientos.TabIndex = 5
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(217, 257)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(113, 23)
        Me.TxtModelo.TabIndex = 5
        '
        'TxtTurbinas
        '
        Me.TxtTurbinas.Location = New System.Drawing.Point(517, 263)
        Me.TxtTurbinas.Name = "TxtTurbinas"
        Me.TxtTurbinas.Size = New System.Drawing.Size(113, 23)
        Me.TxtTurbinas.TabIndex = 6
        '
        'BtnCarga
        '
        Me.BtnCarga.Location = New System.Drawing.Point(491, 62)
        Me.BtnCarga.Name = "BtnCarga"
        Me.BtnCarga.Size = New System.Drawing.Size(212, 43)
        Me.BtnCarga.TabIndex = 7
        Me.BtnCarga.Text = "Carga de Datos"
        Me.BtnCarga.UseVisualStyleBackColor = True
        '
        'TxtResultado1
        '
        Me.TxtResultado1.Location = New System.Drawing.Point(157, 339)
        Me.TxtResultado1.Name = "TxtResultado1"
        Me.TxtResultado1.Size = New System.Drawing.Size(451, 23)
        Me.TxtResultado1.TabIndex = 8
        '
        'CboTransp
        '
        Me.CboTransp.FormattingEnabled = True
        Me.CboTransp.Items.AddRange(New Object() {"Auto", "Avion"})
        Me.CboTransp.Location = New System.Drawing.Point(283, 20)
        Me.CboTransp.Name = "CboTransp"
        Me.CboTransp.Size = New System.Drawing.Size(138, 23)
        Me.CboTransp.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(84, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Marca"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(644, 325)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(111, 48)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtResultado2
        '
        Me.TxtResultado2.Location = New System.Drawing.Point(157, 369)
        Me.TxtResultado2.Name = "TxtResultado2"
        Me.TxtResultado2.Size = New System.Drawing.Size(450, 23)
        Me.TxtResultado2.TabIndex = 11
        '
        'TxtResultado3
        '
        Me.TxtResultado3.Location = New System.Drawing.Point(547, 126)
        Me.TxtResultado3.Name = "TxtResultado3"
        Me.TxtResultado3.Size = New System.Drawing.Size(117, 23)
        Me.TxtResultado3.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtResultado3)
        Me.Controls.Add(Me.TxtResultado2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.CboTransp)
        Me.Controls.Add(Me.TxtResultado1)
        Me.Controls.Add(Me.BtnCarga)
        Me.Controls.Add(Me.TxtTurbinas)
        Me.Controls.Add(Me.TxtRuedas)
        Me.Controls.Add(Me.TxtAsientos)
        Me.Controls.Add(Me.TxtModelo)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTipo)
        Me.Name = "Form1"
        Me.Text = "Transportes Varios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTipo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents TxtRuedas As TextBox
    Friend WithEvents TxtAsientos As TextBox
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents TxtTurbinas As TextBox
    Friend WithEvents BtnCarga As Button
    Friend WithEvents TxtResultado1 As TextBox
    Friend WithEvents CboTransp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtResultado2 As TextBox
    Friend WithEvents TxtResultado3 As TextBox
End Class
