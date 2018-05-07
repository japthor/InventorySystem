using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

  public string IName = "Empty";
  public Sprite IIcon = null;
  public virtual void UseItem(){}
}
