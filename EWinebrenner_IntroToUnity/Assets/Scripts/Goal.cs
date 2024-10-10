using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public string nextScene;
    //Started to overlap
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered zone");
        SceneManager.LoadScene(nextScene);
    }
    //Stopped overlapping
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Left zone");
    }
    //Currently overlapping
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("In zone");
    }

    //Both bodies are NOT triggers. Just hit eachother
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
