using UnityEngine;

public class InventoryUI : MonoBehaviour {

  // Reference to the panel father of all the inventory  slots
  public Transform IUIItemsParent;
  // Reference to the inventory panel
  public GameObject IUIInventoryUI;
  //Reference to Inventory script
  Inventory IUIInventory;
  //Reference to Inventory slots script
  InventorySlot[] IUISlots;

	// Use this for initialization
	void Start ()
  {
    IUIInventory = Inventory.Instance;
    IUISlots = IUIItemsParent.GetComponentsInChildren<InventorySlot>();

    //Call UpdateUI when the delegate has benn activacted.
    IUIInventory.InventoryModificationCallBack += UpdateUI;
  }
	
	// Update is called once per frame
	void Update ()
  {
    // Toggles between visualize inventory or not.
    if (Input.GetButtonDown("Inventory"))
      IUIInventoryUI.SetActive(!IUIInventoryUI.activeSelf);
  }

  // Add or discard item from the InventorySlots
  void UpdateUI()
  {
    for (int i = 0; i< IUISlots.Length; i++)
    {
      if (i < IUIInventory.IListItem.Count)
        IUISlots[i].AddItem(IUIInventory.IListItem[i]);
      else
        IUISlots[i].ClearSlot();
    }
  }
}
