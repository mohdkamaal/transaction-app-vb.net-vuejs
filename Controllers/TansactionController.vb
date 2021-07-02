Imports System.Web.Mvc

Namespace Controllers
    Public Class TansactionController
        Inherits System.Web.Mvc.Controller
        <Route("transactions")>

        'Get: Tansaction
        Function Index() As ActionResult
            Dim entries As New accountEntities()
            Return View(entries.transactionTableSet.ToList())
        End Function

        ' GET: Tansaction/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Tansaction/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Tansaction/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Tansaction/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Tansaction/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Tansaction/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Tansaction/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace