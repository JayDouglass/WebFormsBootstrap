Imports System.Web.Mvc

Namespace Common
    Public Class TempData
        Public Shared Property Current() As TempDataDictionary
            Get
                Return DirectCast(HttpContext.Current.Items("TempDataDictionary"), TempDataDictionary)
            End Get
            Set(value As TempDataDictionary)
                HttpContext.Current.Items("TempDataDictionary") = value
            End Set
        End Property
    End Class
End Namespace