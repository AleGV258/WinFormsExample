Imports System.ComponentModel
Public Class subProducto
    Public Sub produ()
        formTiendaOnlineHardware.agregar()
        pCarrito.Visible = True
        pCarrito.Text = formTiendaOnlineHardware.productos
    End Sub
    Private Sub img_regresar_Click(sender As Object, e As EventArgs) Handles img_regresar.Click
        formTiendaOnlineHardware.Show()
        Me.Hide()
    End Sub
    Private Sub subProducto_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        formTiendaOnlineHardware.Close()
    End Sub
    Private Sub img_buscador_Click(sender As Object, e As EventArgs) Handles img_buscador.Click
        Dim busqueda As String

        busqueda = buscador.Text()

        Select Case busqueda
            Case "Productos Nuevos", "productos nuevos", "Nuevos", "nuevos", "Principal", "principal"
                formTiendaOnlineHardware.Show()
                Me.Hide()
            Case Else
                formTiendaOnlineHardware.noCoincidente()
        End Select
    End Sub
    Private Sub buscador_KeyDown(sender As Object, e As KeyEventArgs) Handles buscador.KeyDown
        Dim busqueda As String

        busqueda = buscador.Text()

        If e.KeyCode = 13 Then
            Select Case busqueda
                Case "Productos Nuevos", "productos nuevos", "Nuevos", "nuevos", "Principal", "principal"
                    formTiendaOnlineHardware.Show()
                    Me.Hide()
                Case Else
                    formTiendaOnlineHardware.noCoincidente()
            End Select
        End If
    End Sub
    Private Sub btn_agregar1_Click(sender As Object, e As EventArgs) Handles btn_agregar1.Click
        produ()
    End Sub
    Private Sub btn_agregar2_Click(sender As Object, e As EventArgs) Handles btn_agregar2.Click
        produ()
    End Sub
    Private Sub btn_agregar3_Click(sender As Object, e As EventArgs) Handles btn_agregar3.Click
        produ()
    End Sub
    Private Sub btn_agregar4_Click(sender As Object, e As EventArgs) Handles btn_agregar4.Click
        produ()
    End Sub
    Private Sub btn_agregar5_Click(sender As Object, e As EventArgs) Handles btn_agregar5.Click
        produ()
    End Sub
    Private Sub btn_agregar6_Click(sender As Object, e As EventArgs) Handles btn_agregar6.Click
        produ()
    End Sub
    Private Sub pCarrito_Click(sender As Object, e As EventArgs) Handles pCarrito.Click
        formTiendaOnlineHardware.productos = formTiendaOnlineHardware.productos - 1
        pCarrito.Text = formTiendaOnlineHardware.productos
    End Sub
    Private Sub seleccion1_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion1_1.CheckedChanged
        imagenP1.Image = My.Resources.asus1_1
    End Sub
    Private Sub seleccion1_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion1_2.CheckedChanged
        imagenP1.Image = My.Resources.asus1_2
    End Sub
    Private Sub seleccion2_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion2_1.CheckedChanged
        imagenP2.Image = My.Resources.asus2_1
    End Sub
    Private Sub seleccion2_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion2_2.CheckedChanged
        imagenP2.Image = My.Resources.asus2_2
    End Sub
    Private Sub seleccion3_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion3_1.CheckedChanged
        imagenP3.Image = My.Resources.asus3_1
    End Sub
    Private Sub seleccion3_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion3_2.CheckedChanged
        imagenP3.Image = My.Resources.asus3_2
    End Sub
    Private Sub seleccion4_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion4_1.CheckedChanged
        imagenP4.Image = My.Resources.asus4_1
    End Sub
    Private Sub seleccion4_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion4_2.CheckedChanged
        imagenP4.Image = My.Resources.asus4_2
    End Sub
    Private Sub seleccion5_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion5_1.CheckedChanged
        imagenP5.Image = My.Resources.asus5_1
    End Sub
    Private Sub seleccion5_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion5_2.CheckedChanged
        imagenP5.Image = My.Resources.asus5_2
    End Sub
    Private Sub seleccion6_1_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion6_1.CheckedChanged
        imagenP6.Image = My.Resources.asus6_1
    End Sub
    Private Sub seleccion6_2_CheckedChanged(sender As Object, e As EventArgs) Handles seleccion6_2.CheckedChanged
        imagenP6.Image = My.Resources.asus6_2
    End Sub
    Private Sub carrito_Click(sender As Object, e As EventArgs) Handles carrito.Click
        MsgBox("Tienes " & formTiendaOnlineHardware.productos & " productos en tu carrito.", vbExclamation, "Carrito")
    End Sub
End Class