using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SketchMain : MonoBehaviour
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
