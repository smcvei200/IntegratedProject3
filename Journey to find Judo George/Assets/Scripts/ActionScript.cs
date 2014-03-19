using UnityEngine;
using System.Collections;

public class ActionScript : MonoBehaviour {
	
	public Transform splashScreen;
	public Transform weeChat;
	public Transform bigChat;
	public Transform choice1;
	public Transform choice2;
	public Transform choice3;
	public Transform SammyHappy;
	
	public TextMesh answer1;
	public TextMesh answer2;
	public TextMesh answer3;
	public TextMesh Hello;
	public TextMesh finish;
	
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

	string q1 = "Hello!";
	string q2 = "My name is \n Sammy!";
	string q3 = "Have you heard \n about the \n commonwealth games?";
	string q4 = "What would you \n like to see?";
	string q5 = "Tickets go on sale \n tommorrow!";
	string q6 = "No problem! \n Maybe I'll see you there!";
	string q7 = "Ok, see you later!";
	string q8 = "That's not very nice!";
	string q9 = "Don't be so rude!";
	string q10 = "School is important!";
	string q11 = "Your manners need improving!";
	
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
	
	string f1 = "Sammy really enjoyed \n his conversation \n with you!";
	string f2 = "You could have \n been a little more polite!";
	string f3 = "Don't think Sammy \n was very happy with you!";
	
	private float runtime = 0f;
	private bool go = false;
	private bool goodScore = false;
	private bool averageScore = false;
	private bool badScore = false;
	
	
	Color choiceColor = new Color(0,0,255, 0.7f);
	Color goodColor = new Color(0,250,0,0.4f);
	Color averageColor = new Color(255,128,0,0.4f);
	Color badColor = new Color(250,0,0,0.4f);
	
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
		finish.renderer.enabled = false;
		splashScreen.renderer.enabled = false;
		
		weeChat.renderer.material.color = choiceColor;
		bigChat.renderer.material.color = choiceColor;
		choice1.renderer.material.color = choiceColor;
		choice2.renderer.material.color = choiceColor;
		choice3.renderer.material.color = choiceColor;
		SammyHappy.renderer.material.color = goodColor;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if(goodScore == true)
		{
			SammyHappy.renderer.material.color = goodColor;
			SammyHappy.transform.localScale += new Vector3(0,1f,0);
			SammyHappy.transform.position = SammyHappy.transform.position + new Vector3(0,1,0);
			goodScore = false;
		}
		if(averageScore == true)
		{
			SammyHappy.renderer.material.color = averageColor;
			SammyHappy.transform.localScale += new Vector3(0,0.5f,0);
			SammyHappy.transform.position = SammyHappy.transform.position + new Vector3(0,0.5f,0);
			averageScore = false;
		}
		if(badScore == true)
		{
			SammyHappy.renderer.material.color = badColor;
			badScore = false;
		}
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
		TextMesh result = (TextMesh)finish.GetComponent (typeof(TextMesh));
		
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
			else if(question.text.ToString () == q6)
			{
				if(SammyHappy.transform.localScale.y >= 3)
				{
					
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f1;
				}
				else if((SammyHappy.transform.localScale.y>= 1)&&(SammyHappy.transform.localScale.y<3))
				{
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f2;
				}
				else if(SammyHappy.transform.localScale.y <1)
				{
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f3;
				}
			}
			else if(question.text.ToString () == q7)
			{
				if(SammyHappy.transform.localScale.y >= 3)
				{
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f1;
				}
				else if((SammyHappy.transform.localScale.y>= 1)&&(SammyHappy.transform.localScale.y<3))
				{
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f2;
				}
				else if(SammyHappy.transform.localScale.y <1)
				{
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f3;
				}
			}
			
			else if(question.text.ToString() == q8)
			{
				runtime = 0;
				go = true;
				question.text = q3;
				
			}
			
