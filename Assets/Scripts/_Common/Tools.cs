using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tools : MonoBehaviour
{
  protected CursorMode cursorMode;

  public void PlayParticleSystem(ParticleSystem particles)
  {
    particles.Play();
  }

  public void AudioSourceOnOff(AudioSource audioSource)
	{
    // O AudioSource é o bagulho que toca audio na Scene. Só pode ter um por Scene. Sem ele não tem audio.
		if(audioSource.volume == 1f)
		{
			audioSource.volume = 0f;
		}
		else
		{
			audioSource.volume = 1f;
		}
	}

  public void PlaySoundFX(AudioSource audioSource, AudioClip audioClip)
  {
    audioSource.PlayOneShot(audioClip);
  }

  public void ChangeScene(int index)
  {
		SceneManager.LoadScene(index);
  }

  public void ChangeCursor(Texture2D cursorIdle, Texture2D cursorClick)
  {

    if(Input.GetMouseButton(0))
    {
      Cursor.SetCursor(cursorClick, Vector2.zero, cursorMode);
    }
    else
    {
      Cursor.SetCursor(cursorIdle, Vector2.zero, cursorMode);
    }
  }

  public static string GetFile(string address)
  {
    return File.ReadAllText(Application.streamingAssetsPath + address);
  }
}
