Imports System.Text
Imports System.IO

Public Class Factorio_Json_Editor
    Private Sub btnMake_Click(sender As Object, e As EventArgs) Handles btnMake.Click
        Dim path As String = LocationVerification(tbJsonLocation.Text, tbJsonName.Text)
        Dim strContent As String

        If Directory.Exists(tbJsonLocation.Text) Then
            strContent = Build(path)
            Write(strContent, path)
        Else
            MessageBox.Show("Folder does not exist.  Please enter valid folder for the Json to be put.")
        End If

    End Sub

    Private Function Build(path As String)
        Dim strJsonFileContent As String

        Dim strServerName As String = """" + tbServerName.Text + ""","
        Dim strDescription As String = """" + tbDescription.Text + ""","
        Dim strTags As String = " [" + tbTags.Text + "],"
        Dim strMaxPlayers As String = "" + tbMaxPlayers.Text + ","
        Dim strVisibility As String = "" + cbVisibility.Text + ","
        Dim strUsername As String = """" + tbUsername.Text + ""","
        Dim strPassword As String = """" + tbPassword.Text + ""","
        Dim strGamePass As String = """" + tbGamePassword.Text + ""","
        Dim strUserVerification As String = "" + cbUserVarification.Text + ","
        Dim strMaxUpload As String = "" + tbUploadSpd.Text + ","
        Dim strMinLatency As String = "" + tbMinLatency.Text + ","
        Dim strIgnorePlayerLimit As String = "" + cbIgnorePLayerLimit.Text + ","
        Dim strAllowCommands As String = "" + cbAllowCommands.Text + ","
        Dim strAutosaveInterval As String = "" + tbAutosaveInterval.Text + ","
        Dim strAutosaveSlot As String = "" + cbAutosaveSlot.Text + ","
        Dim strAFKKickTime As String = "" + cbAFKKick.Text + ","
        Dim strAutoPause As String = "" + cbAutoPause.Text + ","
        Dim strAdminPause As String = "" + cbAdminPause.Text + ","
        Dim strServerAutoSave As String = "" + cbAutosaveServer.Text + ","
        Dim strAdmins As String = " [" + tbAdmins.Text + "],"

        If strVisibility = "public" Then
            strVisibility = """public"": " + "True" + ",
" + """lan"": " + "False"
        Else
            strVisibility = """public"": " + "False" + ",
" + """lan"": " + "True,"
        End If


        strJsonFileContent = "{
""name"": " + strServerName + "
""Description"": " + strDescription + "
""tags"" :  " + strTags + "

""_comment_max_players"": ""Maximum number Of players allowed, admins can join even a full server. 0 means unlimited.""" + "
""max_players"":" + strMaxPlayers + "


""_comment_visibility"": [""public: Game will be published on the official Factorio matching server"",
                          ""lan: Game will be broadcast on LAN""]," + "
""visibility"":" + strVisibility + "

""_comment_credentials"": ""Your factorio.com login credentials. Required for games with visibility public"",
" + """username"": " + strUsername + "
" + """password"": " + strPassword + "

" + """_comment_token"" :  ""Authentication token. May be used instead of 'password' above."",
  ""token"": ," + "

" + """game_password"":" + strGamePass + "

" + """_comment_require_user_verification"": ""When set to true, the server will only allow clients that have a valid Factorio.com account""," + "
" + """require_user_verification"": " + strUserVerification + "

" + """_comment_max_upload_in_kilobytes_per_second"" : ""optional, default value is 0. 0 means unlimited."",""" + "
" + """max_upload_in_kilobytes_per_second"": " + strMaxUpload + "

" + """_comment_minimum_latency_in_ticks"": ""optional one tick is 16ms in default speed, default value is 0. 0 means no minimum."",
" + """minimum_latency_in_ticks:"": " + strMinLatency + "

" + """_comment_ignore_player_limit_for_returning_players"": ""Players that played on this map already can join even when the max player limit was reached."",
" + """ignore_player_limit_for_returning_players"": " + strIgnorePlayerLimit + "

" + """_comment_allow_commands"": ""possible values are, true, false and admins-only"", 
" + """allow_commands"": " + strAllowCommands + "

" + """_comment_autosave_interval"": ""Autosave interval in minutes"", " + "
" + """autosave_interval"": " + strAutosaveInterval + "

" + """_comment_autosave_slots"" :  ""server autosave slots, it is cycled through when the server autosaves."",
 ""autosave_slots"":" + strAutosaveSlot + "

" + """_comment_afk_autokick_interval"" :  ""How many minutes until someone is kicked when doing nothing, 0 for never."", 
 ""afk_autokick_interval"":" + strAFKKickTime + "

" + """_comment_auto_pause"" :  ""Whether should the server be paused when no players are present."",
  ""auto_pause"":" + strAutoPause + "

" + """only_admins_can_pause_the_game"": " + strAdminPause + "
  
" + """_comment_autosave_only_on_server"" :  ""Whether autosaves should be saved only on server or also on all connected clients. Default is true."",
  ""autosave_only_on_server"":" + strServerAutoSave + "

" + """_comment_admins"" :  ""List of case insensitive usernames, that will be promoted immediately"",
  ""admins"": " + strAdmins + "
}"
        Return (strJsonFileContent)
    End Function

    Private Sub Write(FileCont As String, path As String)
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(FileCont)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Private Function LocationVerification(loc As String, file As String)
        Dim path As String

        Dim INTstrServLoc As Integer = loc.Length - 1

        Dim finalChar As Char = loc(INTstrServLoc)

        If finalChar = "\" Then
            path = loc + file
        Else
            path = loc + "\" + file
        End If

        Return path
    End Function

End Class