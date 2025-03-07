# Authorization solution

Solution for authorization project.

## Solution Goal  
The goal for this is to implement a JWT(JSON Web, Token)  
And using it fir authenticat the use os an application.  
I chose to fouces on this because it eliminates the dependency of a database.  
  
## Ensuer the correct nuget packages is installed   
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer
Install-Package System.IdentityModel.Tokens.Jwt

## Run solution setup  
```sh
docker compose up --build  
  
Aftward go to the URL: http://localhost:5171/swagger/index.html  

```  



