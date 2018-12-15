using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractsWithThings : MonoBehaviour {

public GameObject holdSpot;
    private void Update()
    {
        if (GvrControllerInput.ClickButtonUp)
        {
            GvrBasePointer pointer = GvrPointerInputModule.Pointer;
            UnityEngine.EventSystems.RaycastResult currentRaycastResult = pointer.CurrentRaycastResult;
            GameObject clickedObject = currentRaycastResult.gameObject;
            IInteractable interactableObject = clickedObject != null ? clickedObject.GetComponent<IInteractable>() : null;
            if (interactableObject != null)
            {
				interactableObject.interact(holdSpot);
            }
        }
    }
}
