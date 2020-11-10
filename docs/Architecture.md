[Go back](../README.md)
# Basic business strategy for an IOT Company
To provide smart home solutions for end users, a company (whose aim is to sell smart objects) has to focus its business on two directions:
1. producing the actual smart objects (the hardware part)
2. developing a mobile / wep app to allow users to connect and control the smart objects (the software part)

While the process of producing the objects may vary from an object type to another (in terms of what the final purpose is), the app should include similar features applying to all items.

First step after purchasing a smart object is to connect it to the app. For this, the end user needs a WiFi internet connection.

For easing the connection process with the app, manufacturer could attach a QR code to each item.
Using a smartphone to scan the code, users can install the app and start connecting the device.

When the installation has finished, and the smart object was added within the app, both the smartphone and the smart object can now communicate with a main server through bidirectional protocols (REST APIs). 
From the app, customers can program and control the various options according to the device features.
A simple way to describe the behavior would be: the data gathered from devices is sent to the server where it gets interpreted. The response (notifications) are sent back to the app.
This process is bidirectional.

### Mobile / web app main features:
1. allow users to signup / signin
2. activate / deactivate / configure device specific options
3. on / off option to collect customer data
4. AI learning based on customers behaviour and provide personalized recommendations 
5. help tutorials for how to use the app
6. option to purchase extended cloud storage for recording devices (e.g webcams)
7. option for customers to send feedback / review
8. multi-language ( + customer support)



### IoT Architecture
Smart devices are connected with a cloud server using a WiFi connection.
Server gets the message from the device, processes it, then sends back a notification to the user smartphone that is connected with that device.

When a user wants to control the smart object, a API request is sent to the server, the server is again processing the request, then sends the command to the smart device.

Other systems can be connected to the same main server, like:
- portal admins - maintain the system, manage and configure all custom portal applications, monitor and analyze system metrics, assist to resolve all production issues, etc.
- remote experts or advisors - can provide support for customers
- big data - artificial intelligence learning algorithms 

![alt_text](IoT%20Architecture.jpg)
### [Go back](../README.md) ###
