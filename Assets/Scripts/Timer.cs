using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
  public GameObject textDisplay;
  public int seconds = 30;
  public bool minusSeconds = false;

  void Start() {
    //Show time
    if (seconds < 10) {
      textDisplay.GetComponent<TextMeshProUGUI>().text = "00:0" + seconds;
    }

    else {
      textDisplay.GetComponent<TextMeshProUGUI>().text = "00:" + seconds;
    }
  }

  void Update() {
    //Coroutine only starts if seconds > 0
    if (minusSeconds = false && seconds > 0) {
      StartCoroutine(ReduceSeconds);
    }
  }

  //Start Coroutine
  IEnumerator ReduceSeconds() {
    //Start reducing seconds
    minusSeconds = true;

    //Reduce by 1 second
    yield return new WaitForSeconds(1);

    seconds -= 1;

    //Show new time
    if (seconds < 10) {
      textDisplay.GetComponent<TextMeshProUGUI>().text = "00:0" + seconds;
    }

    else {
      textDisplay.GetComponent<TextMeshProUGUI>().text = "00:" + seconds;
    }

    //Finished reducing time
    minusSeconds = false;
  }
}
