# How to bind LinqInstantFeedbackSource to GridControl 


<p>This example illustrates how to assign <strong>LinqInstantFeedbackSource</strong> to a grid. </p><p>To accomplish this, it is necessary to set the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataLinqLinqInstantFeedbackSource_KeyExpressiontopic"><u>LinqInstantFeedbackSource.KeyExpression property</u></a>  to a key property name.  Next, you should handle the  <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataLinqLinqInstantFeedbackSource_GetQueryabletopic"><u>LinqInstantFeedbackSource.GetQueryable event</u></a> and set the ee.QueryableSource property to assign your queryable source to LinqInstantFeedbackSource. Also, handle the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressDataLinqLinqInstantFeedbackSource_DismissQueryabletopic"><u>LinqInstantFeedbackSource.DismissQueryable event</u></a> to dispose of a DataContext object when it is no longer required. Finally, bind LinqInstantFeedbackSource to the grid by setting the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridControl_DataSourcetopic"><u>GridControl.DataSource property</u></a> .</p>

<br/>


