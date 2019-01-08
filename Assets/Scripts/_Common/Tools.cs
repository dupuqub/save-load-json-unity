using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Tools : MonoBehaviour
{
  public static string GetFile(string address)
  {
    return File.ReadAllText(Application.streamingAssetsPath + address);
  }
}
