# Authorization solution
Solution for authorization project.

## Solution Goal  
The goal for this is to implement a JWT(JSON Web Token)  
By using JWT it should be possible to authenticate the user of an application.  
  
## Ensuer the correct nuget packages is installed   
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer
Install-Package System.IdentityModel.Tokens.Jwt

or use the nugetpackes tab.  
  
## Run solution setup  

docker compose up --build  
  
Aftward go to the URL: http://localhost:5171/swagger/index.html  
