#!/bin/bash

set -e
run_cmd="dotnet run --project Cars.WebApi/Cars.WebApi.csproj --server.urls http://*:80"

cd Cars.Data

until dotnet ef database update; do
    >&2 echo "SQL Server is starting up"
    sleep 1
done

>&2 echo "SQL Server is up - executing command"
cd ..
exec $run_cmd