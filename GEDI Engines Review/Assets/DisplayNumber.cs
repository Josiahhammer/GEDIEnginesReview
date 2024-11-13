using UnityEngine;
using UnityEngine.UI;
using DLLReader; // Use the namespace from your DLL
using TMPro;

public class DisplayNumber : MonoBehaviour
{
    public TextMeshProUGUI uiText; // Reference to the Text UI element
    public string filePath = "number.txt"; // Path to the text file (relative to Application.dataPath)

    void Start()
    {
        // Combine the file path with the Unity data path
        string fullPath = System.IO.Path.Combine(Application.dataPath, filePath);

        try
        {
            // Call the DLL method to read the number from the file
            int number = Program.ReadNumberFromFile(fullPath);

            // Display the number on the Text UI element
            uiText.text = "Number from file: " + number.ToString();
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Failed to read number from file: " + ex.Message);
            uiText.text = "Error reading file";
        }
    }
}
