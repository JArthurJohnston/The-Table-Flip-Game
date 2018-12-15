using UnityEngine;

public class DebugController : MonoBehaviour {
    private float _heightIncrementValue = 0.25f;
    public bool displayClickedObjects;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 currentPosition = gameObject.transform.position;
            gameObject.transform.position = new Vector3(currentPosition.x, currentPosition.y - _heightIncrementValue, currentPosition.z);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 currentPosition = gameObject.transform.position;
            gameObject.transform.position = new Vector3(currentPosition.x, currentPosition.y + _heightIncrementValue, currentPosition.z);
        }

        if (GvrControllerInput.ClickButtonUp & displayClickedObjects)
        {
            GvrBasePointer pointer = GvrPointerInputModule.Pointer;
            UnityEngine.EventSystems.RaycastResult currentRaycastResult = pointer.CurrentRaycastResult;
            Debug.Log("Clicked: " + currentRaycastResult.gameObject.name);
        }
    }
}
