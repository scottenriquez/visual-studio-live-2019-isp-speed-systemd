sh add-service-file-to-systemd.sh
sudo systemctl daemon-reload
sudo systemctl start speedtest.service
sudo systemctl status speedtest