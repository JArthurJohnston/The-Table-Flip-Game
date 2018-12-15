using UnityEngine;

public class MenuController : MonoBehaviour {
    private static float NORMAL_TIMESCALE = 1f;
    private static float PAUSED_TIMESCALE = 0.0001f;
    private bool _isPaused;

    public GameObject menu;
    public float menuHeight;

    private void Start()
    {
        HideMenu();
    }

    public void ShowMenu()
    {
        menu.SetActive(true);
        Time.timeScale = PAUSED_TIMESCALE;
        _isPaused = true;
    }

    public void HideMenu()
    {
        menu.SetActive(false);
        Time.timeScale = NORMAL_TIMESCALE;
        _isPaused = false;
    }

    // Update is called once per frame
    void Update () {
        if (GvrControllerInput.ClickButtonUp)
        {
            var menuItem = GetClickedMenuItem();
            if (menuItem != null)
            {
                menuItem.Activate();
                HideMenu();
            }
        }
        if (GvrControllerInput.AppButtonUp)
        {
            if (_isPaused)
            {
                HideMenu();
            } else
            {
                ShowMenuFacingPlayer();
            }
        }
    }

    private static IMenuItem GetClickedMenuItem()
    {
        GvrBasePointer pointer = GvrPointerInputModule.Pointer;
        UnityEngine.EventSystems.RaycastResult currentRaycastResult = pointer.CurrentRaycastResult;
        GameObject clickedObject = currentRaycastResult.gameObject;
        if (clickedObject != null & clickedObject.GetComponent<IMenuItem>() != null)
        {
            return clickedObject.GetComponent<IMenuItem>();
        }
        return null;
    }

    private static Vector3 cameraViewPosition = new Vector3(0.5f, 0.5f, 10f);

    public void ShowMenuFacingPlayer()
    {
        Vector3 menuPosition = Camera.main.ViewportToWorldPoint(cameraViewPosition);
        menu.transform.position = new Vector3(menuPosition.x, menuHeight, menuPosition.z);
        menu.transform.LookAt(Camera.main.transform);
        menu.transform.Rotate(new Vector3(0, 180));
        //menu.transform.rotation = Quaternion.LookRotation(menu.transform.position) * Quaternion.Euler(0, 180, 0);
        ShowMenu();
    }
}
