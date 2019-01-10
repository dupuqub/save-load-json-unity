using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AccountTriggers : MonoBehaviour
{
  public void Erase(int index)
  {
    Debug.Log("Erase " + index);
  }

  public void Play(int index)
  {
    GameObject selector = GameObject.Find("AccountSelector" + index);
    GameObject input = selector.transform.GetChild(5).gameObject;
    InputField field = input.GetComponent<InputField>();
    Text placeholder = field.placeholder.GetComponent<Text>();

    Debug.Log("Play " + index + ": " + field.text);
    Debug.Log("Placeholder " + index + ": " + placeholder.text);
  }
}
