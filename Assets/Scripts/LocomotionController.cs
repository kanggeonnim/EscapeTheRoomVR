using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class LocomotionController : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionReference teleportReference =null;
    public GameObject teleportRay;

    private float value;

    private void Update() {
        float value = teleportReference.action.ReadValue<float>();
        if(value > 0.1f)
        {
            teleportRay.SetActive(true);
        }
        else
        {
            teleportRay.SetActive(false);
        }
    }
}
