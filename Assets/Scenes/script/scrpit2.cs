using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scrpit2 : MonoBehaviour
{
    public int currentlevel;
    public int nextlevel;
    


    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
            SceneManager.LoadScene(nextlevel);

        if (collision.gameObject.CompareTag("Respawn"))
            SceneManager.LoadScene(currentlevel);
    }



}

