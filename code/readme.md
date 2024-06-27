# YORO
## Description
This is YORO's open source and code.

This directory contains:
- UnityProject: Unity project of YORO.
- DataSample: Sample images for yoro in 3 scenes.
- Python: Python implementation for median algorithm.
- Compiled: Contains a build of YORO for Android and a packaged YORO for import stored in `.unitypackage` format.

## System Requirements
- Windows 10 or Windows 11
- Unity 2021.3.12

## Build
- Open the project using unity under the folder `UnityProject`
- Switch the build platform to Android

## Package Usage
- Import the `YORO.unitypackage` under the folder `YORO Demo` into unity.
- Open the window `Window -> Package Manager` and install `XR Plugin Management`
- Open the window `Edit -> Project Settings`
- Select `XR Plug-in Management` and check up the `Mock HMD Loader`
- Select `MockHMD` under `XR Plug-in Management` and switch `Render Mode` to `Multi Pass`

## Copyright
This is the internal open source version of YORO, 
please do not share it with others, 
the source code will be made public on GitHub when the paper is conditionally accepted.
All rights reserved by YORO's authors.