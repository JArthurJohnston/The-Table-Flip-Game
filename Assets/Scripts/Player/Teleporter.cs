using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject floor;

    // Update is called once per frame
    void Update()
    {
        if (GvrControllerInput.ClickButtonUp)
        {
            GvrBasePointer pointer = GvrPointerInputModule.Pointer;
            UnityEngine.EventSystems.RaycastResult currentRaycastResult = pointer.CurrentRaycastResult;
            if (currentRaycastResult.gameObject == floor)
            {
                float xPosition = currentRaycastResult.worldPosition.x;
                float zPosition = currentRaycastResult.worldPosition.z;
                teleport(xPosition, zPosition);
            }
        }
    }

    void teleport(float x, float z)
    {
        var currentPosition = gameObject.transform.position;
        var newPosition = new Vector3(x, currentPosition.y, z);
        gameObject.transform.position = newPosition;
    }
}
