using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentButtonBehavior : MonoBehaviour {

    [SerializeField] private GameObject activeObjectsEmpty;
    [SerializeField] private GameObject equipmentObject;

	public void EquipmentButtonPressed()
    {
        // Parent object to active objects
        equipmentObject.transform.SetParent(activeObjectsEmpty.transform);

        // Make object visible
        equipmentObject.SetActive(true);


        // Set object y to 0 (ground)
        float newX = equipmentObject.transform.position.x;
        float newZ = equipmentObject.transform.position.z;

        equipmentObject.transform.position = new Vector3(newX, 0, newZ);
    }
}
