using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonOptions : MonoBehaviour {

	public GameObject MinDisplay;
	public GameObject SecDisplay;
	public GameObject MilliDisplay;
	public static int MinCount;
	public static int SecCount;
	public static float MilliCount;

	public void PlayGame () {
		SceneManager.LoadScene (2);
	}

	public void TrackSelect () {
		SceneManager.LoadScene (1);
	}

	public void MainMenu () {
		SceneManager.LoadScene (0);
	}

	//Below here are track selection buttons

	public void Track01 () {
		SceneManager.LoadScene (2);
	}

	public void Track02 () {
		SceneManager.LoadScene (3);
	}
		
	public void Reload01(){
		TimerRe ();

	}

	public void TimerRe(){
		Scene scene=SceneManager.GetActiveScene ();
		SceneManager.LoadScene (scene.name);
		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.RawTime = 0;

	}

}
