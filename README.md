# Prut Project

Play fart sound on Raspberry Pi when triggered by external sensor

# Use Case

Whenever someone enters my bedroom through the door, a reverbing fart sound will be played.

# Architecture

Sensor at the door: Not defined yet.

Signal processing: Raspberry Pi 3 with Ubuntu

Speaker: Not defined yet.

Software: C# on .NET 6

# Getting started

## Building the software

`dotnet build`


# Hardware Setup

My hardware setup is a Raspberry P3B, with Ubuntu (64bit for amr64 architectures). The installation was done using the Raspberry Pi Imager. SSH and Wifi were configured directly using the imager tool (super convenient :-)).

After booting the RPI, I updated Ubuntu using the following commands:

```bash
sudo apt update
sudo apt upgrade
```

That took about 15 minutes to complete. But now I have a completely updated Ubuntu server on the RPI.

For testing the audio ourput, I used the sox package:

```bash
sudo apt install sox
play some_wav.wav
```

The sound played through the HDMI interface. All good.


# Dev Environment

## VSCode

The dev environment is based on VSCode and dotnet. The idea is to use VSCode on my Windows based computer, and develop via SSH. In order to make that a good experience, I installed the "Remote Development" add-on to VSCode. That lets me connect to the RPI, and develop on it, as if I was working on the local computer.

`git` was already conveniently pre-installed on Ubuntu on the RPI. I only needed to let git know who I was, and the code could be be downloaded. 

```bash
git config --global user.email "****@******.***"
git config --global user.name "noahlanz"
git clone https://github.com/noahlanz/prut
```

This downloads the source code onto te RPI. In VSCode, open the newly created folder, and we are now good to go.

## dotnet

I abandoned the path using Docker, as I will be programing the GPIO ports, and didnt want to add the complexity of figuring out how to route those ports through to the container. 

The result is that dotnet neds to be installed on the OS: https://docs.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual#scripted-install

```bash
wget https://dot.net/v1/dotnet-install.sh
chmod 700 dotnet-install.sh
./dotnet-install.sh
```

This will install the dotnet SDK under `~/.dotnet`. Add the that folder to the serahc path by adding the following line to the `.bashrc` file:

```bash
# dotnet path
if [ -d ~/.dotnet ]; then
    PATH=$PATH:~/.dotnet
fi
```

## Multi-user development

In order to develop in collboration, it is a good idea to set up individual accounts on the RPI for each user. On Ubuntu, the following is arguably the easiest way for adding a user called `bob`:

```bash
sudo adduser bob
sudo usermod -G adm,dialout,cdrom,sudo,audio,video,plugdev,games,users,input,render,netdev,gpio,spi,i2c bob
```

For the list of group associations, check the groups on another account that seems well configured using the `groups` command.

Remember to install `dotnet` for the new user too.