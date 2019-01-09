using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSketch : MonoBehaviour
{
  protected Texture2D cursorIdle;
  protected Texture2D cursorClick;

  void Start()
  {
    //
  }

  void Update()
  {
    Tools.ChangeCursor(cursorIdle, cursorClick);
  }
}
