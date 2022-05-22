using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player2 : MonoBehaviour
{
bool ButtonLeftDown;
bool ButtonRightDown;
[SerializeField]Vector3 MoveVector;


public void MoveLeftDown(){ButtonLeftDown=true; }
public void MoveLeftUp() {ButtonLeftDown=false; }   
public void MoveRightDown() {ButtonRightDown=true; }
public void MoveRightUp() {ButtonRightDown=false; }

private void FixedUpdate()
{
    if(ButtonLeftDown==true) {GetComponent<Rigidbody>().velocity-= MoveVector;}
    if(ButtonRightDown==true) {GetComponent<Rigidbody>().velocity+= MoveVector;}
}

    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player")&& other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}