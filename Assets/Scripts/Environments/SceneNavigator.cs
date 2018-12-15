using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator {
    const string MAIN_MENU = "3DMainMenu";
    const string FANCY_ROUND_TABLE = "FancyRoundTable";
    const string SIMPLE_WOOD_TABLE = "SimpleWoodenTable";

    public static void NavitgateToMainMenuScene()
    {
        NavigateTo(MAIN_MENU);
    }

    public static void NavigateToFancyRoundTableScene()
    {
        NavigateTo(FANCY_ROUND_TABLE);
    }

    public static void NavigateToSimpleWoodTableScene()
    {
        NavigateTo(SIMPLE_WOOD_TABLE);
    }

    private static void NavigateTo(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
