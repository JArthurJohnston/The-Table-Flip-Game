using UnityEngine;

public class Flippable : MonoBehaviour, IFlippable {
    private Rigidbody _rigidbody;

    /**
     * radius: 5
     * upwards movement: 0.5
     */
    public float radius, upwardsMovement;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    public void flip(float force, Vector3 position)
    {
        _rigidbody.AddExplosionForce(force, position, radius, upwardsMovement, ForceMode.Impulse);
    }
}
