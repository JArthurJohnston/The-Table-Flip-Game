using UnityEngine;

public class ResetableRoot : MonoBehaviour {

    public void resetChildren()
    {
        Resetable[] thingsToReset= gameObject.GetComponentsInChildren<Resetable>();
        foreach (Resetable thingToReset in thingsToReset)
        {
            thingToReset.resetPositionAndForce();
        }
    }
}
