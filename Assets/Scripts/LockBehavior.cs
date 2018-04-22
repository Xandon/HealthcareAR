using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockBehavior : MonoBehaviour {

    [SerializeField] GameObject lockButton;
    [SerializeField] GameObject unlockButton;
    [SerializeField] private Button equipmentButton;
    [SerializeField] private GameObject equipmentObject;
    private Color inactiveColor;
    private Color activeColor;

    public void Start()
    {
        inactiveColor = new Color(174f, 174f, 174f);
        activeColor = new Color(255f, 255f, 255f);
    }

    public void Unlock()
    {
        // Hide Lock button
        lockButton.SetActive(false);

        // Show Unlock button
        unlockButton.SetActive(true);

        // Make Equipment Button Active
        equipmentButton.interactable = true;
        ColorBlock cb = equipmentButton.colors;
        cb.normalColor = activeColor;
    }

    public void Lock()
    {
        // Can only lock if object is active
        if (equipmentObject.activeSelf == true)
        {
            // Hide Unlock button
            unlockButton.SetActive(false);

            // Show Lock button
            lockButton.SetActive(true);

            // Make Equipment Button Inactive
            equipmentButton.interactable = false;
            ColorBlock cb = equipmentButton.colors;
            cb.normalColor = inactiveColor;
        }
    }
}
