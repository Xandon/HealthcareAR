using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActiveState : MonoBehaviour {

    [SerializeField] private GameObject toggleObject;

	public void toggleActive()
    {
        if (toggleObject.activeInHierarchy == true)
        {
            toggleObject.SetActive(false);
        }
        else
        {
            toggleObject.SetActive(true);
        }
    }
}
