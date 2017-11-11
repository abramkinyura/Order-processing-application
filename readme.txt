Create the MathService ASP.NET Web Service using Visual Studio.NET and the
Service1.asmx.cs file.


Copy the modules from Lab13.1 to reference:

>copy ..\..\Lab13.1\Solution\authenticate.exe	
>copy ..\..\Lab13.1\Solution\fulfillment.exe


To create the Web Service's proxy source code:

>wsdl http://localhost/MathService/service1.asmx?wsdl


Compile the new test client as follows:

>csc /out:testclient2.exe /r:authenticate.exe,fulfillment.exe testclient2.cs service1.cs 

In a separate console window, start the authenticate.exe server.
In a separate console window, start the fulfillment.exe server.

You can now run testclient2.exe in a separate console window.