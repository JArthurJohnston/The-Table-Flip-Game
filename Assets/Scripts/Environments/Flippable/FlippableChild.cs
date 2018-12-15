using UnityEngine;

public class FlippableChild : MonoBehaviour, IFlippable {

    private Flippable _parent;

    public void flip(float force, Vector3 position)
    {
        _parent.flip(force, position);
    }

    private void Start()
    {
        _parent = gameObject.GetComponentInParent<Flippable>();
    }
}
