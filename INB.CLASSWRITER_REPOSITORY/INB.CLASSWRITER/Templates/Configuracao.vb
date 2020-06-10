Imports System.IO

Public Class Configuracao

    Public Property [Namespace] As String
    Public Property CodigoSistema As Integer
    Public Property NomeSistema As String
    Public Property ConnectionString As String
    Public Property Diretorio As String
    Public Property DataContextName As String
    Public Property Prefixo As String
    Public Property UsaCaminhoPadrao As Boolean = False
    Public Property PrimeiraVez As Boolean = True
    Public Property PreparaLog As Boolean = False
    Public Property ImportaCONSEG As Boolean = False
    Public Property IdentificacaoUsuario As eIdentificacaoUsuario
    Public Property TipoClasse As eModelType
    Public Property LinguagemCriacao As eLinguagemCriacao
    Public Property TipoLog As eLog


    Public ReadOnly Property IdentificacaoUsuarioParam As String
        Get
            If LinguagemCriacao = eLinguagemCriacao.CSharp Then
                Select Case IdentificacaoUsuario
                    Case eIdentificacaoUsuario.Matricula
                        Return ", int pMatricula"
                    Case eIdentificacaoUsuario.Perfil
                        Return ", Perfil pPerfil"
                End Select
            ElseIf LinguagemCriacao = eLinguagemCriacao.VBNET Then
                Select Case IdentificacaoUsuario
                    Case eIdentificacaoUsuario.Matricula
                        Return ", Integer pMatricula "
                    Case eIdentificacaoUsuario.Perfil
                        Return ", Perfil pPerfil"
                End Select
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property IdentificacaoUsuarioLog As String
        Get
            Select Case IdentificacaoUsuario
                Case eIdentificacaoUsuario.Matricula
                    Return "pMatricula"
                Case eIdentificacaoUsuario.Perfil
                    Return "pPerfil.iLogin"
            End Select
            Return ""
        End Get
    End Property

    Public Enum eIdentificacaoUsuario
        Nenhum
        Matricula
        Perfil
    End Enum

    Public Enum eLog
        Nenhum
        InserirAtualizarExcluir
        Tudo
    End Enum

    Public Enum eModelType
        ClassesDAO = 0
        ClassesPartial = 1
        Repository = 2
    End Enum

    Public Enum eLinguagemCriacao
        VBNET = 0
        CSharp = 1
    End Enum

    Public Sub New()
        [Namespace] = ""
        CodigoSistema = 0
        NomeSistema = ""
        ConnectionString = ""
        Diretorio = ""
        DataContextName = ""
        Prefixo = ""
        UsaCaminhoPadrao = False
        'Tabelas = New List(Of LERESTRUTURA.TABLE)
        PrimeiraVez = True
        PreparaLog = False
        ImportaCONSEG = False
        IdentificacaoUsuario = eIdentificacaoUsuario.Matricula
        TipoClasse = eModelType.ClassesDAO
        LinguagemCriacao = eLinguagemCriacao.CSharp
        TipoLog = eLog.Nenhum
    End Sub

    Public Sub GerarArquivosHelper()
        Dim DirDefault As String = "Helpers\"

        If LinguagemCriacao = eLinguagemCriacao.CSharp Then
            GerarArquivo(DirDefault & "DataHelper.cs", New My.Templates.CSharp.DataHelper(Me).TransformText())
            GerarArquivo(DirDefault & "INBException.cs", New My.Templates.CSharp.INBException(Me).TransformText())
            GerarArquivo(DirDefault & "LogSistema.cs", New My.Templates.CSharp.LogSistema(Me).TransformText())
            GerarArquivo(DirDefault & "MyGlobal.cs", New My.Templates.CSharp.MyGlobal(Me).TransformText())
            GerarArquivo(DirDefault & "Notificacao.cs", New My.Templates.CSharp.Notificacao(Me).TransformText())
            GerarArquivo("Business\Perfil.cs", New My.Templates.CSharp.Perfil(Me).TransformText())
        ElseIf LinguagemCriacao = eLinguagemCriacao.VBNET Then
            GerarArquivo(DirDefault & "DataHelper.vb", New My.Templates.VB.DataHelper(Me).TransformText())
            GerarArquivo(DirDefault & "INBException.vb", New My.Templates.VB.INBException().TransformText())
            GerarArquivo(DirDefault & "LogSistema.vb", New My.Templates.VB.LogSistema().TransformText())
            GerarArquivo(DirDefault & "MyGlobal.vb", New My.Templates.VB.MyGlobal(Me).TransformText())
            GerarArquivo(DirDefault & "Notificacao.vb", New My.Templates.VB.Notificacao().TransformText())
            GerarArquivo("Business\Perfil.vb", New My.Templates.VB.Perfil().TransformText())
        End If
    End Sub

    Public Sub GerarArquivoIRepository(pTabela As LERESTRUTURA.TABLE.stTable)
        Dim DirDefault As String = "Interfaces\"
        If LinguagemCriacao = eLinguagemCriacao.CSharp Then
            GerarArquivo(DirDefault & "IRepository" & pTabela.Nome & ".cs", New My.Templates.CSharp.IRepository(Me, pTabela).TransformText())
        End If
    End Sub

    Public Sub GerarArquivoRepository(pTabela As LERESTRUTURA.TABLE.stTable)
        Dim DirDefault As String = "Repositories\"
        If LinguagemCriacao = eLinguagemCriacao.CSharp Then
            GerarArquivo(DirDefault & "Repository" & pTabela.Nome & ".cs", New My.Templates.CSharp.Repository(Me, pTabela).TransformText())
        End If
    End Sub

    Public Sub GerarArquivosModel(pTabela As LERESTRUTURA.TABLE.stTable)
        Dim DirDefault As String = "Partials\"
        If LinguagemCriacao = eLinguagemCriacao.CSharp Then
            GerarArquivo(DirDefault & pTabela.Nome & ".cs", New My.Templates.CSharp.Model(Me, pTabela).TransformText())
        ElseIf LinguagemCriacao = eLinguagemCriacao.VBNET Then
            GerarArquivo(DirDefault & pTabela.Nome & ".vb", New My.Templates.VB.Model(Me, pTabela).TransformText())
        End If
    End Sub

    Public Sub GerarArquivosModelMeta(pTabela As LERESTRUTURA.TABLE.stTable)
        Dim DirDefault As String
        If LinguagemCriacao = eLinguagemCriacao.CSharp Then
            DirDefault = "PartialsMeta\"
            GerarArquivo(DirDefault & pTabela.Nome & ".cs", New My.Templates.CSharp.ModelMeta(Me, pTabela).TransformText())
        ElseIf LinguagemCriacao = eLinguagemCriacao.VBNET Then
            DirDefault = "PartialsMeta\"
            GerarArquivo(DirDefault & pTabela.Nome & ".vb", New My.Templates.VB.ModelMeta(Me, pTabela).TransformText())
        End If
    End Sub

    Public Sub GerarArquivo(pNomeArquivo As String, Conteudo As String)
        Dim Path As String = Diretorio & pNomeArquivo
        Dim DirInfo As New IO.DirectoryInfo(IO.Path.GetDirectoryName(Path))
        If Not DirInfo.Exists Then
            DirInfo.Create()
        End If
        Dim FileInfo As New IO.FileInfo(Path)
        If FileInfo.Exists Then
            FileInfo.Delete()
        End If

        Using strm As New StreamWriter(Path)
            strm.Write(Conteudo)
            strm.Close()
        End Using
    End Sub

    Public Function GeraLog() As Boolean
        Return (TipoLog = eLog.InserirAtualizarExcluir Or TipoLog = eLog.Tudo)
    End Function

