# API for locking / unlocking a door smartlock
### [Architectural description](docs/Architecture.md) ###
## How it works
API is developed using .NET / C# and MongoDB for database.  
The API needs a token to identify a device, then updates the state for the selected device.  
If token is not specified, an error message is returned.

### Current features
1. Read locker current status
2. Lock 
3. Unlock

Every lock / unlock action is logged in a database table.

### Installation / Usage
1. Download and install .NET Core 3.1 or later.
2. Clone the repository.
3. Install MongoDB dependencies using docker: 
    ```
    docker-compose up -d
    ```
   _If using docker is not an option, switch to using the free cloud version of MongoDB.  
   To do so, go to **MongoConnnection.cs** model, and switch between the two options._
4. Run the application:
   
   ```
   $ dotnet build 
   $ dotnet run --project iotapi
   ```




API URLs:

```Valid Token: ?token=tokenfajsjka6a47bd7e6b3d6```

|METHOD|ROUTE|DESCRIPTION|OPEN
|------|-----|--------------|------|
|GET|/api/device/read| lists the current status of the specified device (from the database)|[Check status](https://localhost:5001/api/device/read/?token=tokenfajsjka6a47bd7e6b3d6)
|GET|/api/device/lock|locks the device identified by the token|[Lock](https://localhost:5001/api/device/lock/?token=tokenfajsjka6a47bd7e6b3d6)
|GET|/api/device/unlock|unlocks the device identified by the token|[Unlock](https://localhost:5001/api/device/unlock/?token=tokenfajsjka6a47bd7e6b3d6)



