using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour {

  public Item ItemReference;

  // Adds selected item from the objects menu
  public void OnClickItem()
  {
    Inventory.Instance.AddItem(ItemReference);
  }

}
