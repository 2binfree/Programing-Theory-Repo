using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public bool isCubeSelected = false;
    public bool isSphereSelected = false;
    public bool isCapsuleSelected = false;
    public Vector3 cubeTarget;
    public Vector3 sphereTarget;
    public Vector3 capsuleTarget;

    public void SetTarget(Vector3 target)
    {
        if (isCapsuleSelected) {
            capsuleTarget = target;
        }
        if (isSphereSelected) {
            sphereTarget = target;
        }
        if (isCubeSelected) {
            cubeTarget = target;
        }
    }

    public void ResetSelected()
    {
        isCapsuleSelected = false;
        isCubeSelected = false;
        isSphereSelected = false;
    }
}
