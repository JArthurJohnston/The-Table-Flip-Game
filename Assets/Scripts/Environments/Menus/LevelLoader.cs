using UnityEngine;

public class LevelLoader : MonoBehaviour {

    public GameObject loadingScreen;
    // public Camera camera;
    
	// Update is called once per frame
	void Update () {

        if (GvrControllerInput.ClickButtonUp)
        {
            var menuItem = GetClickedMenuItem();
            if(menuItem != null)
            {
                showLoadingScreen();
                menuItem.Activate();
            }
        }

    }

    private void showLoadingScreen(){
        loadingScreen.SetActive(true);
    }

    private static IMenuItem GetClickedMenuItem()
    {
        GvrBasePointer pointer = GvrPointerInputModule.Pointer;
        UnityEngine.EventSystems.RaycastResult currentRaycastResult = pointer.CurrentRaycastResult;
        GameObject clickedObject = currentRaycastResult.gameObject;
        if(clickedObject != null & clickedObject.GetComponent<ClickableMenuItem>() != null)
        {
            return clickedObject.GetComponent<IMenuItem>();
        }
        return null;
    }
}
