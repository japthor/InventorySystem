using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New HealthPotion", menuName = "Inventory/HealthPotion")]
public class HealthPotionItem : Item
{
  public int health;

  public override void UseItem()
  {
    CharacterBG.Instance.GetLife += health;
  }
}
