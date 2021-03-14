using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Runner.Camera
{
    [CreateAssetMenu (menuName = "Camera / CameraSettings")]
    public class CameraSettings : ScriptableObject
    { 
       [SerializeField] private Vector3 _cameraOffset;
       public Vector3 CameraOffset => _cameraOffset;
       
       
       
       
       
       
    }
}

