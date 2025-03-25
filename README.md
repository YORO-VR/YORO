# YORO
## Description
This is YORO's open source data and code.

This directory contains:
- code: Contains Unity project, python code and a build for android.
- data: Contains the raw data of evaluation and figures on the paper.

## System Requirements
- Windows 10 or Windows 11
- Unity 2021.3.12

# Installation Guide
- Execute the `setup.cmd`
- Extract the zip file in `./code/Compiled` folder

# Build for Oculus Quest
- Open the `UnityProject` using Unity 2021.3.12
- Open `Edit -> Project Settings`
- Click `XR Plug-in Management`
- Click `Android`
- Check `Oculus`
- Click `Oculus` under the `XR Plug-in Management`
- Click `Android`
- Switch `Stereo Rendering Mode` to `Multi Pass`
- Open `File -> Build Settings`
- Click `Android`
- Click `Switch Platform`
- Click `Build` and select a folder.
- Upon building finished, the built `.apk` file should be in the selected folder.

## Copyright
This is the internal open source version of YORO, 
please do not share it with others, 
the source code will be made public on GitHub when the paper is conditionally accepted.
All rights reserved by YORO's authors.
