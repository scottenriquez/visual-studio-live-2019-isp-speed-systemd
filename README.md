# Visual Studio Live 2019 ISP Speed Test systemd Worker
This project is a proof-of-concept .NET Core 3.0 Linux worker service with systemd integration that gathers and logs internet speed data. It was inspired by a combination of a tech talk and extremely slow internet speeds at the hotel.

# Prerequisites
Naturally, this is intended to run on a Unix machine with the systemd suite. For reference, I used a Debian 9 machine for all development and testing.

# Getting Started
To run locally without integrating with systemd, simply navigate to the folder with the <code>.csproj</code> file and use <code>dotnet build</code> and <code>dotnet run</code>. To build, publish, and integrate with systemd, run <code>sh deploy.sh</code>. Since this is a simple proof-of-concept, you'll need to update the paths in the Shell script to get this working on your machine. Normally, you would move the executable somewhere like the <code>/sbin</code> folder outside of the local repository file structure.

# Checking Output
To view the status of the service, run <code>sudo systemctl status speedtest</code>. You can also view the logs using <code>sudo journalctl -u speedtest</code>.

# Tearing Down
To stop the service, run <code>sudo systemctl stop speedtest.service</code>.