## .Net Web API with EF Core and Docker Compose

### 📃 Disclaimer
This is an API model based on the idea of a food delivery/restaurant takeout website. You can check it out using Swagger.  
The SQLExpress database runs inside the docker-compose container. 

### 🚀 How to run 
First clone this repo. Then navigate to /apimodel and run:
```
docker-compose up --build -d
```

Open the .sln file and click the 'run' button on Visual Studio. You should see Swagger running :)  

    
Stopping containers:
```
docker-compose stop
```
Restarting stopped containers:
```
docker-compose start
```
