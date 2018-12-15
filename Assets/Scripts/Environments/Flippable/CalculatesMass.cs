using UnityEngine;

public class CalculatesMass : MonoBehaviour {

	// Use this for initialization
	void Start () {
        RectTransform rt = gameObject.transform as RectTransform;
        
        Debug.Log(gameObject.name + " Width: " + GetComponent<Collider>().bounds.size);
	}
	
}
