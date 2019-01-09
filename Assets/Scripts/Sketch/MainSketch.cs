using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSketch : MonoBehaviour
{
  //Instantiate the script
  Tools tools = new Tools();
  //----------------------
  
  protected Texture2D cursorIdle;
  protected Texture2D cursorClick;

  void Start()
  {
    //
  }

  void Update()
  {
    tools.ChangeCursor(cursorIdle, cursorClick);
  }
}
