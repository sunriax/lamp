[![Version: 1.0 Release](https://img.shields.io/badge/Version-1.0%20Release-green.svg)](https://github.com/sunriax/lamp)    [![License: GPL v3](https://img.shields.io/badge/License-GPL%20v3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

# Controllable Lamp (Signal) over Wireless LAN ([Shelly](https://shop.shelly.cloud/shelly-1-wifi-smart-home-automation#50))

## Project description

The PCB (lamp) can be controlled over a [Shelly](https://shop.shelly.cloud/shelly-1-wifi-smart-home-automation#50) wireless LAN module. It is attached to the PCB and can be controlled over the [Web Control](https://sunriax.github.io/lamp/) interface or any other software. Currently the lamp is designed for alerting. It changes the color within a given time. The lamp can be configured over the [Lamp Control](https://github.com/sunriax/lamp/releases/download/v1.0/Lamp.zip) application. Also the attached PC can be informed that an alert (over wireless LAN) occurrs. The current firmware can be downloaded [here](https://github.com/sunriax/lamp/releases/download/v1.0-Firmware/Firmware.zip). An ISP programmer for ATmega8 is necessary to flash the firmware onto the PCB.

## Project status

### Application

| Program     | Status |
|-------------|--------|
| Web Control | [![Web Control](https://img.shields.io/badge/control-Online-brightgreen.svg)](https://sunriax.github.io/lamp/) |
| Application | [![Build Application](https://github.com/sunriax/lamp/actions/workflows/msbuild.yml/badge.svg)](https://github.com/sunriax/lamp/actions/workflows/msbuild.yml) |
|             | [![Release Lamp Application](https://github.com/sunriax/lamp/actions/workflows/upload.yml/badge.svg)](https://github.com/sunriax/lamp/actions/workflows/upload.yml) |
| Firmware    | [![Build Status](https://app.travis-ci.com/sunriax/lamp.svg?branch=main)](https://app.travis-ci.com/sunriax/lamp) |

### Schematic/PCB

![PCB 3D Model](pcb.png)

| Board | Status |
|-------|:------:|
| [Schematic](https://cadlab.io/project/23814/main/circuit/cGNiL3BjYi5zY2g%3D) | ✔️ Done |
| [Board](https://cadlab.io/project/23814/main/circuit/cGNiL3BjYi5raWNhZF9wY2I%3D) | ✔️ Done |
| [Partlist](partlist.csv) | ✔️ Done |
| Production | ✔️ Done |
| [Assembly](pcb_assembled.png) | ✔️ Done |
| Case | ❌ Open |
