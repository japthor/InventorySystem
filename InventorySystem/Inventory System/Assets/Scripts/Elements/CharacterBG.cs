using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBG : MonoBehaviour {

  // Basics from the character
  private int CLife;
  private int CExp;
  private int CMoney;

  #region Singleton
  public static CharacterBG Instance;

  private void Awake()
  {
    if (Instance == null)
      Instance = this;
    else
      return;
  }
  #endregion

  void Start()
  {
    CLife = 100;
    CExp = 0;
    CMoney = 0;
  }

  public int GetLife
  {
    get { return CLife; }
    set { CLife = value; }
  }

  public int GetExp
  {
    get { return CExp; }
    set { CExp = value; }
  }

  public int GetMoney
  {
    get { return CMoney; }
    set { CMoney = value; }
  }
}
