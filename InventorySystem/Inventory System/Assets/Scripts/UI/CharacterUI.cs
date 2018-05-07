using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterUI : MonoBehaviour {

  public Text CUIHealthText;
  public Text CUIMoneyText;
  public Text CUIExpText;

  void Update()
  {
    UpdateText();
  }

  private void UpdateText()
  {
    CUIHealthText.text = CharacterBG.Instance.GetLife.ToString();
    CUIMoneyText.text = CharacterBG.Instance.GetMoney.ToString();
    CUIExpText.text = CharacterBG.Instance.GetExp.ToString();
  }

}
