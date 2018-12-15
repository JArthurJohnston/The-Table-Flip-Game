using UnityEngine;

public class TableBehavior : Resetable {
    public ResetableRoot tableStuff;
    public float resetFloor;
    /*
     * Mass: 0.88
     * resetFloor: -3
     */

    void Update()
    {
        if (gameObject.transform.position.y < resetFloor)
        {
            this.resetPositionAndForce();
            tableStuff.resetChildren();
        }
    }
}
