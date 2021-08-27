<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128625797/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2805)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Main.cs](./CS/LinqServerMode/Main.cs) (VB: [Main.vb](./VB/LinqServerMode/Main.vb))
* [Program.cs](./CS/LinqServerMode/Program.cs) (VB: [Program.vb](./VB/LinqServerMode/Program.vb))
<!-- default file list end -->
# How to bind LinqInstantFeedbackSource to GridControl 


<p>This example illustrates how to assign <strong>LinqInstantFeedbackSource</strong> to a grid. </p><p>To accomplish this, it is necessary to set the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataLinqLinqInstantFeedbackSource_KeyExpressiontopic"><u>LinqInstantFeedbackSource.KeyExpression property</u></a>  to a key property name.  Next, you should handle the  <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataLinqLinqInstantFeedbackSource_GetQueryabletopic"><u>LinqInstantFeedbackSource.GetQueryable event</u></a> and set the ee.QueryableSource property to assign your queryable source to LinqInstantFeedbackSource. Also, handle the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataLinqLinqInstantFeedbackSource_DismissQueryabletopic"><u>LinqInstantFeedbackSource.DismissQueryable event</u></a> to dispose of a DataContext object when it is no longer required. Finally, bind LinqInstantFeedbackSource to the grid by setting the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridControl_DataSourcetopic"><u>GridControl.DataSource property</u></a> .</p>

<br/>


