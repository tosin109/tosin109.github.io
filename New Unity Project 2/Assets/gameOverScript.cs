using UnityEngine; 
using UnityEngine.UI; 
using System.Collections; 
 

 public class gameOverScript : MonoBehaviour { 


 	void Start () { 
 		gameObject.GetComponent<Text>().enabled = false; 
 	} 
 	 
 	public void Lose () { 
 		gameObject.GetComponent<Text>().enabled = true; 
 	} 
} 
