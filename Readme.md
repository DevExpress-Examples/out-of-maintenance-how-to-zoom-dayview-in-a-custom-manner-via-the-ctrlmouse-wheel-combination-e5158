<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636464/13.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5158)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to zoom DayView in a custom manner via the CTRL+MOUSE WHEEL combination


<p>This example illustrates how to substitute the MouseHandlerService service for extending the standard zooming feature. To accomplish this task, you need to create a custom MouseHandlerServiceWrapper class and override its OnMouseWheel method. In this sample, the ViewZoomOutCommand and ViewZoomInCommand descendants with extended functionality are created. This approach allows you to zoom the DayView view from 5 minutes till 7 days.</p>

<br/>


