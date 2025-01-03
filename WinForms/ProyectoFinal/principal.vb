Imports System.ComponentModel
Public Class formTiendaOnlineHardware
    Public Shared productos As Integer = 0
    Dim busqueda As String
    Dim opc As Integer
    Public Sub agregar()
        opc = MsgBox("¿Estas seguro de agregar este producto al carrito?", vbYesNo, "Agregar")
        If opc = 6 Then
            pCarrito.Visible = True
            productos = productos + 1
            pCarrito.Text = productos

            MsgBox("Producto Agregado Exitosamente.", vbOKOnly, "Carrito")
        Else
            MsgBox("Producto No Agregado al Carrito.", vbOKOnly, "Carrito")
        End If
    End Sub
    Public Shared Sub noDisponible()
        MsgBox("Apartado no disponible en este momento, disculpe las molestias.", vbCritical, "Sección no disponible")
    End Sub
    Public Shared Sub noCoincidente()
        MsgBox("Datos no Coincidentes, disculpe las molestias.", vbCritical, "Busqueda Erronea")
    End Sub
    Public Sub disp()
        MsgBox("Tienes " & productos & " productos en tu carrito.", vbExclamation, "Carrito")
    End Sub
    Private Sub combo_componentes1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_componentes1.SelectedIndexChanged
        Dim combo1 As Integer
        combo1 = combo_componentes1.SelectedIndex

        Select Case combo1
            Case 1
                subProducto.Show()
                Me.Hide()
            Case Else
                noDisponible()
        End Select
    End Sub
    Private Sub combo_componentes2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_componentes2.SelectedIndexChanged
        Dim combo2 As Integer
        combo2 = combo_componentes2.SelectedIndex

        Select Case combo2
            Case Else
                noDisponible()
        End Select
    End Sub
    Private Sub combo_componentes3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_componentes3.SelectedIndexChanged
        Dim combo3 As Integer
        combo3 = combo_componentes3.SelectedIndex

        Select Case combo3
            Case Else
                noDisponible()
        End Select
    End Sub
    Private Sub combo_componentes4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_componentes4.SelectedIndexChanged
        Dim combo4 As Integer
        combo4 = combo_componentes4.SelectedIndex

        Select Case combo4
            Case Else
                noDisponible()
        End Select
    End Sub
    Private Sub img_buscador_Click(sender As Object, e As EventArgs) Handles img_buscador.Click
        Dim busqueda As String

        busqueda = buscador.Text()

        Select Case busqueda
            Case "Asus"
                subProducto.Show()
                Me.Hide()
            Case Else
                noCoincidente()
        End Select
    End Sub
    Private Sub buscador_KeyDown(sender As Object, e As KeyEventArgs) Handles buscador.KeyDown
        busqueda = buscador.Text()

        If e.KeyCode = 13 Then
            Select Case busqueda
                Case "Asus", "asus", "monitores asus", "Monitores Asus"
                    subProducto.Show()
                    Me.Hide()
                Case Else
                    noCoincidente()
            End Select
        End If
    End Sub
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        menuDesp.Visible = True
    End Sub
    Private Sub formTiendaOnlineHardware_Click(sender As Object, e As EventArgs) Handles Me.Click
        menuDesp.Visible = False
    End Sub
    Private Sub menu9_Click(sender As Object, e As EventArgs) Handles menu9.Click
        subProducto.Show()
        Me.Hide()
    End Sub
    Private Sub menu2_Click(sender As Object, e As EventArgs) Handles menu2.Click
        noDisponible()
    End Sub
    Private Sub menu3_Click(sender As Object, e As EventArgs) Handles menu3.Click
        noDisponible()
    End Sub
    Private Sub menu4_Click(sender As Object, e As EventArgs) Handles menu4.Click
        noDisponible()
    End Sub
    Private Sub menu5_Click(sender As Object, e As EventArgs) Handles menu5.Click
        noDisponible()
    End Sub
    Private Sub menu6_Click(sender As Object, e As EventArgs) Handles menu6.Click
        noDisponible()
    End Sub
    Private Sub menu7_Click(sender As Object, e As EventArgs) Handles menu7.Click
        noDisponible()
    End Sub
    Private Sub menu8_Click(sender As Object, e As EventArgs) Handles menu8.Click
        noDisponible()
    End Sub
    Private Sub menu10_Click(sender As Object, e As EventArgs) Handles menu10.Click
        noDisponible()
    End Sub
    Private Sub menu11_Click(sender As Object, e As EventArgs) Handles menu11.Click
        noDisponible()
    End Sub
    Private Sub img_regresar_Click(sender As Object, e As EventArgs) Handles img_regresar.Click
        menuDesp.Visible = False
    End Sub
    Private Sub opc1_Click(sender As Object, e As EventArgs) Handles opc1.Click
        MsgBox("Puedes interactuar con los elementos presionandolos.", vbQuestion, "Ayuda")
    End Sub
    Private Sub btn_agregar1_Click(sender As Object, e As EventArgs) Handles btn_agregar1.Click
        agregar()
    End Sub
    Private Sub btn_agregar2_Click(sender As Object, e As EventArgs) Handles btn_agregar2.Click
        agregar()
    End Sub
    Private Sub btn_agregar3_Click(sender As Object, e As EventArgs) Handles btn_agregar3.Click
        agregar()
    End Sub
    Private Sub btn_agregar4_Click(sender As Object, e As EventArgs) Handles btn_agregar4.Click
        agregar()
    End Sub
    Private Sub btn_agregar5_Click(sender As Object, e As EventArgs) Handles btn_agregar5.Click
        agregar()
    End Sub
    Private Sub btn_agregar6_Click(sender As Object, e As EventArgs) Handles btn_agregar6.Click
        agregar()
    End Sub
    Private Sub pCarrito_Click(sender As Object, e As EventArgs) Handles pCarrito.Click
        productos = productos - 1
        pCarrito.Text = productos
    End Sub
    Private Sub carrito_Click(sender As Object, e As EventArgs) Handles carrito.Click
        disp()
    End Sub
    Private Sub opc2_Click(sender As Object, e As EventArgs) Handles opc2.Click
        disp()
    End Sub
    Private Sub opc3_Click(sender As Object, e As EventArgs) Handles opc3.Click
        MsgBox("En este momento no hay devoluciones, sentimos las molestias.", vbCritical, "Devoluciones")
    End Sub
    Private Sub seleccion1_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion1_1.CheckedChanged
        imagenP1.Image = My.Resources._1_1
    End Sub
    Private Sub seleccion1_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion1_2.CheckedChanged
        imagenP1.Image = My.Resources._1_2
    End Sub
    Private Sub seleccion2_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion2_1.CheckedChanged
        imagenP2.Image = My.Resources._2_1
    End Sub
    Private Sub seleccion2_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion2_2.CheckedChanged
        imagenP2.Image = My.Resources._2_2
    End Sub
    Private Sub seleccion2_3_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion2_3.CheckedChanged
        imagenP2.Image = My.Resources._2_3
    End Sub
    Private Sub seleccion3_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion3_1.CheckedChanged
        imagenP3.Image = My.Resources._3_1
    End Sub
    Private Sub seleccion3_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion3_2.CheckedChanged
        imagenP3.Image = My.Resources._3_2
    End Sub
    Private Sub seleccion3_3_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion3_3.CheckedChanged
        imagenP3.Image = My.Resources._3_3
    End Sub
    Private Sub seleccion4_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion4_1.CheckedChanged
        imagenP4.Image = My.Resources._4_1
    End Sub
    Private Sub seleccion5_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion5_1.CheckedChanged
        imagenP5.Image = My.Resources._5_1
    End Sub
    Private Sub seleccion5_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion5_2.CheckedChanged
        imagenP5.Image = My.Resources._5_2
    End Sub
    Private Sub seleccion5_3_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion5_3.CheckedChanged
        imagenP5.Image = My.Resources._5_3
    End Sub
    Private Sub seleccion6_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion6_1.CheckedChanged
        imagenP6.Image = My.Resources._6_1
    End Sub
    Private Sub seleccion6_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion6_2.CheckedChanged
        imagenP6.Image = My.Resources._6_2
    End Sub
    Private Sub seleccion6_3_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion6_3.CheckedChanged
        imagenP6.Image = My.Resources._6_3
    End Sub
    Private Sub seleccion4_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion4_2.CheckedChanged
        imagenP4.Image = My.Resources._4_2
    End Sub
End Class
