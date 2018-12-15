using UnityEngine;

public class ResetsThings : MonoBehaviour {
    public ResetableRoot resetRoot;
	
	// Update is called once per frame
	void Update () {
        if (GvrControllerInput.AppButtonUp)
        {
            resetRoot.resetChildren();
        }
	}
}
