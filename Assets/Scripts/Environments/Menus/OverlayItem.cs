using UnityEngine;
using UnityEngine.Rendering;

public class OverlayItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.renderQueue = (int)RenderQueue.Overlay;
	}

}
