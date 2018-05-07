using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PoisonPotion", menuName = "Inventory/PoisonPotion")]
public class PoisonPotionItem : Item
{
  public int health;

  public override void UseItem()
  {
    CharacterBG.Instance.GetLife += health;
  }
}
