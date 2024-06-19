<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FFTrans = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FFButton = New System.Windows.Forms.Button()
        Me.Heating_Time = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Extracted_Volume = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BioFuelTemp_SP = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Wash_Qty = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Wash_Wait = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Water_Volume = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Trans_Duration = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Catalyst_Volume = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Methanol_Volume = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Nhexane_Duration = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Nhexane_Temp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Soxhlet_Duration_txt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Soxhlet_SetTemp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NHexane_Vol_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Final_Blue = New System.Windows.Forms.TextBox()
        Me.Init_Blue = New System.Windows.Forms.TextBox()
        Me.Final_Green = New System.Windows.Forms.TextBox()
        Me.Init_Green = New System.Windows.Forms.TextBox()
        Me.Final_Red = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Init_Red = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Loop100Ambient_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Loop100_temp_response_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dwell_time_txt = New System.Windows.Forms.TextBox()
        Me.Oven_temp_txt = New System.Windows.Forms.TextBox()
        Me.Conv_speed_lbl = New System.Windows.Forms.Label()
        Me.oventemp_lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Calamansi_vol_txt = New System.Windows.Forms.TextBox()
        Me.Kamias_vol_txt = New System.Windows.Forms.TextBox()
        Me.Calamansi = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pause = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Refresh_btn = New System.Windows.Forms.Button()
        Me.Kamias = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GrindingTank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Separatory_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.SoxhletRaw_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Condensed_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Soxhlet_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Hexane_Extract_tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Methanol_tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.NHexane_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Trans_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.BioFuel_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Water_Waste_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Catalyst_Tank = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.RawMats = New Guna.UI2.WinForms.Guna2Shapes()
        Me.RawAnimation_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Loop100PV = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Loop100SP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Loop100_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Oven_Dwell_timer = New System.Windows.Forms.Timer(Me.components)
        Me.RawDrop_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Nhexane_Dispense_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Loop104_SP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Loop104_PV = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Soxhlet_temp_timer = New System.Windows.Forms.Timer(Me.components)
        Me.SoxhletProcess_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Hexane_Extract_time = New System.Windows.Forms.Timer(Me.components)
        Me.Hexane_Extract_temp_time = New System.Windows.Forms.Timer(Me.components)
        Me.Nhexane_SP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Nhexane_PV = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Trans_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Trans_Color_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TransTopBar = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Filter_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Water_Fill_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Wash_Wait_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Water_Drain_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.BioFuel_Fill_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Loop111_Heat_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Loop111_SP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Loop111_PV = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RemoveWater_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.dried_out = New System.Windows.Forms.Label()
        Me.nhexaneShow = New System.Windows.Forms.Label()
        Me.catalystShow = New System.Windows.Forms.Label()
        Me.methanolShow = New System.Windows.Forms.Label()
        Me.TransShow = New System.Windows.Forms.Label()
        Me.SeparatoryShow = New System.Windows.Forms.Label()
        Me.separatorunit = New System.Windows.Forms.Label()
        Me.biofuelunit = New System.Windows.Forms.Label()
        Me.biofuelShow = New System.Windows.Forms.Label()
        Me.Cutter = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.FFTrans)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.FFButton)
        Me.Panel1.Controls.Add(Me.Heating_Time)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Extracted_Volume)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.BioFuelTemp_SP)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Wash_Qty)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Wash_Wait)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Water_Volume)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Trans_Duration)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Catalyst_Volume)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Methanol_Volume)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Nhexane_Duration)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Nhexane_Temp)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Soxhlet_Duration_txt)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Soxhlet_SetTemp)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.NHexane_Vol_txt)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Final_Blue)
        Me.Panel1.Controls.Add(Me.Init_Blue)
        Me.Panel1.Controls.Add(Me.Final_Green)
        Me.Panel1.Controls.Add(Me.Init_Green)
        Me.Panel1.Controls.Add(Me.Final_Red)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Init_Red)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Loop100Ambient_txt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Loop100_temp_response_txt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Dwell_time_txt)
        Me.Panel1.Controls.Add(Me.Oven_temp_txt)
        Me.Panel1.Controls.Add(Me.Conv_speed_lbl)
        Me.Panel1.Controls.Add(Me.oventemp_lbl)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Calamansi_vol_txt)
        Me.Panel1.Controls.Add(Me.Kamias_vol_txt)
        Me.Panel1.Controls.Add(Me.Calamansi)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Kamias)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 666)
        Me.Panel1.TabIndex = 0
        '
        'FFTrans
        '
        Me.FFTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FFTrans.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FFTrans.Location = New System.Drawing.Point(297, 399)
        Me.FFTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.FFTrans.Name = "FFTrans"
        Me.FFTrans.Size = New System.Drawing.Size(66, 38)
        Me.FFTrans.TabIndex = 70
        Me.FFTrans.Text = "Fast Forward"
        Me.FFTrans.UseVisualStyleBackColor = True
        Me.FFTrans.Visible = False
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(227, 551)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 38)
        Me.Button6.TabIndex = 69
        Me.Button6.Text = "Fast Forward"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(297, 478)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 38)
        Me.Button5.TabIndex = 68
        Me.Button5.Text = "Fast Forward"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(227, 478)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(66, 38)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "Fast Forward"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(227, 399)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 38)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "Fast Forward"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(297, 334)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 38)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Fast Forward"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(227, 334)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 38)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Fast Forward"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'FFButton
        '
        Me.FFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FFButton.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FFButton.Location = New System.Drawing.Point(227, 251)
        Me.FFButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FFButton.Name = "FFButton"
        Me.FFButton.Size = New System.Drawing.Size(66, 51)
        Me.FFButton.TabIndex = 64
        Me.FFButton.Text = "Fast Forward"
        Me.FFButton.UseVisualStyleBackColor = True
        Me.FFButton.Visible = False
        '
        'Heating_Time
        '
        Me.Heating_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Heating_Time.Enabled = False
        Me.Heating_Time.Location = New System.Drawing.Point(147, 586)
        Me.Heating_Time.Margin = New System.Windows.Forms.Padding(2)
        Me.Heating_Time.Name = "Heating_Time"
        Me.Heating_Time.Size = New System.Drawing.Size(77, 20)
        Me.Heating_Time.TabIndex = 63
        Me.Heating_Time.Text = "30"
        Me.Heating_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(43, 588)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 13)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "Heating Time(M)"
        '
        'Extracted_Volume
        '
        Me.Extracted_Volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Extracted_Volume.Location = New System.Drawing.Point(147, 569)
        Me.Extracted_Volume.Margin = New System.Windows.Forms.Padding(2)
        Me.Extracted_Volume.Name = "Extracted_Volume"
        Me.Extracted_Volume.Size = New System.Drawing.Size(77, 20)
        Me.Extracted_Volume.TabIndex = 60
        Me.Extracted_Volume.Text = "10"
        Me.Extracted_Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(23, 570)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(106, 13)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "Extracted Volume(ml)"
        '
        'BioFuelTemp_SP
        '
        Me.BioFuelTemp_SP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BioFuelTemp_SP.Enabled = False
        Me.BioFuelTemp_SP.Location = New System.Drawing.Point(147, 551)
        Me.BioFuelTemp_SP.Margin = New System.Windows.Forms.Padding(2)
        Me.BioFuelTemp_SP.Name = "BioFuelTemp_SP"
        Me.BioFuelTemp_SP.Size = New System.Drawing.Size(77, 20)
        Me.BioFuelTemp_SP.TabIndex = 58
        Me.BioFuelTemp_SP.Text = "100"
        Me.BioFuelTemp_SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(40, 552)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 13)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Set Temperature"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 530)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(127, 20)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "Bio Fuel Heating"
        '
        'Wash_Qty
        '
        Me.Wash_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Wash_Qty.Location = New System.Drawing.Point(147, 513)
        Me.Wash_Qty.Margin = New System.Windows.Forms.Padding(2)
        Me.Wash_Qty.Name = "Wash_Qty"
        Me.Wash_Qty.Size = New System.Drawing.Size(77, 20)
        Me.Wash_Qty.TabIndex = 55
        Me.Wash_Qty.Text = "3"
        Me.Wash_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(65, 514)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Wash Cycle"
        '
        'Wash_Wait
        '
        Me.Wash_Wait.AcceptsReturn = True
        Me.Wash_Wait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Wash_Wait.Location = New System.Drawing.Point(147, 495)
        Me.Wash_Wait.Margin = New System.Windows.Forms.Padding(2)
        Me.Wash_Wait.Name = "Wash_Wait"
        Me.Wash_Wait.Size = New System.Drawing.Size(77, 20)
        Me.Wash_Wait.TabIndex = 53
        Me.Wash_Wait.Text = "30"
        Me.Wash_Wait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(52, 497)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 13)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Wash Time(M)"
        '
        'Water_Volume
        '
        Me.Water_Volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Water_Volume.Location = New System.Drawing.Point(147, 478)
        Me.Water_Volume.Margin = New System.Windows.Forms.Padding(2)
        Me.Water_Volume.Name = "Water_Volume"
        Me.Water_Volume.Size = New System.Drawing.Size(77, 20)
        Me.Water_Volume.TabIndex = 51
        Me.Water_Volume.Text = "250"
        Me.Water_Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(35, 479)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 13)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Water Volume(ml)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 457)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 20)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Separatory"
        '
        'Trans_Duration
        '
        Me.Trans_Duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Trans_Duration.Location = New System.Drawing.Point(146, 434)
        Me.Trans_Duration.Margin = New System.Windows.Forms.Padding(2)
        Me.Trans_Duration.Name = "Trans_Duration"
        Me.Trans_Duration.Size = New System.Drawing.Size(77, 20)
        Me.Trans_Duration.TabIndex = 48
        Me.Trans_Duration.Text = "15"
        Me.Trans_Duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(65, 435)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Duration(H)"
        '
        'Catalyst_Volume
        '
        Me.Catalyst_Volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Catalyst_Volume.Enabled = False
        Me.Catalyst_Volume.Location = New System.Drawing.Point(146, 417)
        Me.Catalyst_Volume.Margin = New System.Windows.Forms.Padding(2)
        Me.Catalyst_Volume.Name = "Catalyst_Volume"
        Me.Catalyst_Volume.Size = New System.Drawing.Size(77, 20)
        Me.Catalyst_Volume.TabIndex = 46
        Me.Catalyst_Volume.Text = "15"
        Me.Catalyst_Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 418)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Catalyst Volume(g)"
        '
        'Methanol_Volume
        '
        Me.Methanol_Volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Methanol_Volume.Enabled = False
        Me.Methanol_Volume.Location = New System.Drawing.Point(146, 399)
        Me.Methanol_Volume.Margin = New System.Windows.Forms.Padding(2)
        Me.Methanol_Volume.Name = "Methanol_Volume"
        Me.Methanol_Volume.Size = New System.Drawing.Size(77, 20)
        Me.Methanol_Volume.TabIndex = 44
        Me.Methanol_Volume.Text = "30"
        Me.Methanol_Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 400)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Methanol Volume(ml)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 378)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(139, 20)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Transesterification"
        '
        'Nhexane_Duration
        '
        Me.Nhexane_Duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nhexane_Duration.Location = New System.Drawing.Point(146, 352)
        Me.Nhexane_Duration.Margin = New System.Windows.Forms.Padding(2)
        Me.Nhexane_Duration.Name = "Nhexane_Duration"
        Me.Nhexane_Duration.Size = New System.Drawing.Size(77, 20)
        Me.Nhexane_Duration.TabIndex = 41
        Me.Nhexane_Duration.Text = "150"
        Me.Nhexane_Duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 353)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Extract Duration(H)"
        '
        'Nhexane_Temp
        '
        Me.Nhexane_Temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nhexane_Temp.Enabled = False
        Me.Nhexane_Temp.Location = New System.Drawing.Point(146, 334)
        Me.Nhexane_Temp.Margin = New System.Windows.Forms.Padding(2)
        Me.Nhexane_Temp.Name = "Nhexane_Temp"
        Me.Nhexane_Temp.Size = New System.Drawing.Size(77, 20)
        Me.Nhexane_Temp.TabIndex = 39
        Me.Nhexane_Temp.Text = "35"
        Me.Nhexane_Temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 335)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Set Temperature"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 313)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 20)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "N-Hexane Extract"
        '
        'Soxhlet_Duration_txt
        '
        Me.Soxhlet_Duration_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Soxhlet_Duration_txt.Location = New System.Drawing.Point(146, 285)
        Me.Soxhlet_Duration_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Soxhlet_Duration_txt.Name = "Soxhlet_Duration_txt"
        Me.Soxhlet_Duration_txt.Size = New System.Drawing.Size(77, 20)
        Me.Soxhlet_Duration_txt.TabIndex = 36
        Me.Soxhlet_Duration_txt.Text = "6"
        Me.Soxhlet_Duration_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 286)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Soxhlet Duration(H)"
        '
        'Soxhlet_SetTemp
        '
        Me.Soxhlet_SetTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Soxhlet_SetTemp.Enabled = False
        Me.Soxhlet_SetTemp.Location = New System.Drawing.Point(146, 267)
        Me.Soxhlet_SetTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.Soxhlet_SetTemp.Name = "Soxhlet_SetTemp"
        Me.Soxhlet_SetTemp.Size = New System.Drawing.Size(77, 20)
        Me.Soxhlet_SetTemp.TabIndex = 34
        Me.Soxhlet_SetTemp.Text = "68"
        Me.Soxhlet_SetTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 268)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Soxhlet Temperature"
        '
        'NHexane_Vol_txt
        '
        Me.NHexane_Vol_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NHexane_Vol_txt.Enabled = False
        Me.NHexane_Vol_txt.Location = New System.Drawing.Point(146, 250)
        Me.NHexane_Vol_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.NHexane_Vol_txt.Name = "NHexane_Vol_txt"
        Me.NHexane_Vol_txt.Size = New System.Drawing.Size(77, 20)
        Me.NHexane_Vol_txt.TabIndex = 32
        Me.NHexane_Vol_txt.Text = "80"
        Me.NHexane_Vol_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 251)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "N-Hexane Volume(ml)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Soxhlet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "R         G         B"
        '
        'Final_Blue
        '
        Me.Final_Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Final_Blue.Location = New System.Drawing.Point(213, 202)
        Me.Final_Blue.Margin = New System.Windows.Forms.Padding(2)
        Me.Final_Blue.Name = "Final_Blue"
        Me.Final_Blue.Size = New System.Drawing.Size(29, 20)
        Me.Final_Blue.TabIndex = 28
        Me.Final_Blue.Text = "132"
        Me.Final_Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Init_Blue
        '
        Me.Init_Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Init_Blue.Location = New System.Drawing.Point(213, 184)
        Me.Init_Blue.Margin = New System.Windows.Forms.Padding(2)
        Me.Init_Blue.Name = "Init_Blue"
        Me.Init_Blue.Size = New System.Drawing.Size(29, 20)
        Me.Init_Blue.TabIndex = 27
        Me.Init_Blue.Text = "0"
        Me.Init_Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Final_Green
        '
        Me.Final_Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Final_Green.Location = New System.Drawing.Point(179, 202)
        Me.Final_Green.Margin = New System.Windows.Forms.Padding(2)
        Me.Final_Green.Name = "Final_Green"
        Me.Final_Green.Size = New System.Drawing.Size(29, 20)
        Me.Final_Green.TabIndex = 26
        Me.Final_Green.Text = "164"
        Me.Final_Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Init_Green
        '
        Me.Init_Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Init_Green.Location = New System.Drawing.Point(179, 184)
        Me.Init_Green.Margin = New System.Windows.Forms.Padding(2)
        Me.Init_Green.Name = "Init_Green"
        Me.Init_Green.Size = New System.Drawing.Size(29, 20)
        Me.Init_Green.TabIndex = 25
        Me.Init_Green.Text = "128"
        Me.Init_Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Final_Red
        '
        Me.Final_Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Final_Red.Location = New System.Drawing.Point(146, 202)
        Me.Final_Red.Margin = New System.Windows.Forms.Padding(2)
        Me.Final_Red.Name = "Final_Red"
        Me.Final_Red.Size = New System.Drawing.Size(29, 20)
        Me.Final_Red.TabIndex = 24
        Me.Final_Red.Text = "196"
        Me.Final_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 205)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Raw Final Color"
        '
        'Init_Red
        '
        Me.Init_Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Init_Red.Location = New System.Drawing.Point(146, 184)
        Me.Init_Red.Margin = New System.Windows.Forms.Padding(2)
        Me.Init_Red.Name = "Init_Red"
        Me.Init_Red.Size = New System.Drawing.Size(29, 20)
        Me.Init_Red.TabIndex = 22
        Me.Init_Red.Text = "0"
        Me.Init_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 188)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Raw Initial Color"
        '
        'Loop100Ambient_txt
        '
        Me.Loop100Ambient_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Loop100Ambient_txt.Location = New System.Drawing.Point(146, 129)
        Me.Loop100Ambient_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Loop100Ambient_txt.Name = "Loop100Ambient_txt"
        Me.Loop100Ambient_txt.Size = New System.Drawing.Size(77, 20)
        Me.Loop100Ambient_txt.TabIndex = 18
        Me.Loop100Ambient_txt.Text = "27"
        Me.Loop100Ambient_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Ambient Temperature"
        '
        'Loop100_temp_response_txt
        '
        Me.Loop100_temp_response_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Loop100_temp_response_txt.Enabled = False
        Me.Loop100_temp_response_txt.Location = New System.Drawing.Point(146, 112)
        Me.Loop100_temp_response_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Loop100_temp_response_txt.Name = "Loop100_temp_response_txt"
        Me.Loop100_temp_response_txt.Size = New System.Drawing.Size(77, 20)
        Me.Loop100_temp_response_txt.TabIndex = 14
        Me.Loop100_temp_response_txt.Text = "1"
        Me.Loop100_temp_response_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Temperature Response"
        '
        'Dwell_time_txt
        '
        Me.Dwell_time_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dwell_time_txt.Location = New System.Drawing.Point(146, 147)
        Me.Dwell_time_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Dwell_time_txt.Name = "Dwell_time_txt"
        Me.Dwell_time_txt.Size = New System.Drawing.Size(77, 20)
        Me.Dwell_time_txt.TabIndex = 10
        Me.Dwell_time_txt.Text = "10"
        Me.Dwell_time_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Oven_temp_txt
        '
        Me.Oven_temp_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Oven_temp_txt.Enabled = False
        Me.Oven_temp_txt.Location = New System.Drawing.Point(146, 94)
        Me.Oven_temp_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Oven_temp_txt.Name = "Oven_temp_txt"
        Me.Oven_temp_txt.Size = New System.Drawing.Size(77, 20)
        Me.Oven_temp_txt.TabIndex = 9
        Me.Oven_temp_txt.Text = "32"
        Me.Oven_temp_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Conv_speed_lbl
        '
        Me.Conv_speed_lbl.AutoSize = True
        Me.Conv_speed_lbl.Location = New System.Drawing.Point(50, 151)
        Me.Conv_speed_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Conv_speed_lbl.Name = "Conv_speed_lbl"
        Me.Conv_speed_lbl.Size = New System.Drawing.Size(76, 13)
        Me.Conv_speed_lbl.TabIndex = 8
        Me.Conv_speed_lbl.Text = "Dwell Time (H)"
        '
        'oventemp_lbl
        '
        Me.oventemp_lbl.AutoSize = True
        Me.oventemp_lbl.Location = New System.Drawing.Point(9, 96)
        Me.oventemp_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.oventemp_lbl.Name = "oventemp_lbl"
        Me.oventemp_lbl.Size = New System.Drawing.Size(119, 13)
        Me.oventemp_lbl.TabIndex = 7
        Me.oventemp_lbl.Text = "Oven Temperature (SP)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dehydrator"
        '
        'Calamansi_vol_txt
        '
        Me.Calamansi_vol_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Calamansi_vol_txt.Location = New System.Drawing.Point(146, 51)
        Me.Calamansi_vol_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Calamansi_vol_txt.Name = "Calamansi_vol_txt"
        Me.Calamansi_vol_txt.Size = New System.Drawing.Size(77, 20)
        Me.Calamansi_vol_txt.TabIndex = 5
        Me.Calamansi_vol_txt.Text = "20"
        Me.Calamansi_vol_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Kamias_vol_txt
        '
        Me.Kamias_vol_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kamias_vol_txt.Location = New System.Drawing.Point(146, 34)
        Me.Kamias_vol_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Kamias_vol_txt.Name = "Kamias_vol_txt"
        Me.Kamias_vol_txt.Size = New System.Drawing.Size(77, 20)
        Me.Kamias_vol_txt.TabIndex = 4
        Me.Kamias_vol_txt.Text = "0"
        Me.Kamias_vol_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Calamansi
        '
        Me.Calamansi.AutoSize = True
        Me.Calamansi.Location = New System.Drawing.Point(71, 55)
        Me.Calamansi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Calamansi.Name = "Calamansi"
        Me.Calamansi.Size = New System.Drawing.Size(55, 13)
        Me.Calamansi.TabIndex = 3
        Me.Calamansi.Text = "Calamansi"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.Pause)
        Me.Panel2.Controls.Add(Me.Start)
        Me.Panel2.Controls.Add(Me.Refresh_btn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 612)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 54)
        Me.Panel2.TabIndex = 2
        '
        'Pause
        '
        Me.Pause.BackColor = System.Drawing.Color.Gold
        Me.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pause.Location = New System.Drawing.Point(259, 8)
        Me.Pause.Margin = New System.Windows.Forms.Padding(2)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(108, 38)
        Me.Pause.TabIndex = 2
        Me.Pause.Text = "Pause"
        Me.Pause.UseVisualStyleBackColor = False
        Me.Pause.Visible = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Gold
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start.Location = New System.Drawing.Point(135, 8)
        Me.Start.Margin = New System.Windows.Forms.Padding(2)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(108, 38)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Refresh_btn
        '
        Me.Refresh_btn.BackColor = System.Drawing.Color.Gold
        Me.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Refresh_btn.Location = New System.Drawing.Point(12, 8)
        Me.Refresh_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(108, 38)
        Me.Refresh_btn.TabIndex = 0
        Me.Refresh_btn.Text = "Save"
        Me.Refresh_btn.UseVisualStyleBackColor = False
        '
        'Kamias
        '
        Me.Kamias.AutoSize = True
        Me.Kamias.Location = New System.Drawing.Point(85, 35)
        Me.Kamias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Kamias.Name = "Kamias"
        Me.Kamias.Size = New System.Drawing.Size(41, 13)
        Me.Kamias.TabIndex = 1
        Me.Kamias.Text = "Kamias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Raw Materials"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(382, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(883, 666)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GrindingTank
        '
        Me.GrindingTank.BackColor = System.Drawing.Color.White
        Me.GrindingTank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GrindingTank.BorderRadius = 30
        Me.GrindingTank.BorderThickness = 1
        Me.GrindingTank.CustomizableEdges.TopLeft = False
        Me.GrindingTank.CustomizableEdges.TopRight = False
        Me.GrindingTank.FillColor = System.Drawing.Color.White
        Me.GrindingTank.Location = New System.Drawing.Point(601, 172)
        Me.GrindingTank.Margin = New System.Windows.Forms.Padding(2)
        Me.GrindingTank.Maximum = 1000
        Me.GrindingTank.Name = "GrindingTank"
        Me.GrindingTank.ShadowDecoration.BorderRadius = 0
        Me.GrindingTank.Size = New System.Drawing.Size(47, 47)
        Me.GrindingTank.TabIndex = 2
        Me.GrindingTank.Text = "Guna2VProgressBar1"
        Me.GrindingTank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Separatory_Tank
        '
        Me.Separatory_Tank.BackColor = System.Drawing.Color.White
        Me.Separatory_Tank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Separatory_Tank.BorderRadius = 50
        Me.Separatory_Tank.BorderThickness = 1
        Me.Separatory_Tank.CustomizableEdges.TopLeft = False
        Me.Separatory_Tank.CustomizableEdges.TopRight = False
        Me.Separatory_Tank.FillColor = System.Drawing.Color.White
        Me.Separatory_Tank.ForeColor = System.Drawing.Color.Black
        Me.Separatory_Tank.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Separatory_Tank.Location = New System.Drawing.Point(1046, 286)
        Me.Separatory_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.Separatory_Tank.Maximum = 800
        Me.Separatory_Tank.Name = "Separatory_Tank"
        Me.Separatory_Tank.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Separatory_Tank.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Separatory_Tank.ShadowDecoration.BorderRadius = 0
        Me.Separatory_Tank.Size = New System.Drawing.Size(89, 140)
        Me.Separatory_Tank.TabIndex = 3
        Me.Separatory_Tank.Text = "Separator"
        Me.Separatory_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'SoxhletRaw_Tank
        '
        Me.SoxhletRaw_Tank.BackColor = System.Drawing.Color.White
        Me.SoxhletRaw_Tank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SoxhletRaw_Tank.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.SoxhletRaw_Tank.BorderThickness = 1
        Me.SoxhletRaw_Tank.CustomizableEdges.TopLeft = False
        Me.SoxhletRaw_Tank.CustomizableEdges.TopRight = False
        Me.SoxhletRaw_Tank.FillColor = System.Drawing.Color.White
        Me.SoxhletRaw_Tank.ForeColor = System.Drawing.Color.Black
        Me.SoxhletRaw_Tank.Location = New System.Drawing.Point(723, 242)
        Me.SoxhletRaw_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.SoxhletRaw_Tank.Maximum = 800
        Me.SoxhletRaw_Tank.Name = "SoxhletRaw_Tank"
        Me.SoxhletRaw_Tank.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SoxhletRaw_Tank.ProgressColor2 = System.Drawing.Color.Olive
        Me.SoxhletRaw_Tank.ShadowDecoration.BorderRadius = 0
        Me.SoxhletRaw_Tank.Size = New System.Drawing.Size(44, 44)
        Me.SoxhletRaw_Tank.TabIndex = 4
        Me.SoxhletRaw_Tank.Text = "Separator"
        Me.SoxhletRaw_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Condensed_Tank
        '
        Me.Condensed_Tank.BackColor = System.Drawing.Color.Transparent
        Me.Condensed_Tank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Condensed_Tank.CustomizableEdges.TopLeft = False
        Me.Condensed_Tank.CustomizableEdges.TopRight = False
        Me.Condensed_Tank.FillColor = System.Drawing.Color.White
        Me.Condensed_Tank.ForeColor = System.Drawing.Color.Black
        Me.Condensed_Tank.Location = New System.Drawing.Point(710, 242)
        Me.Condensed_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.Condensed_Tank.Maximum = 1500
        Me.Condensed_Tank.Name = "Condensed_Tank"
        Me.Condensed_Tank.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Condensed_Tank.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Condensed_Tank.ShadowDecoration.BorderRadius = 0
        Me.Condensed_Tank.Size = New System.Drawing.Size(70, 55)
        Me.Condensed_Tank.TabIndex = 5
        Me.Condensed_Tank.Text = "Separator"
        Me.Condensed_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Condensed_Tank.UseTransparentBackground = True
        '
        'Soxhlet_Tank
        '
        Me.Soxhlet_Tank.BackColor = System.Drawing.Color.Transparent
        Me.Soxhlet_Tank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Soxhlet_Tank.CustomizableEdges.TopLeft = False
        Me.Soxhlet_Tank.CustomizableEdges.TopRight = False
        Me.Soxhlet_Tank.FillColor = System.Drawing.Color.Transparent
        Me.Soxhlet_Tank.ForeColor = System.Drawing.Color.Black
        Me.Soxhlet_Tank.Location = New System.Drawing.Point(709, 301)
        Me.Soxhlet_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.Soxhlet_Tank.Maximum = 1500
        Me.Soxhlet_Tank.Name = "Soxhlet_Tank"
        Me.Soxhlet_Tank.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Soxhlet_Tank.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Soxhlet_Tank.ShadowDecoration.BorderRadius = 0
        Me.Soxhlet_Tank.Size = New System.Drawing.Size(71, 55)
        Me.Soxhlet_Tank.TabIndex = 6
        Me.Soxhlet_Tank.Text = "Separator"
        Me.Soxhlet_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Soxhlet_Tank.UseTransparentBackground = True
        '
        'Hexane_Extract_tank
        '
        Me.Hexane_Extract_tank.BackColor = System.Drawing.Color.Transparent
        Me.Hexane_Extract_tank.CustomizableEdges.TopLeft = False
        Me.Hexane_Extract_tank.CustomizableEdges.TopRight = False
        Me.Hexane_Extract_tank.FillColor = System.Drawing.Color.Transparent
        Me.Hexane_Extract_tank.ForeColor = System.Drawing.Color.Black
        Me.Hexane_Extract_tank.Location = New System.Drawing.Point(716, 426)
        Me.Hexane_Extract_tank.Margin = New System.Windows.Forms.Padding(2)
        Me.Hexane_Extract_tank.Maximum = 600
        Me.Hexane_Extract_tank.Name = "Hexane_Extract_tank"
        Me.Hexane_Extract_tank.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Hexane_Extract_tank.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Hexane_Extract_tank.ShadowDecoration.BorderRadius = 0
        Me.Hexane_Extract_tank.Size = New System.Drawing.Size(56, 46)
        Me.Hexane_Extract_tank.TabIndex = 14
        Me.Hexane_Extract_tank.Text = "Separator"
        Me.Hexane_Extract_tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Hexane_Extract_tank.UseTransparentBackground = True
        '
        'Methanol_tank
        '
        Me.Methanol_tank.BackColor = System.Drawing.Color.Transparent
        Me.Methanol_tank.CustomizableEdges.TopLeft = False
        Me.Methanol_tank.CustomizableEdges.TopRight = False
        Me.Methanol_tank.FillColor = System.Drawing.Color.White
        Me.Methanol_tank.ForeColor = System.Drawing.Color.Black
        Me.Methanol_tank.Location = New System.Drawing.Point(776, 491)
        Me.Methanol_tank.Margin = New System.Windows.Forms.Padding(2)
        Me.Methanol_tank.Maximum = 600
        Me.Methanol_tank.Name = "Methanol_tank"
        Me.Methanol_tank.ProgressColor = System.Drawing.Color.Silver
        Me.Methanol_tank.ProgressColor2 = System.Drawing.Color.Silver
        Me.Methanol_tank.ShadowDecoration.BorderRadius = 0
        Me.Methanol_tank.Size = New System.Drawing.Size(55, 55)
        Me.Methanol_tank.TabIndex = 17
        Me.Methanol_tank.Text = "Separator"
        Me.Methanol_tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Methanol_tank.UseTransparentBackground = True
        '
        'NHexane_Tank
        '
        Me.NHexane_Tank.BackColor = System.Drawing.Color.Transparent
        Me.NHexane_Tank.CustomizableEdges.TopLeft = False
        Me.NHexane_Tank.CustomizableEdges.TopRight = False
        Me.NHexane_Tank.FillColor = System.Drawing.Color.White
        Me.NHexane_Tank.ForeColor = System.Drawing.Color.Black
        Me.NHexane_Tank.Location = New System.Drawing.Point(844, 228)
        Me.NHexane_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.NHexane_Tank.Maximum = 1500
        Me.NHexane_Tank.Name = "NHexane_Tank"
        Me.NHexane_Tank.ProgressColor = System.Drawing.Color.Silver
        Me.NHexane_Tank.ProgressColor2 = System.Drawing.Color.Silver
        Me.NHexane_Tank.ShadowDecoration.BorderRadius = 0
        Me.NHexane_Tank.Size = New System.Drawing.Size(55, 55)
        Me.NHexane_Tank.TabIndex = 18
        Me.NHexane_Tank.Text = "Separator"
        Me.NHexane_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.NHexane_Tank.UseTransparentBackground = True
        '
        'Trans_Tank
        '
        Me.Trans_Tank.BackColor = System.Drawing.Color.Transparent
        Me.Trans_Tank.CustomizableEdges.TopLeft = False
        Me.Trans_Tank.CustomizableEdges.TopRight = False
        Me.Trans_Tank.FillColor = System.Drawing.Color.Transparent
        Me.Trans_Tank.ForeColor = System.Drawing.Color.Black
        Me.Trans_Tank.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Trans_Tank.Location = New System.Drawing.Point(909, 491)
        Me.Trans_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.Trans_Tank.Maximum = 200
        Me.Trans_Tank.Name = "Trans_Tank"
        Me.Trans_Tank.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Trans_Tank.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Trans_Tank.ShadowDecoration.BorderRadius = 0
        Me.Trans_Tank.Size = New System.Drawing.Size(89, 88)
        Me.Trans_Tank.TabIndex = 19
        Me.Trans_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Trans_Tank.UseTransparentBackground = True
        '
        'BioFuel_Tank
        '
        Me.BioFuel_Tank.BackColor = System.Drawing.Color.Transparent
        Me.BioFuel_Tank.CustomizableEdges.TopLeft = False
        Me.BioFuel_Tank.CustomizableEdges.TopRight = False
        Me.BioFuel_Tank.FillColor = System.Drawing.Color.Transparent
        Me.BioFuel_Tank.ForeColor = System.Drawing.Color.Black
        Me.BioFuel_Tank.Location = New System.Drawing.Point(1053, 525)
        Me.BioFuel_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.BioFuel_Tank.Maximum = 300
        Me.BioFuel_Tank.Name = "BioFuel_Tank"
        Me.BioFuel_Tank.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BioFuel_Tank.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BioFuel_Tank.ShadowDecoration.BorderRadius = 0
        Me.BioFuel_Tank.Size = New System.Drawing.Size(75, 72)
        Me.BioFuel_Tank.TabIndex = 20
        Me.BioFuel_Tank.Text = "Separator"
        Me.BioFuel_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BioFuel_Tank.UseTransparentBackground = True
        '
        'Water_Waste_Tank
        '
        Me.Water_Waste_Tank.BackColor = System.Drawing.Color.Transparent
        Me.Water_Waste_Tank.CustomizableEdges.TopLeft = False
        Me.Water_Waste_Tank.CustomizableEdges.TopRight = False
        Me.Water_Waste_Tank.FillColor = System.Drawing.Color.White
        Me.Water_Waste_Tank.ForeColor = System.Drawing.Color.Black
        Me.Water_Waste_Tank.Location = New System.Drawing.Point(1181, 525)
        Me.Water_Waste_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.Water_Waste_Tank.Maximum = 2000
        Me.Water_Waste_Tank.Name = "Water_Waste_Tank"
        Me.Water_Waste_Tank.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Water_Waste_Tank.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Water_Waste_Tank.ShadowDecoration.BorderRadius = 0
        Me.Water_Waste_Tank.Size = New System.Drawing.Size(51, 65)
        Me.Water_Waste_Tank.TabIndex = 21
        Me.Water_Waste_Tank.Text = "Separator"
        Me.Water_Waste_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Water_Waste_Tank.UseTransparentBackground = True
        '
        'Catalyst_Tank
        '
        Me.Catalyst_Tank.BackColor = System.Drawing.Color.White
        Me.Catalyst_Tank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Catalyst_Tank.BorderRadius = 30
        Me.Catalyst_Tank.BorderThickness = 1
        Me.Catalyst_Tank.CustomizableEdges.TopLeft = False
        Me.Catalyst_Tank.CustomizableEdges.TopRight = False
        Me.Catalyst_Tank.FillColor = System.Drawing.Color.White
        Me.Catalyst_Tank.Location = New System.Drawing.Point(869, 400)
        Me.Catalyst_Tank.Margin = New System.Windows.Forms.Padding(2)
        Me.Catalyst_Tank.Maximum = 50
        Me.Catalyst_Tank.Name = "Catalyst_Tank"
        Me.Catalyst_Tank.ShadowDecoration.BorderRadius = 0
        Me.Catalyst_Tank.Size = New System.Drawing.Size(42, 43)
        Me.Catalyst_Tank.TabIndex = 22
        Me.Catalyst_Tank.Text = "Guna2VProgressBar12"
        Me.Catalyst_Tank.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'RawMats
        '
        Me.RawMats.BorderColor = System.Drawing.Color.White
        Me.RawMats.FillColor = System.Drawing.Color.Empty
        Me.RawMats.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RawMats.Location = New System.Drawing.Point(445, 122)
        Me.RawMats.Margin = New System.Windows.Forms.Padding(2)
        Me.RawMats.Name = "RawMats"
        Me.RawMats.PolygonSkip = 1
        Me.RawMats.Rotate = 0!
        Me.RawMats.RoundedRadius = 2
        Me.RawMats.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.RawMats.Size = New System.Drawing.Size(39, 17)
        Me.RawMats.TabIndex = 0
        Me.RawMats.TabStop = False
        Me.RawMats.Tag = ""
        Me.RawMats.Zoom = 100
        '
        'RawAnimation_timer
        '
        '
        'Loop100PV
        '
        Me.Loop100PV.BorderRadius = 5
        Me.Loop100PV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Loop100PV.DefaultText = ""
        Me.Loop100PV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Loop100PV.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Loop100PV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop100PV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop100PV.FillColor = System.Drawing.Color.DimGray
        Me.Loop100PV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop100PV.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop100PV.ForeColor = System.Drawing.Color.Gold
        Me.Loop100PV.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop100PV.Location = New System.Drawing.Point(499, 11)
        Me.Loop100PV.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Loop100PV.Name = "Loop100PV"
        Me.Loop100PV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Loop100PV.PlaceholderText = ""
        Me.Loop100PV.SelectedText = ""
        Me.Loop100PV.Size = New System.Drawing.Size(43, 16)
        Me.Loop100PV.TabIndex = 13
        Me.Loop100PV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Loop100SP
        '
        Me.Loop100SP.BorderRadius = 5
        Me.Loop100SP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Loop100SP.DefaultText = ""
        Me.Loop100SP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Loop100SP.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Loop100SP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop100SP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop100SP.FillColor = System.Drawing.Color.Orange
        Me.Loop100SP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop100SP.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop100SP.ForeColor = System.Drawing.Color.Red
        Me.Loop100SP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop100SP.Location = New System.Drawing.Point(452, 11)
        Me.Loop100SP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Loop100SP.Name = "Loop100SP"
        Me.Loop100SP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Loop100SP.PlaceholderText = ""
        Me.Loop100SP.SelectedText = ""
        Me.Loop100SP.Size = New System.Drawing.Size(43, 16)
        Me.Loop100SP.TabIndex = 23
        Me.Loop100SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Loop100_timer
        '
        '
        'Oven_Dwell_timer
        '
        Me.Oven_Dwell_timer.Interval = 1000
        '
        'RawDrop_Timer
        '
        '
        'Nhexane_Dispense_Timer
        '
        Me.Nhexane_Dispense_Timer.Interval = 3
        '
        'Loop104_SP
        '
        Me.Loop104_SP.BorderRadius = 5
        Me.Loop104_SP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Loop104_SP.DefaultText = ""
        Me.Loop104_SP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Loop104_SP.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Loop104_SP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop104_SP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop104_SP.FillColor = System.Drawing.Color.Orange
        Me.Loop104_SP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop104_SP.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop104_SP.ForeColor = System.Drawing.Color.Red
        Me.Loop104_SP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop104_SP.Location = New System.Drawing.Point(565, 332)
        Me.Loop104_SP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Loop104_SP.Name = "Loop104_SP"
        Me.Loop104_SP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Loop104_SP.PlaceholderText = ""
        Me.Loop104_SP.SelectedText = ""
        Me.Loop104_SP.Size = New System.Drawing.Size(43, 16)
        Me.Loop104_SP.TabIndex = 26
        Me.Loop104_SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Loop104_PV
        '
        Me.Loop104_PV.BorderRadius = 5
        Me.Loop104_PV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Loop104_PV.DefaultText = ""
        Me.Loop104_PV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Loop104_PV.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Loop104_PV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop104_PV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop104_PV.FillColor = System.Drawing.Color.DimGray
        Me.Loop104_PV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop104_PV.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop104_PV.ForeColor = System.Drawing.Color.Gold
        Me.Loop104_PV.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop104_PV.Location = New System.Drawing.Point(611, 332)
        Me.Loop104_PV.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Loop104_PV.Name = "Loop104_PV"
        Me.Loop104_PV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Loop104_PV.PlaceholderText = ""
        Me.Loop104_PV.SelectedText = ""
        Me.Loop104_PV.Size = New System.Drawing.Size(43, 16)
        Me.Loop104_PV.TabIndex = 25
        Me.Loop104_PV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Soxhlet_temp_timer
        '
        '
        'SoxhletProcess_timer
        '
        '
        'Hexane_Extract_time
        '
        '
        'Hexane_Extract_temp_time
        '
        '
        'Nhexane_SP
        '
        Me.Nhexane_SP.BorderRadius = 5
        Me.Nhexane_SP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nhexane_SP.DefaultText = ""
        Me.Nhexane_SP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Nhexane_SP.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Nhexane_SP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Nhexane_SP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Nhexane_SP.FillColor = System.Drawing.Color.Orange
        Me.Nhexane_SP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nhexane_SP.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhexane_SP.ForeColor = System.Drawing.Color.Red
        Me.Nhexane_SP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nhexane_SP.Location = New System.Drawing.Point(605, 482)
        Me.Nhexane_SP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Nhexane_SP.Name = "Nhexane_SP"
        Me.Nhexane_SP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Nhexane_SP.PlaceholderText = ""
        Me.Nhexane_SP.SelectedText = ""
        Me.Nhexane_SP.Size = New System.Drawing.Size(43, 16)
        Me.Nhexane_SP.TabIndex = 28
        Me.Nhexane_SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nhexane_PV
        '
        Me.Nhexane_PV.BorderRadius = 5
        Me.Nhexane_PV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nhexane_PV.DefaultText = ""
        Me.Nhexane_PV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Nhexane_PV.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Nhexane_PV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Nhexane_PV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Nhexane_PV.FillColor = System.Drawing.Color.DimGray
        Me.Nhexane_PV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nhexane_PV.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhexane_PV.ForeColor = System.Drawing.Color.Gold
        Me.Nhexane_PV.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nhexane_PV.Location = New System.Drawing.Point(652, 482)
        Me.Nhexane_PV.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Nhexane_PV.Name = "Nhexane_PV"
        Me.Nhexane_PV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Nhexane_PV.PlaceholderText = ""
        Me.Nhexane_PV.SelectedText = ""
        Me.Nhexane_PV.Size = New System.Drawing.Size(43, 16)
        Me.Nhexane_PV.TabIndex = 27
        Me.Nhexane_PV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Trans_timer
        '
        '
        'Trans_Color_Timer
        '
        Me.Trans_Color_Timer.Interval = 1000
        '
        'TransTopBar
        '
        Me.TransTopBar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TransTopBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.TransTopBar.Location = New System.Drawing.Point(909, 491)
        Me.TransTopBar.Margin = New System.Windows.Forms.Padding(2)
        Me.TransTopBar.Name = "TransTopBar"
        Me.TransTopBar.PolygonSkip = 1
        Me.TransTopBar.Rotate = 0!
        Me.TransTopBar.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.TransTopBar.Size = New System.Drawing.Size(89, 1)
        Me.TransTopBar.TabIndex = 29
        Me.TransTopBar.Text = "Guna2Shapes1"
        Me.TransTopBar.Visible = False
        Me.TransTopBar.Zoom = 100
        '
        'Filter_Timer
        '
        '
        'Water_Fill_Timer
        '
        '
        'Wash_Wait_Timer
        '
        Me.Wash_Wait_Timer.Interval = 1000
        '
        'Water_Drain_Timer
        '
        '
        'BioFuel_Fill_Timer
        '
        Me.BioFuel_Fill_Timer.Interval = 10
        '
        'Loop111_Heat_Timer
        '
        '
        'Loop111_SP
        '
        Me.Loop111_SP.BorderRadius = 5
        Me.Loop111_SP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Loop111_SP.DefaultText = ""
        Me.Loop111_SP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Loop111_SP.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Loop111_SP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop111_SP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop111_SP.FillColor = System.Drawing.Color.Orange
        Me.Loop111_SP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop111_SP.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop111_SP.ForeColor = System.Drawing.Color.Red
        Me.Loop111_SP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop111_SP.Location = New System.Drawing.Point(1098, 629)
        Me.Loop111_SP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Loop111_SP.Name = "Loop111_SP"
        Me.Loop111_SP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Loop111_SP.PlaceholderText = ""
        Me.Loop111_SP.SelectedText = ""
        Me.Loop111_SP.Size = New System.Drawing.Size(43, 16)
        Me.Loop111_SP.TabIndex = 31
        Me.Loop111_SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Loop111_PV
        '
        Me.Loop111_PV.BorderRadius = 5
        Me.Loop111_PV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Loop111_PV.DefaultText = ""
        Me.Loop111_PV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Loop111_PV.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Loop111_PV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop111_PV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Loop111_PV.FillColor = System.Drawing.Color.DimGray
        Me.Loop111_PV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop111_PV.Font = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loop111_PV.ForeColor = System.Drawing.Color.Gold
        Me.Loop111_PV.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loop111_PV.Location = New System.Drawing.Point(1098, 645)
        Me.Loop111_PV.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Loop111_PV.Name = "Loop111_PV"
        Me.Loop111_PV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Loop111_PV.PlaceholderText = ""
        Me.Loop111_PV.SelectedText = ""
        Me.Loop111_PV.Size = New System.Drawing.Size(43, 16)
        Me.Loop111_PV.TabIndex = 30
        Me.Loop111_PV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RemoveWater_Timer
        '
        Me.RemoveWater_Timer.Interval = 1000
        '
        'dried_out
        '
        Me.dried_out.AutoSize = True
        Me.dried_out.BackColor = System.Drawing.Color.White
        Me.dried_out.Location = New System.Drawing.Point(653, 179)
        Me.dried_out.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dried_out.Name = "dried_out"
        Me.dried_out.Size = New System.Drawing.Size(13, 13)
        Me.dried_out.TabIndex = 32
        Me.dried_out.Text = "0"
        Me.dried_out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nhexaneShow
        '
        Me.nhexaneShow.BackColor = System.Drawing.Color.White
        Me.nhexaneShow.Location = New System.Drawing.Point(776, 434)
        Me.nhexaneShow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nhexaneShow.Name = "nhexaneShow"
        Me.nhexaneShow.Size = New System.Drawing.Size(40, 14)
        Me.nhexaneShow.TabIndex = 33
        Me.nhexaneShow.Text = "0"
        Me.nhexaneShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'catalystShow
        '
        Me.catalystShow.AutoSize = True
        Me.catalystShow.BackColor = System.Drawing.Color.White
        Me.catalystShow.Location = New System.Drawing.Point(915, 403)
        Me.catalystShow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.catalystShow.Name = "catalystShow"
        Me.catalystShow.Size = New System.Drawing.Size(13, 13)
        Me.catalystShow.TabIndex = 34
        Me.catalystShow.Text = "0"
        Me.catalystShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.catalystShow.Visible = False
        '
        'methanolShow
        '
        Me.methanolShow.AutoSize = True
        Me.methanolShow.BackColor = System.Drawing.Color.White
        Me.methanolShow.Location = New System.Drawing.Point(835, 495)
        Me.methanolShow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.methanolShow.Name = "methanolShow"
        Me.methanolShow.Size = New System.Drawing.Size(13, 13)
        Me.methanolShow.TabIndex = 35
        Me.methanolShow.Text = "0"
        Me.methanolShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.methanolShow.Visible = False
        '
        'TransShow
        '
        Me.TransShow.AutoSize = True
        Me.TransShow.BackColor = System.Drawing.Color.White
        Me.TransShow.Location = New System.Drawing.Point(949, 476)
        Me.TransShow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TransShow.Name = "TransShow"
        Me.TransShow.Size = New System.Drawing.Size(13, 13)
        Me.TransShow.TabIndex = 37
        Me.TransShow.Text = "0"
        Me.TransShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransShow.Visible = False
        '
        'SeparatoryShow
        '
        Me.SeparatoryShow.AutoSize = True
        Me.SeparatoryShow.BackColor = System.Drawing.Color.White
        Me.SeparatoryShow.Location = New System.Drawing.Point(1139, 301)
        Me.SeparatoryShow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SeparatoryShow.Name = "SeparatoryShow"
        Me.SeparatoryShow.Size = New System.Drawing.Size(13, 13)
        Me.SeparatoryShow.TabIndex = 38
        Me.SeparatoryShow.Text = "0"
        Me.SeparatoryShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SeparatoryShow.Visible = False
        '
        'separatorunit
        '
        Me.separatorunit.AutoSize = True
        Me.separatorunit.BackColor = System.Drawing.Color.White
        Me.separatorunit.Location = New System.Drawing.Point(1139, 316)
        Me.separatorunit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.separatorunit.Name = "separatorunit"
        Me.separatorunit.Size = New System.Drawing.Size(17, 13)
        Me.separatorunit.TabIndex = 39
        Me.separatorunit.Text = "ml"
        Me.separatorunit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.separatorunit.Visible = False
        '
        'biofuelunit
        '
        Me.biofuelunit.AutoSize = True
        Me.biofuelunit.BackColor = System.Drawing.Color.White
        Me.biofuelunit.Location = New System.Drawing.Point(1133, 536)
        Me.biofuelunit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.biofuelunit.Name = "biofuelunit"
        Me.biofuelunit.Size = New System.Drawing.Size(17, 13)
        Me.biofuelunit.TabIndex = 41
        Me.biofuelunit.Text = "ml"
        Me.biofuelunit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.biofuelunit.Visible = False
        '
        'biofuelShow
        '
        Me.biofuelShow.AutoSize = True
        Me.biofuelShow.BackColor = System.Drawing.Color.White
        Me.biofuelShow.Location = New System.Drawing.Point(1133, 521)
        Me.biofuelShow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.biofuelShow.Name = "biofuelShow"
        Me.biofuelShow.Size = New System.Drawing.Size(13, 13)
        Me.biofuelShow.TabIndex = 40
        Me.biofuelShow.Text = "0"
        Me.biofuelShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.biofuelShow.Visible = False
        '
        'Cutter
        '
        Me.Cutter.BorderColor = System.Drawing.Color.Black
        Me.Cutter.BorderThickness = 1
        Me.Cutter.FillColor = System.Drawing.Color.Empty
        Me.Cutter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cutter.Location = New System.Drawing.Point(491, 101)
        Me.Cutter.Margin = New System.Windows.Forms.Padding(2)
        Me.Cutter.Name = "Cutter"
        Me.Cutter.PolygonSkip = 1
        Me.Cutter.Rotate = 0!
        Me.Cutter.RoundedRadius = 2
        Me.Cutter.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Cutter.Size = New System.Drawing.Size(41, 13)
        Me.Cutter.TabIndex = 42
        Me.Cutter.TabStop = False
        Me.Cutter.Tag = ""
        Me.Cutter.Zoom = 100
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 666)
        Me.Controls.Add(Me.Cutter)
        Me.Controls.Add(Me.biofuelunit)
        Me.Controls.Add(Me.biofuelShow)
        Me.Controls.Add(Me.separatorunit)
        Me.Controls.Add(Me.SeparatoryShow)
        Me.Controls.Add(Me.TransShow)
        Me.Controls.Add(Me.methanolShow)
        Me.Controls.Add(Me.catalystShow)
        Me.Controls.Add(Me.nhexaneShow)
        Me.Controls.Add(Me.dried_out)
        Me.Controls.Add(Me.Loop111_SP)
        Me.Controls.Add(Me.Loop111_PV)
        Me.Controls.Add(Me.TransTopBar)
        Me.Controls.Add(Me.Nhexane_SP)
        Me.Controls.Add(Me.Nhexane_PV)
        Me.Controls.Add(Me.Soxhlet_Tank)
        Me.Controls.Add(Me.Loop104_SP)
        Me.Controls.Add(Me.Loop104_PV)
        Me.Controls.Add(Me.Loop100SP)
        Me.Controls.Add(Me.Loop100PV)
        Me.Controls.Add(Me.RawMats)
        Me.Controls.Add(Me.Catalyst_Tank)
        Me.Controls.Add(Me.Water_Waste_Tank)
        Me.Controls.Add(Me.BioFuel_Tank)
        Me.Controls.Add(Me.Trans_Tank)
        Me.Controls.Add(Me.NHexane_Tank)
        Me.Controls.Add(Me.Methanol_tank)
        Me.Controls.Add(Me.Hexane_Extract_tank)
        Me.Controls.Add(Me.SoxhletRaw_Tank)
        Me.Controls.Add(Me.Condensed_Tank)
        Me.Controls.Add(Me.Separatory_Tank)
        Me.Controls.Add(Me.GrindingTank)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bio Fuel Simulation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Pause As Button
    Friend WithEvents Start As Button
    Friend WithEvents Refresh_btn As Button
    Friend WithEvents Kamias As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Kamias_vol_txt As TextBox
    Friend WithEvents Calamansi As Label
    Friend WithEvents Calamansi_vol_txt As TextBox
    Friend WithEvents Dwell_time_txt As TextBox
    Friend WithEvents Oven_temp_txt As TextBox
    Friend WithEvents Conv_speed_lbl As Label
    Friend WithEvents oventemp_lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GrindingTank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Separatory_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents SoxhletRaw_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Condensed_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Soxhlet_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Hexane_Extract_tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Methanol_tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents NHexane_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Trans_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents BioFuel_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Water_Waste_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Catalyst_Tank As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents RawMats As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents RawAnimation_timer As Timer
    Friend WithEvents Loop100PV As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Loop100SP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Loop100_temp_response_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Loop100_timer As Timer
    Friend WithEvents Loop100Ambient_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Oven_Dwell_timer As Timer
    Friend WithEvents Final_Red As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Init_Red As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Final_Blue As TextBox
    Friend WithEvents Init_Blue As TextBox
    Friend WithEvents Final_Green As TextBox
    Friend WithEvents Init_Green As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RawDrop_Timer As Timer
    Friend WithEvents Nhexane_Dispense_Timer As Timer
    Friend WithEvents NHexane_Vol_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Soxhlet_SetTemp As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Loop104_SP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Loop104_PV As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Soxhlet_temp_timer As Timer
    Friend WithEvents SoxhletProcess_timer As Timer
    Friend WithEvents Soxhlet_Duration_txt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Hexane_Extract_time As Timer
    Friend WithEvents Hexane_Extract_temp_time As Timer
    Friend WithEvents Nhexane_Duration As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Nhexane_Temp As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Nhexane_SP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Nhexane_PV As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Trans_timer As Timer
    Friend WithEvents Catalyst_Volume As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Methanol_Volume As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Trans_Color_Timer As Timer
    Friend WithEvents Trans_Duration As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TransTopBar As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Filter_Timer As Timer
    Friend WithEvents Wash_Qty As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Wash_Wait As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Water_Volume As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Water_Fill_Timer As Timer
    Friend WithEvents Wash_Wait_Timer As Timer
    Friend WithEvents Water_Drain_Timer As Timer
    Friend WithEvents BioFuel_Fill_Timer As Timer
    Friend WithEvents Loop111_Heat_Timer As Timer
    Friend WithEvents BioFuelTemp_SP As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Loop111_SP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Loop111_PV As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RemoveWater_Timer As Timer
    Friend WithEvents Heating_Time As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents dried_out As Label
    Friend WithEvents FFButton As Button
    Friend WithEvents nhexaneShow As Label
    Friend WithEvents catalystShow As Label
    Friend WithEvents methanolShow As Label
    Friend WithEvents TransShow As Label
    Friend WithEvents SeparatoryShow As Label
    Friend WithEvents Extracted_Volume As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents separatorunit As Label
    Friend WithEvents biofuelunit As Label
    Friend WithEvents biofuelShow As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents FFTrans As Button
    Friend WithEvents Cutter As Guna.UI2.WinForms.Guna2Shapes
End Class
