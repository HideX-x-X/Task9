using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dethzone : MonoBehaviour
{
    private int score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        if (score >= 5)
        {

            SceneManager.LoadScene(0);
            Debug.Log("Good WORK! Level finished");
        }


            score++;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
