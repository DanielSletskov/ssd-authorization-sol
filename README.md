# Authorization solution
Solution attempt for authorization project.

## Solution Goal  
The goal for this is to implement a JWT(JSON Web Token) and to use it for authenticate using tokens.  
  
By using JWT it should be possible to authenticate the user of an application.  
  
## Ensuer the correct nuget packages is installed  
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer  
Install-Package System.IdentityModel.Tokens.Jwt  
  
or use the nugetpackes tab.  
  
## Run solution setup  

Pull repo.  
  
docker compose up --build  
  
Aftward go to the URL: http://localhost:5171/swagger/index.html  
