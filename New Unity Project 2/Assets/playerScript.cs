using UnityEngine; 
using System.Collections; 


public class playerScript : MonoBehaviour { 
 

 	public GameObject Score; 
 	private Rigidbody2D rb2D; 
 	private float jumpForce = 10.0f; 
 	//GameOverのGUITextを指定 
 	public GameObject GameOverGUI; 
 	//gameoverフラグ 
 	private bool gameover = false; 
 	//Animator変数 
 	private Animator anim; 
 

 	void Start () { 
 		rb2D = GetComponent<Rigidbody2D>(); 
 		//AnimatorをGetComponentしておく 
 		anim = GetComponent( "Animator" ) as Animator; 
 	} 
 

 	void Update () { 
 		//gameoverフラグがtrueになった時、ジャンプできないようにする 
 		if(Input.GetMouseButtonDown(0) && !gameover){ 
 			Jump(); 
 		} 
 		if(gameover == true){ 
 			//アニメーションの切替 
 			anim.SetBool("gameover", true ); 
 			//GAME OVERのGUIを表示する 
 			GameOverGUI.SendMessage("Lose"); 
 		} 
 	} 
 

 	void Jump(){ 
 		rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce); 
 	} 
 	 
 	// トリガーに入った時に score を加算します。 
 	void OnTriggerEnter2D (Collider2D col){ 
 			Score.SendMessage ("ScoreUp", 1); 
 		Destroy (col.gameObject); 
 	} 
 	 
 	//Trigger以外の何か障害物に当たった置き、GameOverメソッドを実行 
 	void OnCollisionEnter2D(Collision2D col) { 
 		StartCoroutine(GameOver()); 
 	} 
 	 
 	IEnumerator GameOver() { 
 		// ゲームオーバーのフラグをtrueにする 
 		gameover = true; 
 		// マウス連打してたらスコアを見る暇もなくタイトルへ戻ってしまう対策 1秒待機 
 		yield return new WaitForSeconds(1f); 
 		// マウスクリックしたらゲームの最初に戻る 
 		//while(!Input.GetMouseButtonDown(0)) { yield return 0; } 
 		Application.LoadLevel("title"); 
 	} 
 } 