#Region "Private methods"

    Public Function GetParamPK(pTabela As LERESTRUTURA.TABLE.stTable) As String
        Dim Result As String = ""
        Try
            If pTabela.ChavePrimaria IsNot Nothing Then
                For Each Item As LERESTRUTURA.TABLE.stCampo In pTabela.ChavePrimaria
                    If Not String.IsNullOrWhiteSpace(Result) Then Result += ", "
                    Result = GetColumnType(Item) & " p" & Item.Nome
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString())
        End Try

        Return Result
    End Function

    Public Function GetQueryPK(pTabela As LERESTRUTURA.TABLE.stTable) As String
        Dim Result As String = ""
        Try
            If pTabela.ChavePrimaria IsNot Nothing Then
                For Each Item As LERESTRUTURA.TABLE.stCampo In pTabela.ChavePrimaria
                    If LinguagemCriacao = eLinguagemCriacao.CSharp Then
                        If Not String.IsNullOrWhiteSpace(Result) Then Result += " & "
                        Result = " p." & Item.Nome & " == p" & Item.Nome
                    ElseIf LinguagemCriacao = eLinguagemCriacao.VBNET Then
                        If Not String.IsNullOrWhiteSpace(Result) Then Result += " And "
                        Result = " p." & Item.Nome & " = p" & Item.Nome
                    End If
                Next
            End If
            If Not String.IsNullOrWhiteSpace(Result) Then
                Result = "where " & Result
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString())
        End Try
        Return Result
    End Function

    Public Function GetQueryPKDelete(pTabela As LERESTRUTURA.TABLE.stTable) As String
        Dim Result As String = ""
        Try
            If pTabela.ChavePrimaria IsNot Nothing Then
                For Each Item As LERESTRUTURA.TABLE.stCampo In pTabela.ChavePrimaria
                    If LinguagemCriacao = eLinguagemCriacao.CSharp Then
                        Result = "Registro." & Item.Nome & " = p" & Item.Nome & ";" & vbCrLf
                    ElseIf LinguagemCriacao = eLinguagemCriacao.VBNET Then
                        Result = "Registro." & Item.Nome & " = p" & Item.Nome & vbCrLf
                    End If
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString())
        End Try
        Return Result
    End Function

    Private Function GetColumnType(Campo As LERESTRUTURA.TABLE.stCampo) As String
        If LinguagemCriacao = Configuracao.eLinguagemCriacao.CSharp Then
            Select Case Campo.Tipo
                Case LERESTRUTURA.TABLE.EnumTipo.eBool
                    Return "bool"
                Case LERESTRUTURA.TABLE.EnumTipo.eDate, LERESTRUTURA.TABLE.EnumTipo.eDateTime, LERESTRUTURA.TABLE.EnumTipo.eTime
                    Return "DateTime"
                Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                    Return "Decimal"
                Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                    Return "int"
                Case LERESTRUTURA.TABLE.EnumTipo.eByte
                    Return "byte"
                Case LERESTRUTURA.TABLE.EnumTipo.eText
                    Return "string"
                Case Else
                    Return "object"
            End Select
        ElseIf LinguagemCriacao = Configuracao.eLinguagemCriacao.VBNET Then
            Select Case Campo.Tipo
                Case LERESTRUTURA.TABLE.EnumTipo.eBool
                    Return "Boolean"
                Case LERESTRUTURA.TABLE.EnumTipo.eDate, LERESTRUTURA.TABLE.EnumTipo.eDateTime, LERESTRUTURA.TABLE.EnumTipo.eTime
                    Return "DateTime"
                Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                    Return "Decimal"
                Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                    Return "Integer"
                Case LERESTRUTURA.TABLE.EnumTipo.eByte
                    Return "Byte"
                Case LERESTRUTURA.TABLE.EnumTipo.eText
                    Return "String"
                Case Else
                    Return "Object"
            End Select
        End If
        Return ""
    End Function

#End Region

End Class
