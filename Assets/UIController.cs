using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public EventSystem LevelEventSystem;

    // Amount of time until game over
    public float timeRemaining = 50f;

    // The Timer
    public Text timer;

    // The Timer as a slider
    public Slider timerVisualised;

    // The Reset Button
    public Button resetButton;

    // Scene Manager
    public GameObject SceneManager;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        // Check for user click
        if (Input.GetMouseButtonDown(0))
        {
            // Is it on a button?
            if (LevelEventSystem.IsPointerOverGameObject()) {
                Debug.Log("Over Button");
            }
            else
            {
                // Setup the ray based on mouse locale
                Ray mousePos = Camera.main.ScreenPointToRay(Input.mousePosition);

                // Perform raycast to determine click
                RaycastHit hitResults;
                if (Physics.Raycast(mousePos, out hitResults))
                {
                    // retrieve the game object that hit
                    GameObject hitObject = hitResults.collider.gameObject;

                    cube cube = hitObject.GetComponent<cube>();
                    if (cube != null)
                    {
                        cube.ReactToMouseClick();
                    }
                    else
                    {
                        cube = hitObject.GetComponentInParent<cube>();

                        if (cube != null)
                        {
                            cube.ReactToMouseClick();
                        }
                    }
                }
            }
        }

        // Counts down the timer 
        timeRemaining -= Time.deltaTime;

        // Tells the user what the time remaining is, in both text and as a slider
        timer.text = "Time Remaining:" + Mathf.Round(timeRemaining);
        timerVisualised.value = (timeRemaining);

        // Outputs "Game Over" into the console upon reaching 0
        // TODO: Change this to be a proper game over state
        if (timeRemaining < 0)
        {
            timeRemaining = 0;
            Debug.Log("Game Over");
        }
    }
}
