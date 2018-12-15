using UnityEngine;

public class QuitMenuItem : MonoBehaviour, IMenuItem {

    public void Activate()
    {
        Application.Quit();
    }
}
