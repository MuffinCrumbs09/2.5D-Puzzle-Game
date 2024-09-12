using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera[] cameras;

    private void Start()
    {
        CameraSetup();
    }

    private void CameraSetup()
    {
        for(int i = 0; i < cameras.Count(); i++)
        {
            int index = cameras.Count() - i;
            cameras[i].Priority = index;
        }
    }
}
