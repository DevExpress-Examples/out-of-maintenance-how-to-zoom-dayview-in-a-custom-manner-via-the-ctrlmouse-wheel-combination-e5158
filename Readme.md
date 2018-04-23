# How to zoom DayView in a custom manner via the CTRL+MOUSE WHEEL combination


<p>This example illustrates how to substitute the MouseHandlerService service for extending the standard zooming feature. To accomplish this task, you need to create a custom MouseHandlerServiceWrapper class and override its OnMouseWheel method. In this sample, the ViewZoomOutCommand and ViewZoomInCommand descendants with extended functionality are created. This approach allows you to zoom the DayView view from 5 minutes till 7 days.</p>

<br/>


