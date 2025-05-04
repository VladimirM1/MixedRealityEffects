# Native XrCamera Sample

## Overview
Quest3 and Quest 3s implements Android the Android Camera2 API, which allows developers to capture camera images from the two cameras representing the left eye and right eye. Camera intrinsics and extrinsics are also available and should be used to calculate precise offsets of each camera from their corresponding tracked eye pose.

## The Sample
This sample demonstrates how developers can use Camera 2 API to:

1. Enumerate available cameras
1. Open a camera device
1. Set up a request for camera images
1. Access camera image data from app code to calculate average brightness
1. Utilize the timestamp of the image and the camera lens extrinsic data to calculate an accurate camera pose
1. Stop and re-start a camera device

## Known Issues
1. *Permissions* - this version of the XrCamera sample uses the standard Android Camera permission and that permission needs to be granted manually in system settings. You can locate the camera permission in this path: Settings > Privacy & Safety > App Permissions > Headset Cameras. Toggle the camera permission to "XRCamera Sample" to enable camera access.

2. Close the sample using the _Exit_ button rather than closing it via shell to make sure that the camera resources are torn down properly. This is an issue in the sample framework and not in the Camera 2 implemention itself.

## Build with CMake on Android Studio
1. If this is the first time you are launching Android Studio, select Open an existing Android Studio project. If you have launched Android Studio before, click File > Open instead.
2. Open build.gradle under Samples folder
   * You could also open individual sample app from the Samples/XrSamples folders. For example, Samples/XrSamples/XrHandsFB/Projects/Android/build.gradle
3. After the build has finished, directly run a sample with the device connected. Click Run in the toolbar.

## Running XrCameraSample
On startup the application will query the Camera2 API for all camera configurations available from the Quest 3 or Quest 3s and the Average Brightness, Camera Position, and Camera Rotation values on the right side of the screen will be blank. The camera configuration information includes the lens position and rotation relative to the center of the HMD. This is used to compute the exact position of the camera at the time of the image.

You can easily test whether the average brightness data is working properly by covering the left camera and observing the value decreasing drastically. The pose data should update in an expected manner as you move the HMD.

### Starting The Camera
Once the Start Camera button is pressed the left camera will be opened and a repeating request for camera images will be made. When a new camera image is available the image data and a timestamp will be passed to a callback function that will use that information to compute the average brightness and the UI will be updated. Camera2 provides the camera image in YUV (NV21) format.

In addition to computing the brightness, the callback function will use the timestamp, the camera pose offset from the center of the HMD (mentioned above), and the OpenXR API for retrieving the HMD pose to compute the precise pose of the camera at the time the image was captured, This precision can be desirable for some CV applications so we felt it was valuable to to demonstrate it in the sample.

### Stopping The Camera
When Stop Camera is pressed the image capture stops and the values in the UI will no longer update. Image capture will resume by pressing Start Camera.

### Exiting The Sample
It is suggested that users exit the app by pressing the Exit button rather than quitting the application in the shell due to a bug in the sample framework where the camera does not immediately shut down.

## Troubleshooting
1. Check the logs if you encounter errors or crashes. Both the sample and the Camera2 implementation have lots of descriptive log messages that should be able to help narrow the problem.
1. Make sure the Android camera permission is granted after installing the APK. See the Managing Permissions section for instructions,

## License
Meta OpenXR SDK is subject to the Oculus SDK License Agreement, as found in the LICENSE file.
