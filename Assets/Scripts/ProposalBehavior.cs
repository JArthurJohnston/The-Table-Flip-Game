using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProposalBehavior : MonoBehaviour, IPickUpAble {
	GameObject holdingObject;

	public GameObject messageCanvas;

	public GameObject objectToHold;

	bool isHeld = false;

	public float smoothness;

	public float distance;

	public Camera playerCamera;

	Transform originalPosition;

	public void Update(){
		if(isHeld){
			this.moveToHoldingPosition();
		}
	}

	private void moveToHoldingPosition(){
		originalPosition = this.objectToHold.transform;
			float transitionTime = Time.deltaTime * smoothness;
			this.objectToHold.transform.position = Vector3.Lerp(
					this.objectToHold.transform.position, holdingObject.transform.position, transitionTime);
			this.objectToHold.transform.rotation = Quaternion.Lerp(
				this.objectToHold.transform.rotation, holdingObject.transform.rotation, transitionTime);
	}

	private void moveToOriginalPosition(){
			float transitionTime = Time.deltaTime * smoothness;
			this.objectToHold.transform.position = Vector3.Lerp(
					this.objectToHold.transform.position, originalPosition.position, transitionTime);
			this.objectToHold.transform.rotation = Quaternion.Lerp(
				this.objectToHold.transform.rotation, originalPosition.rotation, transitionTime);
	}

    public void pickUp(GameObject source)
    {
		holdingObject = source;
		isHeld = true;
		this.StartCoroutine(showMessage());
    }

	private IEnumerator showMessage(){
		yield return new WaitForSeconds(5);
		messageCanvas.SetActive(true);
	}

	private IEnumerator hideMessage(){
		yield return new WaitForSeconds(25);
		messageCanvas.SetActive(false);

	}

	/*
	Missy, I cannot easily express in words how much you mean to me. With you, I have done and seen things I never would have had I been left on my own.
	You have made me a better person.
	So all of this, and all of me, is for you. If you'll have me.
	Will you marry me?
	 */
}
