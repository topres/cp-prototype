FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app
COPY . ./

RUN cd CustomerPortalPrototype.RobotRegistrationApi
RUN dotnet restore
RUN dotnet publish -c Release -o ../output

# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build-env /app/output .
ENTRYPOINT ["dotnet", "CustomerPortalPrototype.RobotRegistrationApi.dll"]