using System; // Type
using System.Reflection; // PropertyInfo
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpdateLang : MonoBehaviour
{
  public void Everything()
  {
    // get account
    // get scene
    // get lang (scene and common)

    Header();
  }

  public void Header()
  {
    Text BST = GameObject.Find("ButtonSettingsText").GetComponent<Text>();
    Text BET = GameObject.Find("ButtonExitText").GetComponent<Text>();

    BST.text = "???";
    BET.text = "!!!";
  }
}
