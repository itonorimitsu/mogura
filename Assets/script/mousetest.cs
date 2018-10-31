using UnityEngine;
using UnityEngine.EventSystems;

public class mousetest : MonoBehaviour
{
//	[SerializeField]
//	private GameObject  m_object = null;
	GameObject score;

	private void Update()
	{
//		Vector3 mousePos = Input.mousePosition; 
//		mousePos.z = 10.0f; 
//		Vector3 objPos = Camera.main.ScreenToWorldPoint( mousePos ); 
//		Debug.Log (objPos);
	}

//	public void OnSortiePointClick(BaseEventData data){
//		var eventData = (PointerEventData)data;
//		Debug.Log ("clicked");
//	}

	public void OnClicked(){
		// Debug.Log ("クリックされた");
		Invoke ("hit", 0.0f);//ここで待ってるのはマテリアル変更を見せるのと、待つため。
		score = GameObject.Find ("player1_point"); //ここでマテリアルを変更させる
		point_holder p1 = score.GetComponent<point_holder>();
		p1.attack_success ();
	}

	void hit(){
		updown ud = GetComponent<updown>();
		ud.down ();
		var eventSystem = GameObject.FindObjectOfType<EventSystem> ();
		eventSystem.enabled = false;
	}
}