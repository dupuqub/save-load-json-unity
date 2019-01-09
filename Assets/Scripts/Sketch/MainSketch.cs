using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSketch : MonoBehaviour
{
  //....................................................................................................................
  // Instances.

  Tools _Tools = new Tools();

  //....................................................................................................................

  protected Texture2D cursorIdle;
  protected Texture2D cursorClick;

  void Start()
  {
    //
  }

  void Update()
  {
    _Tools.ChangeCursor(cursorIdle, cursorClick);
  }
}
