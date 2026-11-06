# Docker Console App
small console app which prints greeting with current time, build and run using docker.

## Files
1. HelloApp - console app
2. dockerfile - instruction to build image
3. dockerignore 

## Commands


## to check version
docker version

## build the Docker image 
docker build -t helloapp .

## run the Docker container
docker run --rm helloapp

## to list containers
docker ps -a 

## to list images
docker images


## output
Hi from Neehar at hour/minute/seconds
 - in UTC because containers use UTC by default

## working of dockerfile
FROM - starts from .NET SDK image
WORKDIR - sets folder to /app
COPY - copies app into image
ENTRYPOINT - runs dotnet run when container starts