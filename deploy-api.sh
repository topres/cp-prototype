docker build -f "CustomerPortalPrototype.RobotRegistrationApi/Dockerfile" -t customerportalprototyperegistry.azurecr.io/customer-portal-api .
az acr login --name customerportalprototyperegistry -g customer-portal-prototype
docker push customerportalprototyperegistry.azurecr.io/customer-portal-api