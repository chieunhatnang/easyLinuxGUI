#!/bin/bash
#Script by Ngo Anh Tuan-lowendviet.com
#Change log
#2018-Sept-17: Initialize script
if [ $# -eq 4 ] ; then
    vncpw=$1
    ff=$2
    gc=$3
    wine=$4
else
    echo -e "Enter password of VNC"
    read  vncpw
    echo -e "Do you want to install Firefox browser?(1 = Yes, 0 = No)"
    read ff
    echo -e "Do you want to install Chrome browser?(1 = Yes, 0 = No)"
    read gc
    echo -e "Do you want to install Wine to run Windows software?(1 = Yes, 0 = No)"
    read wine

    if [ $ff -eq 1 ]; then
        ff=1
    else
        ff=0
    fi
    if [ $gc -eq 1 ]; then
        gc=1
    else
        gc=0
    fi
    if [ $wine -eq 1 ]; then
        wine=1
    else
        wine=0
    fi
fi
#Get OS
. /etc/lsb-release
OS=$DISTRIB_ID

useradd vnc
echo vnc:$vncpw | chpasswd
chsh -s /bin/bash vnc
usermod -aG sudo vnc
apt-get update -y

INSTALL_PKGS="xfce4 xfce4-goodies gnome-icon-theme sudo vnc4server tigervnc-common zip unzip file-roller gedit xfonts-base dbus-x11"
for i in $INSTALL_PKGS; do
  sudo apt-get install -y $i
done

mkdir -p /home/vnc/.vnc || true
echo -e '#!/bin/bash' > /home/vnc/.vnc/xstartup
echo -e "xrdb \$HOME/.Xresources" >> /home/vnc/.vnc/xstartup
echo -e "vncconfig -nowin &" >> /home/vnc/.vnc/xstartup
echo -e "startxfce4 &" >> /home/vnc/.vnc/xstartup
chmod +x /home/vnc/.vnc/xstartup
echo -e "$vncpw\n$vncpw\nn" | vncpasswd /home/vnc/.vnc/passwd
chown -R vnc:vnc /home/vnc
chmod 755 /home/vnc/.vnc

if [ $ff -eq 1 ]; then
    apt-get install -y iceweasel
    
fi
if [ $gc -eq 1 ]; then
    wget -q -O - https://dl.google.com/linux/linux_signing_key.pub | sudo apt-key add -
    echo "deb http://dl.google.com/linux/chrome/deb/ stable main" | sudo tee /etc/apt/sources.list.d/google-chrome.list
    apt-get update
    apt-get -y install google-chrome-stable
fi
if [ $wine -eq 1 ]; then
    dpkg --add-architecture i386
    apt-get -y install software-properties-common
    wget -nc https://dl.winehq.org/wine-builds/Release.key
    apt-key add Release.key
    if [ "$OS" = "Ubuntu" ]; then
        apt-add-repository https://dl.winehq.org/wine-builds/ubuntu/
    elif [ "$OS" = "Debian" ]; then
        apt-add-repository https://dl.winehq.org/wine-builds/debian/
    fi
    apt-get update
    apt-get -y install --install-recommends winehq-stable winetricks
fi
#Create & enable service

touch /lib/systemd/system/levvnc@.service || true
echo "[Unit]" > /lib/systemd/system/levvnc@.service
echo "Description=Automatic VNC service by https://lowendviet.com" >> /lib/systemd/system/levvnc@.service
echo "[Service]" >> /lib/systemd/system/levvnc@.service
echo "Type=forking" >> /lib/systemd/system/levvnc@.service
echo "User=vnc" >> /lib/systemd/system/levvnc@.service
echo "WorkingDirectory=/home/vnc" >> /lib/systemd/system/levvnc@.service
echo "PIDFile=/home/vnc/.vnc/%H:%i.pid" >> /lib/systemd/system/levvnc@.service
echo "ExecStartPre=-/usr/bin/vncserver -kill :%i > /dev/null 2>&1" >> /lib/systemd/system/levvnc@.service
echo "ExecStart=/usr/bin/vncserver -depth 16 -geometry 1280x800 :%i" >> /lib/systemd/system/levvnc@.service
echo "ExecStop=/usr/bin/vncserver -kill :%i" >> /lib/systemd/system/levvnc@.service
echo "ExecReload=/usr/bin/vncserver restart" >> /lib/systemd/system/levvnc@.service
echo "[Install]" >> /lib/systemd/system/levvnc@.service
echo "WantedBy=multi-user.target" >> /lib/systemd/system/levvnc@.service
systemctl daemon-reload
systemctl enable levvnc@1.service
if [ "$OS" = "Ubuntu" ]; then
    ufw allow 5901
    touch /var/lib/polkit-1/localauthority/50-local.d/disable-passwords.pkla
    echo -e "[Do anything you want]" > /var/lib/polkit-1/localauthority/50-local.d/disable-passwords.pkla
    echo -e "Identity=unix-group:root" > /var/lib/polkit-1/localauthority/50-local.d/disable-passwords.pkla
    echo -e "Action=*" > /var/lib/polkit-1/localauthority/50-local.d/disable-passwords.pkla
    echo -e "ResultActive=yes" > /var/lib/polkit-1/localauthority/50-local.d/disable-passwords.pkla
    reboot
fi
systemctl start levvnc@1.service