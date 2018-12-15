using UnityEngine;

public class ResetMenuAction : MonoBehaviour, IMenuItem
{
    public ResetableRoot resetableRoot;

    public void Activate()
    {
        resetableRoot.resetChildren();
    }
}
