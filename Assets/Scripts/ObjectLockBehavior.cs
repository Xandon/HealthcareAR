using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLockBehavior : MonoBehaviour {

    private bool locked;

	// Use this for initialization
	void Start () {
        locked = false;
	}
	
	public void lockObject()
    {
        locked = true;
    }

    public void unlockObject()
    {
        locked = false;
    }

    public bool GetLockedState()
    {
        return locked;
    }
}
