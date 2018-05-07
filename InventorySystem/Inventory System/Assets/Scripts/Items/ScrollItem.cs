using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Scroll", menuName = "Inventory/Scroll")]
public class ScrollItem : Item
{
  public int exp;
  public override void UseItem()
  {
    CharacterBG.Instance.GetExp += exp;
  }
}
