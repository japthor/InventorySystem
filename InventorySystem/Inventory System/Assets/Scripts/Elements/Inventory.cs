using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

  // Delegate when an event occurs (modifcation of inventory)
  public delegate void InventoryModification();
  public InventoryModification InventoryModificationCallBack;

  // List of all the items in the inventory
  public List<Item> IListItem;
  public int ISpace;

  #region Singleton
  public static Inventory Instance;

  private void Awake()
  {
    if (Instance == null)
      Instance = this;
    else
      return;
  }
  #endregion

  // Use this for initialization
  void Start ()
  {
    IListItem = new List<Item>();
  }
	
  // Adds item
  public void AddItem(Item item)
  {
    if (IListItem.Count < ISpace)
    {
      IListItem.Add(item);
      InventoryModificationCallBack.Invoke();
    }
  }
  // Remove item
  public void RemoveItem(int position)
  {
    IListItem.RemoveAt(position);
    InventoryModificationCallBack.Invoke();
  }
}
