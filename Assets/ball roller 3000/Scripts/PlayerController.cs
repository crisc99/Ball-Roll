using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

// Cristian Cruz Rodriguez
// Controller
public class PlayerController : MonoBehaviour {
	public int index;
	public string LevelName;
	public float speed;
	public Text countText;
	public Text winText;
	private Rigidbody rb;
	private int count;
private int score;
public Text scoreText;
	void Start ()
	{
		rb = GetComponent<Rigidbody>();

		count = 0;
		score = 0;

		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);

			count = count + 1;
			SetCountText ();
			
		}

		 else if (other.gameObject.CompareTag("Enemy"))
         {
             other.gameObject.SetActive(false);
              count = count - 1;
			  SetCountText();
			  
         }

		 if (other.gameObject.CompareTag("Player"))
		 {
			SceneManager.LoadScene("level 2");

		 }
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();

		if (count >= 12) 
		{
			winText.text = "You Win!";
		}
	}
	public void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) {
        Application.Quit();
    }
	}

	}

		
	
