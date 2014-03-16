using UnityEngine;
using System.Collections;

public class ActionScript : MonoBehaviour {

	public Transform weeChat;
	public Transform bigChat;
	public TextMesh Hello;
	public Transform choice1;
	public Transform choice2;
	public Transform choice3;
	public TextMesh answer1;
	public TextMesh answer2;
	public TextMesh answer3;
	
	public AudioClip Bye;
	public AudioClip whatsYourName;
	public AudioClip imThinkinOnGoing;
	public AudioClip judoGeorge;
	public AudioClip thanksForyourHelp;
	public AudioClip whatsThat;
	public AudioClip willYouTakeMe;
	public AudioClip notBothered;
	public AudioClip giveMe;
	public AudioClip dontCare;
	public AudioClip outOfSchool;
	public AudioClip youScareMe;

	
	TextMesh option1;
	TextMesh option2;
	TextMesh option3;
	TextMesh question;
	
	string q1 = "Hello!";
	string q2 = "My name is \n Sammy!";
	string q3 = "Have you heard \n about the \n commonwealth games?";
	string q4 = "What would you \n like to see?";
	string q5 = "Tickets go on sale \n tommorrow!";
	
	string a1 = "What's your name?";
	string a2 = "I'm thinking about going!";
	string a3 = "I want to see Judo George!";
	string a4 = "Thanks for your help! \n See you later!";
	
	string b1 = "What's that?";
	string b2 = "Will you take me?";
	string b3 = "I'm not bothered \n what I see!";
	string b4 = "Bye...";
	
	string c1 = "Give me that!";
	string c2 = "I don't care!";
	string c3 = "As long as it gets \n me out of school!";
	string c4 = "You scare me! \n I'm outta here!";
	
	private float runtime = 0f;
	private bool go = false;
	
	
	// Use this for initialization
	void Start () {
		weeChat.renderer.enabled = false;
		bigChat.renderer.enabled = false;
		Hello.renderer.enabled = false;
		choice1.renderer.enabled = false;
		choice2.renderer.enabled = false;
		choice3.renderer.enabled = false;
		answer1.renderer.enabled = false;
		answer2.renderer.enabled = false;
		answer3.renderer.enabled = false;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if(go == true)
		{
			
			runtime += Time.deltaTime;
			if(runtime < 3f)
			{
				answer1.renderer.enabled = false;
				answer2.renderer.enabled = false;
				answer3.renderer.enabled = false;
				choice1.renderer.enabled = false;
				choice2.renderer.enabled = false;
				choice3.renderer.enabled = false;
			}
			else if(runtime>3f)
			{
				answer1.renderer.enabled = true;
				answer2.renderer.enabled = true;
				answer3.renderer.enabled = true;
				choice1.renderer.enabled = true;
				choice2.renderer.enabled = true;
				choice3.renderer.enabled = true;
				go = false;
			}
		}
	}

	void OnMouseDown()
	{
		TextMesh option1 = (TextMesh)answer1.GetComponent(typeof(TextMesh));
		TextMesh option2 = (TextMesh)answer2.GetComponent(typeof(TextMesh));
		TextMesh option3 = (TextMesh)answer3.GetComponent(typeof(TextMesh));
		TextMesh question = (TextMesh)Hello.GetComponent(typeof(TextMesh));
		
		if(gameObject.tag == "seagull")
		{			
			if(question.text.ToString () == q1)
			{
				runtime = 0;
				go = true;
				 
				weeChat.renderer.enabled = true;
				bigChat.renderer.enabled = true;
				Hello.renderer.enabled = true;
				answer1.renderer.enabled = true;
				answer2.renderer.enabled = true;
				answer3.renderer.enabled = true;
				choice1.renderer.enabled = true;
				choice2.renderer.enabled = true;
				choice3.renderer.enabled = true;
				option1.text = a1;
				option2.text = b1;
				option3.text = c1;
				
			}
			else if(question.text.ToString () == q2)
			{
				runtime = 0;
				go = true;
				question.text = q3;
				question.characterSize = 0.7f;
				
			}
		
			
			
		}
		 if((gameObject.tag == "choice1")&&(choice1.renderer.enabled == true))
			
		{			
				
			if(option1.text.ToString() == a1)
			{
				option1.text = a2;
				option2.text = b2;
				option3.text = c2;
				question.text = q2;
				
				answer1.renderer.enabled = false;
				answer2.renderer.enabled = false;
				answer3.renderer.enabled = false;
				choice1.renderer.enabled = false;
				choice2.renderer.enabled = false;
				choice3.renderer.enabled = false;
			}
			else if(option1.text.ToString() == a2)
			{
				runtime = 0;
				go = true;
				option1.text = a3;				
				option2.text = b3;				
				option3.text = c3;
				question.text = q4;
				question.characterSize = 1.0f;
				
				
				
			}
			else if(option1.text.ToString () == a3)
			{
				runtime = 0;
				go = true;
				option1.text = a4;
				option2.text = b4;
				option3.text = c4;
				question.text = q5;
				
			}
			
			
			
				
		
		}
		if(gameObject.tag == "choice2")
		{
		}
		if(gameObject.tag == "choice3")
		{
		}
			
		
		
	}
	
	void OnMouseEnter()
	{
		TextMesh option1 = (TextMesh)answer1.GetComponent(typeof(TextMesh));
		TextMesh option2 = (TextMesh)answer2.GetComponent(typeof(TextMesh));
		TextMesh option3 = (TextMesh)answer3.GetComponent(typeof(TextMesh));
		TextMesh question = (TextMesh)Hello.GetComponent(typeof(TextMesh));
		
		if((gameObject.tag == "answer1")&&(choice1.renderer.enabled == true))
		{
			if(option1.text.ToString() == a1)
			{
				AudioSource.PlayClipAtPoint(whatsYourName, Camera.main.transform.position);
			}
			else if(option1.text.ToString() == a2)
			{
				AudioSource.PlayClipAtPoint(imThinkinOnGoing, Camera.main.transform.position);
			}
			else if(option1.text.ToString() == a3)
			{
				AudioSource.PlayClipAtPoint(judoGeorge, Camera.main.transform.position);
			}
			else
			{
				AudioSource.PlayClipAtPoint(thanksForyourHelp, Camera.main.transform.position);
			}
		}
		
		else if((gameObject.tag == "answer2")&&(choice2.renderer.enabled == true))
			{
			if(option2.text.ToString() == b1)
			{
				AudioSource.PlayClipAtPoint(whatsThat, Camera.main.transform.position);
			}
			else if(option2.text.ToString() == b2)
			{
				AudioSource.PlayClipAtPoint(willYouTakeMe, Camera.main.transform.position);
			}
			else if(option2.text.ToString() == b3)
			{
				AudioSource.PlayClipAtPoint(notBothered, Camera.main.transform.position);
			}
			else
			{
				AudioSource.PlayClipAtPoint(Bye, Camera.main.transform.position);
			}
		}
		
		else if((gameObject.tag == "answer3")&&(choice3.renderer.enabled == true))
		{
			if(option3.text.ToString() == c1)
			{
				AudioSource.PlayClipAtPoint(giveMe, Camera.main.transform.position);
			}
			else if(option3.text.ToString() == c2)
			{
				AudioSource.PlayClipAtPoint(dontCare, Camera.main.transform.position);
			}
			else if(option3.text.ToString() == c3)
			{
				AudioSource.PlayClipAtPoint(outOfSchool, Camera.main.transform.position);
			}
			else
			{
				AudioSource.PlayClipAtPoint(youScareMe, Camera.main.transform.position);
			}
			
		}
		
	}
	

}