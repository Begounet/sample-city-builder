using UnityEngine;
using UnityEngine.InputSystem;

public class BuildingPlacement : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        if (Mouse.current?.leftButton.wasPressedThisFrame == true)
        {
            // TODO: raycast ground and place preview/confirm placement
        }
    }
}
