using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import this to use the Button class

public class StageLoader : MonoBehaviour
{
    private BoardManager go;
    public string stageName;
    public Camera cam;
    public float camPosX = 4f; // Default position change for the camera on X-axis
    public float camPosY = -4.5f; // Default position change for the camera on Y-axis
    public Button restartButton; // Make sure to use the correct 'Button' type

    // Start is called before the first frame update
    void Start()
    {
        go = GetComponent<BoardManager>();
        go.LoadStage(stageName);
        cam = FindObjectOfType<Camera>();  // Finds the first active Camera in the scene

 // Check if the camera component exists
        if (cam != null)
        {
            // Move the camera to the initial position
            RepositionCamera();
        }
        else
        {
            Debug.LogError("Camera component not found on the GameObject.");
        }

        // Add the listener to the restart button
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(OnRestartButtonPressed);
        }
        else
        {
            Debug.LogError("Restart button is not assigned.");
        }
    }

    // Method to reposition the camera
    public void RepositionCamera()
    {
        if (cam != null)
        {
            cam.transform.position = new Vector3(camPosX, camPosY, -1);
        }
    }

    // Method to handle restart button press
    public void OnRestartButtonPressed()
    {
        RepositionCamera(); // Reposition the camera when the restart button is pressed
    }

    // Update is called once per frame
    public void Update()
    {
        // Your update logic, if any
    }
}
