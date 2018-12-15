using UnityEngine;

public class FlipsThings : MonoBehaviour {
    
    // force: 15
    public float force;

    private void Update()
    {
        if (GvrControllerInput.ClickButtonUp)
        {
            GvrBasePointer pointer = GvrPointerInputModule.Pointer;
            UnityEngine.EventSystems.RaycastResult currentRaycastResult = pointer.CurrentRaycastResult;
            GameObject clickedObject = currentRaycastResult.gameObject;
            IFlippable flipTarget = clickedObject != null ? clickedObject.GetComponent<IFlippable>() : null;
            if (flipTarget != null)
            {
                flipTarget.flip(force, currentRaycastResult.worldPosition);
            }
        }
    }
}
