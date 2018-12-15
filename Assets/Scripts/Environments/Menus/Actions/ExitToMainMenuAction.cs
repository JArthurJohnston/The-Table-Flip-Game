using UnityEngine;

public class ExitToMainMenuAction : MonoBehaviour, IMenuItem {

    public void Activate()
    {
        SceneNavigator.NavitgateToMainMenuScene();
    }
}
