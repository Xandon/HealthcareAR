using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public int lockCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void increaseLockCount()
    {
        lockCount = lockCount + 1;
        Debug.Log("Lock Count: " + lockCount);
    }

    public void decreaseLockCount()
    {
        lockCount = lockCount - 1;
        Debug.Log("Lock Count: " + lockCount);
    }

    public int getLockCount()
    {
        return lockCount;
    }

    public void resetLockCount()
    {
        lockCount = 0;
    }
}
