Imports System.Data.SqlClient

Public Class Form1

    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader
    Private strSQL As String

    Public Sub New()
        InitializeComponent()

        Me.Text = "Gerenciador de Tarefas Pessoais"

        Label_Atividade.Text = "Atividade"
        Label_RemoverAtividade.Text = "Remover atividade com o ID
"
        GroupBox_Importante.Text = "Importante"
        RadioButtonImportanteSim.Text = "Sim"
        RadioButton_ImportanteNao.Text = "Não"

        GroupBox_Urgente.Text = "Urgente"
        RadioButton_UrgenteSim.Text = "Sim"
        RadioButton_UrgenteNao.Text = "Não"

        GroupBox_Completada.Text = "Realizada"
        RadioButtonCompletadaSim.Text = "Sim"
        RadioButtonCompletadaNao.Text = "Não"

        Button_Adicionar.Text = "Adicionar"
        Button_RemoverAtividade.Text = "Remover Atividade"
        Button_Filtar.Text = "Filtar"

        GroupBox_ImportanteUrgente.Text = "Importante e Urgente"
        GroupBox_ImportanteNaoUrgente.Text = "Importante e Não Urgente"
        GroupBox_NaoImportanteUrgente.Text = "Não Importante e Urgente"
        GroupBox_NaoImportanteNaoUrgente.Text = "Não Importante e Não Urgente"

        DataGridView1.ReadOnly = True
        DataGridView2.ReadOnly = True
        DataGridView3.ReadOnly = True
        DataGridView4.ReadOnly = True
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click

        Dim descricao As String = TextBox_Atividade.Text
        Dim importante As Boolean
        If (RadioButtonImportanteSim.Checked) Then
            importante = True
        ElseIf (RadioButton_ImportanteNao.Checked) Then
            importante = False
        Else
            MsgBox("Por favor, selecione Sim ou Não para a IMPORTANCIA")
        End If

        Dim urgente As Boolean
        If (RadioButton_UrgenteSim.Checked) Then
            urgente = True
        ElseIf (RadioButton_UrgenteNao.Checked) Then
            urgente = False
        Else
            MsgBox("Por favor, selecione Sim ou Não para a URGENCIA")
        End If

        Dim completada As Boolean
        If (RadioButtonCompletadaSim.Checked) Then
            completada = True
        ElseIf (RadioButtonCompletadaNao.Checked) Then
            completada = False
        Else
            MsgBox("Por favor, selecione Sim ou Não para REALIZADA")
        End If

        Try 'Banco de Dados
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=PrioridadeAtividades; User Id=sa;Password=123")
            strSQL = "INSERT INTO [DBO].[ATIVIDADES] ([ATIVIDADE], [URGENTE], [IMPORTANTE], [COMPLETADA]) VALUES (@ATIVIDADE, @URGENTE ,@IMPORTANTE ,@COMPLETADA)"
            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("ATIVIDADE", descricao)
            comando.Parameters.AddWithValue("URGENTE", urgente)
            comando.Parameters.AddWithValue("IMPORTANTE", importante)
            comando.Parameters.AddWithValue("COMPLETADA", completada)
            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try

    End Sub


    Private Sub Button_Filtar_Click(sender As Object, e As EventArgs) Handles Button_Filtar.Click
        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=PrioridadeAtividades; User Id=sa;Password=123")
            strSQL = "SELECT * FROM [DBO].[ATIVIDADES] WHERE [IMPORTANTE] = 1 AND [URGENTE] = 1 AND [COMPLETADA] = 0"
            comando = New SqlCommand(strSQL, conexao)
            da = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try

        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=PrioridadeAtividades; User Id=sa;Password=123")
            strSQL = "SELECT * FROM [DBO].[ATIVIDADES] WHERE [IMPORTANTE] = 1 AND [URGENTE] = 0 AND [COMPLETADA] = 0"
            comando = New SqlCommand(strSQL, conexao)
            da = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try

        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=PrioridadeAtividades; User Id=sa;Password=123")
            strSQL = "SELECT * FROM [DBO].[ATIVIDADES] WHERE [IMPORTANTE] = 0 AND [URGENTE] = 1 AND [COMPLETADA] = 0"
            comando = New SqlCommand(strSQL, conexao)
            da = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView3.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try

        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=PrioridadeAtividades; User Id=sa;Password=123")
            strSQL = "SELECT * FROM [DBO].[ATIVIDADES] WHERE [IMPORTANTE] = 0 AND [URGENTE] = 0 AND [COMPLETADA] = 0"
            comando = New SqlCommand(strSQL, conexao)
            da = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView4.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try
    End Sub

    Private Sub Button_RemoverAtividade_Click(sender As Object, e As EventArgs) Handles Button_RemoverAtividade.Click
        Try
            conexao = New SqlConnection("Server=DESKTOP-N8DD9OQ; Database=PrioridadeAtividades; User Id=sa;Password=123")
            strSQL = "UPDATE [DBO].[ATIVIDADES] SET [COMPLETADA] = 1 WHERE [ID] = @ID"
            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@ID", TextBox_RemoverAtividade.Text)
            conexao.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try
    End Sub
End Class
