<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128625797/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2805)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Bind to a queryable source (LinqInstantFeedbackSource) 

This example shows how to bind the WinForms Data Grid to [LinqInstantFeedbackSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqInstantFeedbackSource).

Set the [LinqInstantFeedbackSource.KeyExpression](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqInstantFeedbackSource.KeyExpression) property to a key property name.

```csharp
linqInstantFeedbackSource.KeyExpression = "SupplierID";
```

Handle the [LinqInstantFeedbackSource.GetQueryable](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqInstantFeedbackSource.GetQueryable) event. Set the `e.QueryableSource` property.

```csharp
void OnGetQueryable(object sender, GetQueryableEventArgs e) {
    NorthwindClassesDataContext dt = new NorthwindClassesDataContext();
    e.QueryableSource = dt.Suppliers;
    e.Tag = dt;  
}
```

Handle the [LinqInstantFeedbackSource.DismissQueryable](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqInstantFeedbackSource.DismissQueryable) event to dispose of a `DataContext` object when it is no longer required.

```csharp
void OnDismissQueryable(object sender, GetQueryableEventArgs e) {
    (e.Tag as NorthwindClassesDataContext).Dispose();
}
```

Bind `LinqInstantFeedbackSource` to the Grid control.

```csharp
gridControl1.DataSource = linqInstantFeedbackSource;
```


## Files to Review

* [Main.cs](./CS/LinqServerMode/Main.cs) (VB: [Main.vb](./VB/LinqServerMode/Main.vb))


## See Also

* [Large Data Sources: Server and Instant Feedback Modes](https://docs.devexpress.com/WindowsForms/8398/controls-and-libraries/data-grid/data-binding/large-data-sources-server-and-instant-feedback-modes)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-bind-to-linqinstantfeedbacksource&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-bind-to-linqinstantfeedbacksource&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
