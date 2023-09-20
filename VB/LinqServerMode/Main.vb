Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Data.Linq
Imports DevExpress.XtraEditors

Namespace LinqServerMode

    Public Partial Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            linqInstantFeedbackSource.KeyExpression = "SupplierID"
            gridControl1.DataSource = linqInstantFeedbackSource
        End Sub

        Private Sub OnGetQueryable(ByVal sender As Object, ByVal e As GetQueryableEventArgs)
            Dim dt As NorthwindClassesDataContext = New NorthwindClassesDataContext()
            e.QueryableSource = dt.Suppliers
            e.Tag = dt
        End Sub

        Private Sub OnDismissQueryable(ByVal sender As Object, ByVal e As GetQueryableEventArgs)
            TryCast(e.Tag, NorthwindClassesDataContext).Dispose()
        End Sub
    End Class
End Namespace
