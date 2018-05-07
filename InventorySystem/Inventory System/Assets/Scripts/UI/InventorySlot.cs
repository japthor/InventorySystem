using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {
  // Item
  Item ISItem;
  // Icon
  public Image ISIcon;
  // Remove button 
  public Button ISRemoveButton;

  // Adds item (UI Inventory Version)
  public void AddItem(Item newItem)
  {
    ISItem = newItem;
    ISIcon.sprite = ISItem.IIcon;
    ISIcon.enabled = true;
    ISRemoveButton.interactable = true;
  }
  // Remove item (UI Inventory Version)
  public void ClearSlot()
  {
    ISItem = null;
    ISIcon.sprite = null;
    ISIcon.enabled = false;
    ISRemoveButton.interactable = false;
  }
  // Remove item (Inventory version)
  public void OnRemoveButton()
  {
    Inventory.Instance.RemoveItem(int.Parse(this.gameObject.name));
  }

  // Use item and removes it
  public void UseItem()
  {
    if (ISItem != null)
    {
      ISItem.UseItem();
      OnRemoveButton();
    }
  }
}
