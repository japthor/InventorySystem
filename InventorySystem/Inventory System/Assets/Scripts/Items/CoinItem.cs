using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Coin", menuName = "Inventory/Coin")]
public class CoinItem : Item
{
  public int coins;
  public override void UseItem()
  {
    CharacterBG.Instance.GetMoney += coins;
  }
}
