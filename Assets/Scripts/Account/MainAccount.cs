using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAccount : MonoBehaviour
{
  //....................................................................................................................
  // Instances.

  UpdateLang _UpdateLang = new UpdateLang();

  //....................................................................................................................

  void Start()
  {
    _UpdateLang.Account();
  }

  void Update()
  {
    //
  }
}
