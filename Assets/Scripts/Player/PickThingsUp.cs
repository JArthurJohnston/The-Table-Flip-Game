using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickThingsUp : MonoBehaviour {

	public GameObject holdingSpot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update()
    {
        if (GvrControllerInput.ClickButtonUp)
        {
            GvrBasePointer pointer = GvrPointerInputModule.Pointer;
            UnityEngine.EventSystems.RaycastResult currentRaycastResult = pointer.CurrentRaycastResult;
            GameObject clickedObject = currentRaycastResult.gameObject;
            IPickUpAble interactableObject = clickedObject != null ? clickedObject.GetComponent<IPickUpAble>() : null;
            if (interactableObject != null)
            {
				interactableObject.pickUp(this.holdingSpot);
            }
        }
    }
}
