Imports System.ComponentModel
Imports System.Reflection

Module MyFunctions

   Function ReadSetting(key As String) As String
      Dim appSettings As Object = ConfigurationManager.AppSettings()
      Return appSettings(key)
   End Function

   Sub AddUpdateAppSettings(key As String, value As String)
      Dim configFile As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
      Dim settings As KeyValueConfigurationCollection = configFile.AppSettings.Settings
      If IsNothing(settings(key)) Then
         settings.Add(key, value)
      Else
         settings(key).Value = value
      End If
      configFile.Save(ConfigurationSaveMode.Modified)
      ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
   End Sub

   ' Returns the enum description (if any), otherwise returns the name of the enum value 
   Friend Function GetEnumDescription(Of TEnum)(enumObj As TEnum) As String
      Dim fi As FieldInfo = enumObj.GetType().GetField(enumObj.ToString())
      Dim attributes As DescriptionAttribute() = fi.GetCustomAttributes(GetType(DescriptionAttribute), False)

      If attributes IsNot Nothing AndAlso attributes.Length > 0 Then
         Return attributes(0).Description
      Else
         Return enumObj.ToString()
      End If
   End Function

   'Under construction...
   'Friend Sub FillComboFromEnum(Of TEnum)(enumObj As TEnum, cmb As ComboBox)
   '   'GetEnumDescription(EnumValue).Cast(Of [Enum]()).Select(Of ItemLista)(New ItemLista(Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), TypeOf (DescriptionAttribute)) As DescriptionAttribute).Description, value))
   '   Dim myList As New List(Of Object)
   '   For Each EnumValue In enumObj.GetType().GetEnumValues()
   '      Dim strDescription As String = GetEnumDescription(EnumValue)
   '      myList.Add(New With {.Value = EnumValue, .Description = strDescription})
   '   Next
   '   cmb.DisplayMember = "Description"
   '   cmb.ValueMember = "Value"
   '   cmb.DataSource = myList
   'End Sub
End Module
