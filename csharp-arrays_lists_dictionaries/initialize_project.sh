#!/usr/bin/env bash
dotnet new console -n $1
cd $1
dotnet build
mv Program.cs "$1.cs"
touch main.cs

