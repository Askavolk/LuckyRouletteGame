using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelScript : MonoBehaviour {

    private int randomValue;
    private float timeInterval;
    private bool coroutineAllowed;
    private int finalAngle;
   
    //This allows us to take the UI TEXT
    [SerializeField]
    private Text winText;


	// Start coroutine
	private void Start () {
        coroutineAllowed = true;

	}
	
	// if touch start Spin()
	private void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && coroutineAllowed)
            StartCoroutine(Spin());
	}

    // Function Spin()
    private IEnumerator Spin()
    {
        coroutineAllowed = false;
        randomValue = Random.Range(20, 30);
        timeInterval = 0.1f;

        for (int i = 0; i < randomValue; i++)
        {
            transform.Rotate(0, 0, 22.5f);
            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 0.2f;
            if (i > Mathf.RoundToInt(randomValue * 0.85f))
                timeInterval = 0.4f;
            yield return new WaitForSeconds(timeInterval);



        }

        if (Mathf.RoundToInt(transform.eulerAngles.z) % 45 != 0)
            transform.Rotate(0, 0, 22.5f);

        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);
        //This allows us to take the right angle and says whitch value gaves to us
        switch (finalAngle)
        {
            case 0:
                winText.text = "You win 2";
                break;
            case 75:
                winText.text = "You win 2";
                break;
            case 90:
                winText.text = "You win 3";
                break;
            case 120:
                winText.text = "You win 4";
                break;
            case 180:
                winText.text = "You win 5";
                break;
            case 225:
                winText.text = "You win 5";
                break;
            case 270:
                winText.text = "You win 6";
                break;
            case 315:
                winText.text = "You win 1";
                break;
            case 360:
                 winText.text = "You win 1";
                break;

        }

        coroutineAllowed = true;
    }



}
