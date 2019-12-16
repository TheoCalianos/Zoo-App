using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu_Pannel : MonoBehaviour
{
  public Map_Pannel Map_Pannel;
  public void ProcessInfo()
  {
    Map_Pannel.gameObject.SetActive(true);
  }
}
