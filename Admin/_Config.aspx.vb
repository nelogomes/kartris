﻿'========================================================================
'Kartris - www.kartris.com
'Copyright 2014 CACTUSOFT INTERNATIONAL FZ LLC

'GNU GENERAL PUBLIC LICENSE v2
'This program is free software distributed under the GPL without any
'warranty.
'www.gnu.org/licenses/gpl-2.0.html

'KARTRIS COMMERCIAL LICENSE
'If a valid license.config issued by Cactusoft is present, the KCL
'overrides the GPL v2.
'www.kartris.com/t-Kartris-Commercial-License.aspx
'========================================================================
Partial Class Admin_Config
    Inherits _PageBaseClass

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = GetGlobalResourceObject("_Kartris", "BackMenu_ConfigSettings") & " | " & GetGlobalResourceObject("_Kartris", "ContentText_KartrisName")
    End Sub

    Protected Sub ShowMasterUpdateMessage() Handles _UC_ConfigSetting.ShowMasterUpdate
        CType(Me.Master, Skins_Admin_Template).DataUpdated()
    End Sub
End Class
