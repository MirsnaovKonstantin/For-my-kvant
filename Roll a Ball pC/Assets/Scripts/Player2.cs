using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class Player2: MonoBehaviour

{

[SerializeField] KeyCode keyOne;

[SerializeField] KeyCode keyTwo;

[SerializeField] Vector3 MoveVector;

private void FixedUpdate()

{

if (Input.GetKey(keyOne)) {GetComponent<Rigidbody>().velocity += MoveVector; }

if (Input.GetKey(keyTwo)) {GetComponent<Rigidbody>().velocity -= MoveVector; }


}

private void OnTriggerEnter(Collider other)

{

if(this.CompareTag("Player") && other.CompareTag("Finish"))

{

SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

}


}

}

