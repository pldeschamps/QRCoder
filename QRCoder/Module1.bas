Attribute VB_Name = "Module1"
Sub Bouton1_Cliquer()

Dim qrcodecomminterfac As New QRCoderForVBA.QRCodeCOMInterface


Debug.Print qrcodecomminterfac.Copyright

qrcodecomminterfac.PlainText = "201907170300<19-216 DGA/UMCOE/MSBS<<<<<<<<<<<<<<<<<<<<<<<<<"

Set img = Feuil1.Shapes.AddOLEObject("Forms.Image.1")

Dim iobj As MSForms.image
Set iobj = img.Object
Dim b() As Byte
b = qrcodecomminterfac.QRCodeByte
'iobj.Picture = qrcodecomminterfac.QRCodeBMP

End Sub
