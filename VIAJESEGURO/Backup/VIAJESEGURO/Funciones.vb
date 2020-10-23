Imports System.Data.SqlClient
Public Class Funciones
    Inherits Conexion
    Dim cdm As SqlCommand

    Public Function validar(ByVal dat As Datos) As Boolean
        Try
            Conectado()
            cdm = New SqlCommand("validar")
            cdm.CommandType = CommandType.StoredProcedure
            cdm.Connection = cnn
            cdm.Parameters.AddWithValue("@log", dat.nomusuario)
            cdm.Parameters.AddWithValue("@pas", dat.pass)
            cdm.Parameters.AddWithValue("@rol", dat.rolusuario)
            Dim dr As SqlDataReader
            dr = cdm.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
End Class
