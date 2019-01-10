using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountTriggers : MonoBehaviour
{
  public void Erase(int index)
  {
    Debug.Log("Erase " + index);
  }

  public void Play(int index)
  {
    Debug.Log("Play " + index);
  }
}
