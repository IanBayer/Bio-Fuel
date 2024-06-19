Imports System.Configuration
Public Class Main
    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDefault()
        GrindingTank.Value = 0
        GrindingTank.ProgressColor = Color.FromArgb(CInt(Final_Red.Text), CInt(Final_Green.Text), CInt(Final_Blue.Text))
        GrindingTank.ProgressColor2 = Color.FromArgb(CInt(Final_Red.Text), CInt(Final_Green.Text), CInt(Final_Blue.Text))
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        'RawAnimation_timer.Enabled = True
        Loop100_timer.Enabled = True
        Loop100PV.Text = Loop100Ambient_txt.Text
        Loop100SP.Text = Oven_temp_txt.Text
        NHexane_Tank.Value = NHexane_Vol_txt.Text
        Loop104_SP.Text = Soxhlet_SetTemp.Text
        Loop104_PV.Text = Loop100Ambient_txt.Text
        Nhexane_SP.Text = Nhexane_Temp.Text
        Nhexane_PV.Text = Loop100Ambient_txt.Text
        nhexaneShow.Visible = False
        'Methanol_tank.Value = Methanol_Volume.Text
        'Catalyst_Tank.Value = Catalyst_Volume.Text
        Loop111_SP.Text = BioFuelTemp_SP.Text
        Loop111_PV.Text = Loop100Ambient_txt.Text
        dried_out.Visible = False
    End Sub


    Private Sub Loop100_timer_Tick(sender As Object, e As EventArgs) Handles Loop100_timer.Tick
        If Loop100PV.Text = "" Then
            Loop100PV.Text = Loop100Ambient_txt.Text
            Loop100SP.Text = Oven_temp_txt.Text

        End If
        Loop100PV.Text += CInt(Loop100_temp_response_txt.Text)
        If CInt(Loop100PV.Text) >= CInt(Loop100SP.Text) Then
            Loop100PV.Text = Loop100SP.Text
            Loop100_timer.Enabled = False
            RawAnimation_timer.Enabled = True
            RawMats.FillColor = Color.FromArgb(Init_Red.Text, Init_Green.Text, Init_Blue.Text)
            newlocation = Cutter.Location.Y + 13
            oldlocation = Cutter.Location.Y
        End If

    End Sub
    Public RawRedColor As Integer
    Public RawGreenColor As Integer
    Public RawBlueColor As Integer
    Public DwellCounter As Integer
    Public cutterdown As Boolean
    Public cutterduration As Integer
    Public newlocation As Integer
    Public oldlocation As Integer

    Private Sub RawAnimation_timer_Tick(sender As Object, e As EventArgs) Handles RawAnimation_timer.Tick
        RawMats.Location = New Point(RawMats.Location.X + 1, RawMats.Location.Y)
        cutterduration += 1
        If cutterdown = False Then
            Cutter.Location = New Point(Cutter.Location.X, newlocation)
            cutterdown = True
        Else
            If cutterduration >= 2 Then
                Cutter.Location = New Point(Cutter.Location.X, oldlocation)
            End If
            If cutterduration >= 5 Then
                cutterdown = False

                cutterduration = 0
            End If
        End If
        If RawMats.Location.X >= 557 Then
            RawMats.Location = New Point(557, RawMats.Location.Y)
            Cutter.Location = New Point(Cutter.Location.X, oldlocation)
            RawAnimation_timer.Enabled = False
            Oven_Dwell_timer.Enabled = True


        End If
    End Sub
    Private Sub Oven_Dwell_timer_Tick(sender As Object, e As EventArgs) Handles Oven_Dwell_timer.Tick
        DwellCounter += 1
        RawRedColor = (DwellCounter / (CInt(Dwell_time_txt.Text))) * (CInt(Final_Red.Text) - CInt(Init_Red.Text))
        RawGreenColor = ((DwellCounter / (CInt(Dwell_time_txt.Text))) * (CInt(Final_Green.Text) - CInt(Init_Green.Text))) + CInt(Init_Green.Text)
        RawBlueColor = (DwellCounter / (CInt(Dwell_time_txt.Text))) * (CInt(Final_Blue.Text) - CInt(Init_Blue.Text))

        'Console.WriteLine(RawRedColor & ", " & RawGreenColor & ", " & RawBlueColor)
        RawMats.FillColor = Color.FromArgb(RawRedColor, RawGreenColor, RawBlueColor)
        If DwellCounter >= CInt(Dwell_time_txt.Text) Then
            Oven_Dwell_timer.Enabled = False
            RawDrop_Timer.Enabled = True
        End If
    End Sub


    Dim grinding As Boolean
    Private Sub RawDrop_Timer_Tick(sender As Object, e As EventArgs) Handles RawDrop_Timer.Tick
        If grinding = False Then
            RawMats.Location = New Point(RawMats.Location.X + 1, RawMats.Location.Y)
            If RawMats.Location.X >= 600 Then
                RawMats.Location = New Point(600, RawMats.Location.Y)
                RawDrop_Timer.Enabled = False
                Threading.Thread.Sleep(500)
                RawMats.Visible = False
                Threading.Thread.Sleep(500)
                GrindingTank.Value = ((CDec(Kamias_vol_txt.Text) * 0.1) + (CDec(Calamansi_vol_txt.Text) * 0.12)) * 1000 'calculate the proportion of fresh raw vs. grinded 
                dried_out.Visible = True
                dried_out.Text = Math.Round(((CDec(Kamias_vol_txt.Text) * 0.1) + (CDec(Calamansi_vol_txt.Text) * 0.12)) * 1000, 2) & " g"
                grinding = True
                RawDrop_Timer.Interval = 500
                RawDrop_Timer.Enabled = True
            End If
        Else

            If GrindingTank.Value > 0 Then
                SoxhletRaw_Tank.Value = SoxhletRaw_Tank.Value + 10
                GrindingTank.Value = GrindingTank.Value - 10
            Else
                RawDrop_Timer.Enabled = False
                Nhexane_Dispense_Timer.Enabled = True
            End If
        End If

    End Sub

    Private Sub Nhexane_Dispense_Timer_Tick(sender As Object, e As EventArgs) Handles Nhexane_Dispense_Timer.Tick
        'transfer N-Hexane to soxhlet tank
        If NHexane_Tank.Value > 0 Then
            NHexane_Tank.Value -= 100

            Soxhlet_Tank.Value += 100
        Else
            NHexane_Tank.Value = 0
            Soxhlet_Tank.Value = NHexane_Vol_txt.Text
            Nhexane_Dispense_Timer.Enabled = False
            Soxhlet_temp_timer.Enabled = True
        End If
    End Sub

    Private Sub Soxhlet_temp_timer_Tick(sender As Object, e As EventArgs) Handles Soxhlet_temp_timer.Tick
        If CInt(Loop104_PV.Text) < CInt(Loop104_SP.Text) Then
            Loop104_PV.Text += CInt(Loop100_temp_response_txt.Text)
            If CInt(Loop104_PV.Text) >= CInt(Loop104_SP.Text) Then
                Loop104_PV.Text = Loop104_SP.Text
                Soxhlet_temp_timer.Enabled = False
                Threading.Thread.Sleep(5000)
                SoxhletProcess_timer.Enabled = True
                FFButton.Visible = True
            End If
        End If
    End Sub
    Public cycle As Boolean
    Public duration As Integer
    Public afterSoxhletmL As Integer
    Private Sub SoxhletProcess_timer_Tick(sender As Object, e As EventArgs) Handles SoxhletProcess_timer.Tick
        duration += 1
        If Not cycle Then
            If Soxhlet_Tank.Value > 0 Then
                Soxhlet_Tank.Value = CInt(Soxhlet_Tank.Value) - 10
                Condensed_Tank.Value = CInt(Condensed_Tank.Value) + 10
            Else
                cycle = True
            End If
        Else
            Soxhlet_Tank.ProgressColor = Color.FromArgb(0, 53, 24) 'change the soxhlet color similar to condensed tank after 1 cycle
            Soxhlet_Tank.ProgressColor2 = Color.FromArgb(0, 53, 24)
            If Condensed_Tank.Value > 0 Then
                Soxhlet_Tank.Value += 20
                Condensed_Tank.Value -= 20
            Else
                cycle = False
                If duration >= CInt(Soxhlet_Duration_txt.Text) * 3600 Then 'multiply by 3600 to convert hours to seconds
                    SoxhletProcess_timer.Enabled = False
                    Hexane_Extract_time.Enabled = True
                    Condensed_Tank.Value = 0
                    Soxhlet_Tank.Value = CInt(NHexane_Vol_txt.Text) * 0.45
                    FFButton.Visible = False
                    Button1.Visible = True
                    nhexaneShow.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub FFButton_Click(sender As Object, e As EventArgs) Handles FFButton.Click
        duration = CInt(Soxhlet_Duration_txt.Text) * 3600
        Soxhlet_Tank.ProgressColor = Color.FromArgb(0, 53, 24) 'change the soxhlet color similar to condensed tank after 1 cycle
        Soxhlet_Tank.ProgressColor2 = Color.FromArgb(0, 53, 24)
        SoxhletProcess_timer.Enabled = False
        Hexane_Extract_time.Enabled = True
        Condensed_Tank.Value = 0
        Soxhlet_Tank.Value = CInt(NHexane_Vol_txt.Text) * 0.45
        FFButton.Visible = False
        Button1.Visible = True
        nhexaneShow.Visible = True
    End Sub

    Private Sub Hexane_Extract_time_Tick(sender As Object, e As EventArgs) Handles Hexane_Extract_time.Tick
        If Soxhlet_Tank.Value > 0 Then
            Soxhlet_Tank.Value = CInt(Soxhlet_Tank.Value) - 10
            Hexane_Extract_tank.Value = CInt(Hexane_Extract_tank.Value) + 10
            nhexaneShow.Text = Hexane_Extract_tank.Value & " ml"
        Else
            Hexane_Extract_time.Enabled = False
            Hexane_Extract_temp_time.Enabled = True
            nhexane_initial = Hexane_Extract_tank.Value
            Button1.Visible = False
            Button2.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hexane_Extract_time.Enabled = False
        Hexane_Extract_temp_time.Enabled = True
        Soxhlet_Tank.Value = 0
        nhexane_initial = CDec(NHexane_Vol_txt.Text) * 0.45
        Button1.Visible = False
        Button2.Visible = True
    End Sub
    Dim Nhexane_Extract As Integer
    Dim nhexane_initial As Decimal
    Private Sub Hexane_Extract_temp_time_Tick(sender As Object, e As EventArgs) Handles Hexane_Extract_temp_time.Tick
        If CInt(Nhexane_SP.Text) > CInt(Nhexane_PV.Text) Then
            Nhexane_PV.Text = CInt(Nhexane_PV.Text) + CInt(Loop100_temp_response_txt.Text)
        Else
            Nhexane_PV.Text = Nhexane_SP.Text
            Hexane_Extract_temp_time.Interval = 1000

        End If
        If Hexane_Extract_temp_time.Interval = 1000 Then
            Nhexane_Extract += 1
            Hexane_Extract_tank.Value = nhexane_initial - (CDec(Nhexane_Extract) / CDec(Nhexane_Duration.Text)) * (nhexane_initial * 0.83)
            nhexaneShow.Text = Hexane_Extract_tank.Value
            If Nhexane_Extract > (CInt(Nhexane_Duration.Text)) Then 'multiply by 3600 to convert hour to seconds
                Hexane_Extract_temp_time.Enabled = False
                nhexaneShow.Text = Math.Round(CDec(nhexane_initial) * 0.17, 2)
                NHexane_Tank.Value = CInt(nhexaneShow.Text)
                Trans_timer.Enabled = True
                catalystShow.Text = Math.Round((CDec(nhexaneShow.Text) / 17), 2) & " g"
                catalystShow.Visible = True
                Catalyst_Tank.Value = CInt((CDec(nhexaneShow.Text) / 17))
                methanolShow.Text = CInt(Math.Round(CDec(nhexaneShow.Text), 2)) & " ml"
                methanolShow.Visible = True
                Methanol_Volume.Text = CInt(Math.Round(CDec(nhexaneShow.Text), 2))
                Catalyst_Volume.Text = Catalyst_Tank.Value
                Methanol_tank.Value = CInt(Methanol_Volume.Text)
                TransShow.Visible = True
                Button2.Visible = False
                Button3.Visible = True
                Threading.Thread.Sleep(5000)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hexane_Extract_tank.Value = nhexane_initial * 0.83
        Hexane_Extract_temp_time.Enabled = False
        nhexaneShow.Text = Math.Round(CDec(nhexane_initial) * 0.17, 2)
        NHexane_Tank.Value = CInt(nhexaneShow.Text)
        Trans_timer.Enabled = True
        catalystShow.Text = Math.Round((CDec(nhexaneShow.Text) / 17), 2) & " g"
        catalystShow.Visible = True
        Catalyst_Tank.Value = CInt((CDec(nhexaneShow.Text) / 17))
        methanolShow.Text = CInt(Math.Round(CDec(nhexaneShow.Text), 2)) & " ml"
        methanolShow.Visible = True
        Methanol_Volume.Text = CInt(Math.Round(CDec(nhexaneShow.Text), 2))
        Catalyst_Volume.Text = Catalyst_Tank.Value
        Methanol_tank.Value = CInt(Methanol_Volume.Text)
        TransShow.Visible = True
        Button2.Visible = False
        Button3.Visible = True
        Threading.Thread.Sleep(2000)
    End Sub

    Private Sub Trans_timer_Tick(sender As Object, e As EventArgs) Handles Trans_timer.Tick
        If Hexane_Extract_tank.Value > 0 Then
            Hexane_Extract_tank.Value = CInt(Hexane_Extract_tank.Value) - 1
            Trans_Tank.Value = CInt(Trans_Tank.Value) + 1
        End If
        If Methanol_tank.Value > 0 Then
            Methanol_tank.Value = CInt(Methanol_tank.Value) - 1
            Trans_Tank.Value = CInt(Trans_Tank.Value) + 1
        End If
        If Catalyst_Tank.Value > 0 Then
            Catalyst_Tank.Value = CInt(Catalyst_Tank.Value) - 1
            'Trans_Tank.Value = CInt(Trans_Tank.Value) + 1
        End If
        TransShow.Text = Trans_Tank.Value
        If CInt(Hexane_Extract_tank.Value) <= 0 And CInt(Methanol_tank.Value) <= 0 And CInt(Catalyst_Tank.Value) <= 0 Then
            Trans_timer.Enabled = False
            Trans_Color_Timer.Enabled = True
            Trans_Tank.Value = CInt(nhexaneShow.Text) + CInt(Methanol_Volume.Text)
            TransShow.Text = Trans_Tank.Value
            Button3.Visible = False
            'Dim newloc As Integer = CDec(TransTopBar.Location.Y) + ((CDec(Trans_Tank.Maximum) - CDec(Trans_Tank.Value)) / CDec(Trans_Tank.Maximum)) * 85
            'TransTopBar.Location = New Point(TransTopBar.Location.X, newloc)
            'TransTopBar.Size = New Point(TransTopBar.Size.Width, ((CDec(Trans_Tank.Value) / 2) / 200) * 85)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Trans_timer.Enabled = False
        Trans_Color_Timer.Enabled = True
        Hexane_Extract_tank.Value = 0
        Methanol_tank.Value = 0
        Catalyst_Tank.Value = 0
        Trans_Tank.Value = CInt(nhexaneShow.Text) + CInt(Methanol_Volume.Text)
        TransShow.Text = Trans_Tank.Value
        Button3.Visible = False
    End Sub


    Dim trans_Count As Integer
    Dim topcolor As Integer = 50
    Dim botcolor As Integer = 50
    Public transInitial As Integer
    Private Sub Trans_Color_Timer_Tick(sender As Object, e As EventArgs) Handles Trans_Color_Timer.Tick
        trans_Count += 1
        If trans_Count < CInt(Trans_Duration.Text) Then 'multiply by 3600 to convert hour to seconds
            topcolor = ((trans_Count / CInt(Trans_Duration.Text)) * 100) + 50
            'TransTopBar.FillColor = Color.FromArgb(0, topcolor, 24)
            'TransTopBar.BorderColor = Color.FromArgb(0, topcolor, 24)
            Trans_Tank.ProgressColor = Color.FromArgb(0, topcolor, 24)
        Else
            transInitial = CInt(Trans_Tank.Value)
            SeparatoryShow.Visible = True
            separatorunit.Visible = True
            Trans_Color_Timer.Enabled = False
            Filter_Timer.Enabled = True
            TransTopBar.Visible = False
            FFTrans.Visible = False
            Button4.Visible = True
        End If
    End Sub

    Private Sub FFTrans_Click(sender As Object, e As EventArgs) Handles FFTrans.Click
        Trans_Tank.ProgressColor = Color.FromArgb(0, 150, 24)
        transInitial = CInt(Trans_Tank.Value)
        SeparatoryShow.Visible = True
        separatorunit.Visible = True
        Trans_Color_Timer.Enabled = False
        Filter_Timer.Enabled = True
        TransTopBar.Visible = False
        FFTrans.Visible = False
        Button4.Visible = True
    End Sub


    Public filtered As Integer
    Public washloss As Decimal
    Public separatoryInitial As Integer
    Private Sub Filter_Timer_Tick(sender As Object, e As EventArgs) Handles Filter_Timer.Tick
        filtered += 1
        If CInt(Trans_Tank.Value) > 0 Then
            Trans_Tank.Value = CInt(Trans_Tank.Value) - 1
            Separatory_Tank.Value = CInt((CDec(filtered) * 0.85))
            SeparatoryShow.Text = Separatory_Tank.Value
            If CInt(Trans_Tank.Value) <= 1 Then
                Button4.Visible = False

            End If
        Else
            Button5.Visible = True
            Filter_Timer.Enabled = False
            Threading.Thread.Sleep(3000)
            Water_Fill_Timer.Enabled = True
            waterIn = CDec(Water_Volume.Text)
            separatoryInitial = SeparatoryShow.Text
            'washloss = (0.3 / CDec(Wash_Qty.Text))
            washloss = (CDec(separatoryInitial) * 0.3) / CDec(Wash_Qty.Text)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Separatory_Tank.Value = CInt(CDec(transInitial) * 0.85)
        SeparatoryShow.Text = CInt(CDec(transInitial) * 0.85)
        Trans_Tank.Value = 0
        Button4.Visible = False
        Button5.Visible = True
    End Sub


    Dim waterIn As Decimal
    Dim WaterOut As Decimal
    Dim washCounter As Integer
    Dim decreasegreen As Integer = 50
    Dim fuelvalue As Integer
    Private Sub Water_Fill_Timer_Tick(sender As Object, e As EventArgs) Handles Water_Fill_Timer.Tick
        If waterIn > 0 Then
            waterIn -= 1
            Separatory_Tank.Value = CInt(Separatory_Tank.Value) + 1
            SeparatoryShow.Text = Separatory_Tank.Value
        Else
            Water_Fill_Timer.Enabled = False
            Wash_Wait_Timer.Enabled = True
        End If
    End Sub
    Dim washcolor As Integer
    Private Sub Wash_Wait_Timer_Tick(sender As Object, e As EventArgs) Handles Wash_Wait_Timer.Tick
        washcolor += 1
        If CInt(Wash_Wait.Text) > washcolor Then
            Separatory_Tank.ProgressColor2 = Color.FromArgb(0, 50, ((CDec(washcolor) / CDec(Wash_Wait.Text)) * 125) + 24)
        Else
            Wash_Wait_Timer.Enabled = False
            Water_Drain_Timer.Enabled = True
            WaterOut = CDec(Water_Volume.Text) + CInt(washloss)
        End If
    End Sub
    Public water_reduce As Decimal
    Public water_add As Decimal
    Private Sub Water_Drain_Timer_Tick(sender As Object, e As EventArgs) Handles Water_Drain_Timer.Tick
        If WaterOut > 0 Then
            WaterOut -= 1

            water_reduce = CInt(Separatory_Tank.Value) - 1
            Separatory_Tank.Value = CInt(water_reduce)
            water_add = CInt(Water_Waste_Tank.Value) + 1
            Water_Waste_Tank.Value = CInt(water_add)
            Separatory_Tank.ProgressColor2 = Color.FromArgb(0, 50, ((CDec(washcolor) / CDec(Wash_Wait.Text)) * 125) + 24)
            SeparatoryShow.Text = Separatory_Tank.Value
            washcolor -= 1
            If washcolor < 0 Then
                washcolor = 1
            End If
        Else
            Water_Drain_Timer.Enabled = False
            washCounter += 1
            If washCounter < 3 Then
                waterIn = CDec(Water_Volume.Text)
                Water_Fill_Timer.Enabled = True
                decreasegreen += 35
                Separatory_Tank.ProgressColor = Color.FromArgb(0, decreasegreen, 24)
                'Separatory_Tank.Value = separatoryInitial
            Else
                separatoryInitial = SeparatoryShow.Text
                BioFuel_Fill_Timer.Enabled = True
                biofuelShow.Visible = True
                biofuelunit.Visible = True
                Button5.Visible = False
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Wash_Wait_Timer.Enabled = False
        Water_Fill_Timer.Enabled = False
        Water_Drain_Timer.Enabled = False
        Water_Waste_Tank.Value = Water_Volume.Text * 3
        'Separatory_Tank.Value = 0
        Separatory_Tank.Value = CInt((CDec(transInitial) * 0.595))
        SeparatoryShow.Text = Separatory_Tank.Value
        separatoryInitial = SeparatoryShow.Text
        BioFuel_Fill_Timer.Enabled = True
        biofuelShow.Visible = True
        biofuelunit.Visible = True
        Button5.Visible = False

    End Sub
    Private Sub BioFuel_Fill_Timer_Tick(sender As Object, e As EventArgs) Handles BioFuel_Fill_Timer.Tick
        If CInt(Separatory_Tank.Value) > 0 Then
            Separatory_Tank.Value = CInt(Separatory_Tank.Value) - 1
            BioFuel_Tank.Value = CInt(BioFuel_Tank.Value) + 1
            biofuelShow.Text = BioFuel_Tank.Value
        Else
            BioFuel_Fill_Timer.Enabled = False
            Loop111_Heat_Timer.Enabled = True

        End If
    End Sub



    Private Sub Loop111_Heat_Timer_Tick(sender As Object, e As EventArgs) Handles Loop111_Heat_Timer.Tick
        If CInt(Loop111_SP.Text) > CInt(Loop111_PV.Text) Then
            Loop111_PV.Text = CInt(Loop111_PV.Text) + CInt(Loop100_temp_response_txt.Text)
        Else
            Loop111_PV.Text = CInt(Loop111_SP.Text)
            Loop111_Heat_Timer.Enabled = False
            fuelvalue = biofuelShow.Text
            RemoveWater_Timer.Enabled = True
            Button6.Visible = True
        End If
    End Sub




    Dim Water_Heating As Integer
    Public biofueldummy As Decimal
    Private Sub RemoveWater_Timer_Tick(sender As Object, e As EventArgs) Handles RemoveWater_Timer.Tick
        Water_Heating += 1
        If Water_Heating < CInt(Heating_Time.Text) Then
            biofueldummy = fuelvalue - ((CDec(Water_Heating) / CDec(Heating_Time.Text)) * (CDec(separatoryInitial) * 0.05))
            biofuelShow.Text = Math.Round(biofueldummy, 2)
            BioFuel_Tank.Value = CInt(biofueldummy)
        Else
            RemoveWater_Timer.Enabled = False
            Button6.Visible = False
            MsgBox("End of simulation")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        biofuelShow.Text = Math.Round(fuelvalue * 0.95) & "ml"
        RemoveWater_Timer.Enabled = False
        Button6.Visible = False
        MsgBox("End of simulation")
    End Sub
    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click
        'RawAnimation_timer.Enabled = False
        RemoveWater_Timer.Enabled = True
        biofuelShow.Visible = True
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        config.AppSettings.Settings("kamias").Value = Kamias_vol_txt.Text
        config.AppSettings.Settings("calamansi").Value = Calamansi_vol_txt.Text
        config.AppSettings.Settings("oventemp").Value = Oven_temp_txt.Text
        config.AppSettings.Settings("response").Value = Loop100_temp_response_txt.Text
        config.AppSettings.Settings("ambient").Value = Loop100Ambient_txt.Text
        config.AppSettings.Settings("dwell").Value = Dwell_time_txt.Text
        config.AppSettings.Settings("initRed").Value = Init_Red.Text
        config.AppSettings.Settings("initGreen").Value = Init_Green.Text
        config.AppSettings.Settings("initBlue").Value = Init_Blue.Text
        config.AppSettings.Settings("finalRed").Value = Final_Red.Text
        config.AppSettings.Settings("finalGreen").Value = Final_Green.Text
        config.AppSettings.Settings("finalBlue").Value = Final_Blue.Text
        config.AppSettings.Settings("nhexane").Value = NHexane_Vol_txt.Text
        config.AppSettings.Settings("soxhletTemp").Value = Soxhlet_SetTemp.Text
        config.AppSettings.Settings("soxhletDuration").Value = Soxhlet_Duration_txt.Text
        config.AppSettings.Settings("nhexaneTemp").Value = Nhexane_Temp.Text
        config.AppSettings.Settings("nhexaneDuration").Value = Nhexane_Duration.Text
        config.AppSettings.Settings("methanolVolume").Value = Methanol_Volume.Text
        config.AppSettings.Settings("catalystVolume").Value = Catalyst_Volume.Text
        config.AppSettings.Settings("transDuration").Value = Trans_Duration.Text
        config.AppSettings.Settings("waterVolume").Value = Water_Volume.Text
        config.AppSettings.Settings("washTime").Value = Wash_Wait.Text
        config.AppSettings.Settings("washCycle").Value = Wash_Qty.Text
        config.AppSettings.Settings("bioTemp").Value = BioFuelTemp_SP.Text
        config.AppSettings.Settings("extractedVolume").Value = Extracted_Volume.Text
        config.AppSettings.Settings("extractTime").Value = Heating_Time.Text
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub
    Public Sub loadDefault()
        Kamias_vol_txt.Text = System.Configuration.ConfigurationManager.AppSettings("kamias")
        Calamansi_vol_txt.Text = System.Configuration.ConfigurationManager.AppSettings("calamansi")
        Oven_temp_txt.Text = System.Configuration.ConfigurationManager.AppSettings("oventemp")
        Loop100_temp_response_txt.Text = System.Configuration.ConfigurationManager.AppSettings("response")
        Loop100Ambient_txt.Text = System.Configuration.ConfigurationManager.AppSettings("ambient")
        Dwell_time_txt.Text = System.Configuration.ConfigurationManager.AppSettings("dwell")
        Init_Red.Text = System.Configuration.ConfigurationManager.AppSettings("initRed")
        Init_Green.Text = System.Configuration.ConfigurationManager.AppSettings("initGreen")
        Init_Blue.Text = System.Configuration.ConfigurationManager.AppSettings("initBlue")
        Final_Red.Text = System.Configuration.ConfigurationManager.AppSettings("finalRed")
        Final_Green.Text = System.Configuration.ConfigurationManager.AppSettings("finalGreen")
        Final_Blue.Text = System.Configuration.ConfigurationManager.AppSettings("finalBlue")
        NHexane_Vol_txt.Text = System.Configuration.ConfigurationManager.AppSettings("nhexane")
        Soxhlet_SetTemp.Text = System.Configuration.ConfigurationManager.AppSettings("soxhletTemp")
        Soxhlet_Duration_txt.Text = System.Configuration.ConfigurationManager.AppSettings("soxhletDuration")
        Nhexane_Temp.Text = System.Configuration.ConfigurationManager.AppSettings("nhexaneTemp")
        Nhexane_Duration.Text = System.Configuration.ConfigurationManager.AppSettings("nhexaneDuration")
        Methanol_Volume.Text = System.Configuration.ConfigurationManager.AppSettings("methanolVolume")
        Catalyst_Volume.Text = System.Configuration.ConfigurationManager.AppSettings("catalystVolume")
        Trans_Duration.Text = System.Configuration.ConfigurationManager.AppSettings("transDuration")
        Water_Volume.Text = System.Configuration.ConfigurationManager.AppSettings("waterVolume")
        Wash_Wait.Text = System.Configuration.ConfigurationManager.AppSettings("washTime")
        Wash_Qty.Text = System.Configuration.ConfigurationManager.AppSettings("washCycle")
        BioFuelTemp_SP.Text = System.Configuration.ConfigurationManager.AppSettings("bioTemp")
        Extracted_Volume.Text = System.Configuration.ConfigurationManager.AppSettings("extractedVolume")
        Heating_Time.Text = System.Configuration.ConfigurationManager.AppSettings("extractTime")
    End Sub

    Private Sub Kamias_vol_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Kamias_vol_txt.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        Try
            If tmp.KeyChar = ChrW(Keys.Enter) Then
                If IsNumeric(Kamias_vol_txt.Text) Then
                    If CInt(Kamias_vol_txt.Text) <= 3 Then
                        Calamansi_vol_txt.Text = Math.Round((CDec(Kamias_vol_txt.Text) * 0.1) / 0.12, 2)
                        NHexane_Vol_txt.Text = CInt((((CDec(Calamansi_vol_txt.Text) * 0.12) + (CDec(Kamias_vol_txt.Text)) * 0.1) * 1000) * 2)
                    Else 'force to 25kg and refresh the table
                        MsgBox("cannot greater than 3kg!")
                        Kamias_vol_txt.Text = 3
                        Calamansi_vol_txt.Text = Math.Round((CDec(Kamias_vol_txt.Text) * 0.1) / 0.12, 2)
                        NHexane_Vol_txt.Text = CInt((((CDec(Calamansi_vol_txt.Text) * 0.12) + (CDec(Kamias_vol_txt.Text)) * 0.1) * 1000) * 2)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


End Class
