using UnityEngine;

public class Serials : MonoBehaviour
{
  [System.Serializable]
  public class Sources_Common : System.Object
  {
    public int account;
    public string scene;
    public string lang;
  }

  [System.Serializable]
  public class LangsHeader : System.Object
  {
    public string settings;
    public string exit;
  }
}
