using UnityEngine;
using UnityEngine.XR;

public class DeviceManager : MonoBehaviour
{
    private bool _isComputer = false;

    // Reference to the target GameObject to teleport to
    //public Transform teleportTarget;

    public SimpleMove simpleMove;
    public OVRPlayerController ovrPlayerController;


    void Start()
    {
        // Check if XR settings are supported
        if (XRSettings.isDeviceActive)
        {
            // XR device is active, meaning the player is using a VR device
            Debug.Log("VR Device Detected: " + XRSettings.loadedDeviceName);
            _isComputer = false;
            ovrPlayerController.enabled = true;
            simpleMove.enabled = false;

        }
        else
        {
            // No XR device active, the player is on a standard computer
            Debug.Log("No VR Device Detected. Standard Computer.");
            _isComputer = true;
            ovrPlayerController.enabled = false;
            simpleMove.enabled = true;

        }
    }




}
