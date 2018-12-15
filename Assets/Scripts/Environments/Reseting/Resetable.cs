using UnityEngine;

public class Resetable : MonoBehaviour {

    private Vector3 _startingPosition;
    private Quaternion _startingRotation;

    void Start()
    {
        _startingPosition = gameObject.transform.position;
        _startingRotation = gameObject.transform.rotation;
    }

    public void resetPositionAndForce()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        gameObject.transform.rotation = _startingRotation;
        gameObject.transform.position = _startingPosition;
    }
}
