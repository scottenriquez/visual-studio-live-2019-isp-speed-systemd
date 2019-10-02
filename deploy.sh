#!/usr/env/bin bash
cd ~/Documents/GitHub/visual-studio-live-2019-isp-speed-systemd/src/SpeedTestWorkerService/SpeedTestWorkerService
dotnet build
dotnet publish -c Release -r linux-x64 --self-contained true
cd ~/Documents/GitHub/visual-studio-live-2019-isp-speed-systemd
sudo cp speedtest.service /etc/systemd/system/speedtest.service
sudo systemctl daemon-reload
sudo systemctl start speedtest.service