using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Notebook : MonoBehaviour
{
    //how to add entries to the book
    //notebookScript.AddEntry("Found a mysterious note in the drawer.");
    //notebookScript.AddEntry("Received a call from an unknown number.");
    public GameObject notebookUI;
    public TMP_Text notebookText;     // Reference to the Text component for displaying entries

    private List<string> entries = new List<string>(); // List to store notebook entries

    private bool isNotebookOpen = false;

    private void Start()
    {
        ToggleNotebookUI(false); // Start with the notebook UI hidden
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)) // Toggle the notebook with the 'N' key (you can change this key)
        {
            ToggleNotebook();
        }
    }

    public void ToggleNotebook()
    {
        isNotebookOpen = !isNotebookOpen;
        ToggleNotebookUI(isNotebookOpen);
    }

    private void ToggleNotebookUI(bool isOpen)
    {
        notebookUI.SetActive(isOpen);

        if (isOpen)
        {
            UpdateNotebookText();
        }
    }

    public void AddEntry(string entry)
    {
        entries.Add(entry);
        UpdateNotebookText();
    }

    private void UpdateNotebookText()
    {
        notebookText.text = string.Join("\n\n", entries);
    }

}