			else if(question.text.ToString() == q9)
			{
				runtime = 0;
				go = true;
				question.text = q4;
				
			}
			else if(question.text.ToString() == q10)
			{
				runtime = 0;
				go = true;
				question.text = q5;
				
			}
			else if(question.text.ToString () == q11)
			{
				
				if(SammyHappy.transform.localScale.y >= 3)
				{
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f1;
				}
				else if((SammyHappy.transform.localScale.y>= 1)&&(SammyHappy.transform.localScale.y<3))
				{
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f2;
				}
				else if(SammyHappy.transform.localScale.y <1)
				{
					splashScreen.renderer.enabled = true;
					finish.renderer.enabled = true;
					finish.text = f3;
				}
					
				
			}
		
		}
		 if((gameObject.tag == "choice1")&&(choice1.renderer.enabled == true))
			
		{			
				
			if(option1.text.ToString() == a1)
			{
				goodScore = true;
				SammyHappy.renderer.enabled = true;
				
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
				goodScore = true;
				
				runtime = 0;
				go = true;
				option1.text = a3;				
				option2.text = b3;				
				option3.text = c3;
				option3.characterSize = 0.8f;
				question.text = q4;
				question.characterSize = 1.0f;	
				
			}
			else if(option1.text.ToString () == a3)
			{
				goodScore = true;
				
				runtime = 0;
				go = true;
				option1.text = a4;
				option2.text = b4;
				option3.text = c4;
				question.text = q5;
				
			}	
			else if(option1.text.ToString () == a4)
			{
				goodScore = true;
				
				question.text = q6;
				question.characterSize = 0.8f;
				answer1.renderer.enabled = false;
				answer2.renderer.enabled = false;
				answer3.renderer.enabled = false;
				choice1.renderer.enabled = false;
				choice2.renderer.enabled = false;
				choice3.renderer.enabled = false;
			}
		
		}
		if((gameObject.tag == "choice2")&&(choice2.renderer.enabled == true))
		{
			if(option2.text.ToString() == b1)
			{
				averageScore = true;
				SammyHappy.renderer.enabled = true;
				
				runtime = 0;
				go = true;
				
				option1.text = a2;
				option2.text = b2;
				option3.text = c2;
				question.text = q3;
				
			}
			else if(option2.text.ToString() == b2)
			{
				averageScore = true;
				
				runtime = 0;
				go = true;
				option1.text = a3;				
				option2.text = b3;				
				option3.text = c3;
				option3.characterSize = 0.8f;
				question.text = q4;
				question.characterSize = 1.0f;	
				
			}
			else if(option2.text.ToString () == b3)
			{
				averageScore = true;
				
				runtime = 0;
				go = true;
				option1.text = a4;
				option2.text = b4;
				option3.text = c4;
				question.text = q5;
				
			}	
			else if(option2.text.ToString () == b4)
			{
				averageScore = true;
				
				question.text = q7;
				question.characterSize = 0.8f;
				answer1.renderer.enabled = false;
				answer2.renderer.enabled = false;
				answer3.renderer.enabled = false;
				choice1.renderer.enabled = false;
				choice2.renderer.enabled = false;
				choice3.renderer.enabled = false;
			}
		}
		if((gameObject.tag == "choice3")&&(choice3.renderer.enabled == true))
		{
			if(option3.text.ToString() == c1)
			{
				badScore = true;
				SammyHappy.renderer.enabled = true;
				
				option1.text = a2;
				option2.text = b2;
				option3.text = c2;
				question.text = q8;
				
				answer1.renderer.enabled = false;
				answer2.renderer.enabled = false;
				answer3.renderer.enabled = false;
				choice1.renderer.enabled = false;
				choice2.renderer.enabled = false;
				choice3.renderer.enabled = false;
				
			}
			else if(option3.text.ToString() == c2)
			{
				badScore = true;
				
				option1.text = a3;				
				option2.text = b3;				
				option3.text = c3;
				option3.characterSize = 0.8f;
				question.text = q9;
				question.characterSize = 1.0f;	
				
				answer1.renderer.enabled = false;
				answer2.renderer.enabled = false;
				answer3.renderer.enabled = false;
				choice1.renderer.enabled = false;
				choice2.renderer.enabled = false;
				choice3.renderer.enabled = false;
				
			}
			else if(option3.text.ToString () == c3)
			{
				badScore = true;
				
				option1.text = a4;
				option2.text = b4;
				option3.text = c4;
				question.text = q10;
				
				answer1.renderer.enabled = false;
				answer2.renderer.enabled = false;
				answer3.renderer.enabled = false;
				choice1.renderer.enabled = false;
				choice2.renderer.enabled = false;
				choice3.renderer.enabled = false;
				
			}	
			else if(option3.text.ToString () == c4)
			{
				badScore = true;
				
				question.text = q11;
				question.characterSize = 0.8f;
				answer1.renderer.enabled = false;
				answer2.renderer.enabled = false;
				answer3.renderer.enabled = false;
				choice1.renderer.enabled = false;
				choice2.renderer.enabled = false;
				choice3.renderer.enabled = false;
			}
		}
			
		
		
	}
	
	void OnMouseEnter()
	{
		TextMesh option1 = (TextMesh)answer1.GetComponent(typeof(TextMesh));
		TextMesh option2 = (TextMesh)answer2.GetComponent(typeof(TextMesh));
		TextMesh option3 = (TextMesh)answer3.GetComponent(typeof(TextMesh));
		TextMesh question = (TextMesh)Hello.GetComponent(typeof(TextMesh));
		
		if((gameObject.tag == "answer1")&&(choice1.renderer.enabled == true)&&(!GameObject.Find("One shot audio")))
		{
			renderer.material.color = Color.red;
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
		
		else if((gameObject.tag == "answer2")&&(choice2.renderer.enabled == true)&&(!GameObject.Find("One shot audio")))
			{
			renderer.material.color = Color.red;
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
		
		else if((gameObject.tag == "answer3")&&(choice3.renderer.enabled == true)&&(!GameObject.Find("One shot audio")))
		{
			renderer.material.color = Color.red;
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
	
	void OnMouseExit()
	{
		if((gameObject.tag == "answer1")&&(choice1.renderer.enabled == true))
		{
			renderer.material.color = Color.yellow;
		}
		else if((gameObject.tag == "answer2")&&(choice1.renderer.enabled == true))
		{
			renderer.material.color = Color.yellow;
		}
		else if((gameObject.tag == "answer3")&&(choice1.renderer.enabled == true))
		{
			renderer.material.color = Color.yellow;
		}
		
	}

}