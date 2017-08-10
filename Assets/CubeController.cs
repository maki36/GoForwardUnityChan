using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;
	//private float groundLevel = -3.0f;


	// Use this for initialization
	void Start(){
	}
		
	void OnCollisonEnter2D(Collision2D other){
		Debug.Log (other.gameObject.tag);

		if (gameObject.tag == "Cube") {
			GetComponent<AudioSource>().Play();

			//audio.Play();
			//GetComponent<AudioSource> ();
		}
		//if (other.gameObject.tag == "Ground") {
		//	GetComponent<AudioSource>();

			//audio.Play();
			//GetComponent<AudioSource> ();
		//}
		//if (other.gameObject.tag != "Unitytyan") {
		//	GetComponent<AudioSource> ().volume = 0;
		//}
		//if (other.gameObject.tag != "Ground") {
		//	GetComponent<AudioSource> ().volume = 0;
		//}
	}


	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}
	}
}
