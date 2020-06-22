using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemGenerator : MonoBehaviour {


	public GameObject carPrefab;

	public GameObject coinPrefab;

	public GameObject conePrefab;

    // スタート地点
	private int startPos = -160;

	// ゴール地点
	private int goalPos = 120;

	// アイテムを出すx方向の範囲
	private float posRange = 3.4f;




	// 以下、課題用
	//private GameObject mainCamera;

	//private GameObject coin;
	//private GameObject cone;
	//private GameObject car;

	//private List<GameObject> coneList ;
	//private List<GameObject> coinList;
	//private List<GameObject> carList ;

	// private bool iscarToDestroy = false;
	// private bool isconeToDestroy = false;
	// private bool iscoinToDestroy = false;
	


	//private GameObject [] cones;
	//private GameObject []coins;
	//private GameObject [] cars;

	//private GameObject[] conesToDestroy;
	//private GameObject[] coinsToDestory;
	//private GameObject[] carsToDestory;







	// Use this for initialization
	void Start () {

		// メインカメラのオブジェクトを取得
		//this.mainCamera = GameObject.Find("Main Camera");
		//this.mainCamera = Camera.main.gameObject;

		for (int i = startPos; i < goalPos; i += 15)
        {
			int num = Random.Range(1, 11);

			if (num <= 2)
            {
				for (float j = -1; j < 1; j += 0.4f)
                {
					//コーンを、x軸方向に一直線に生成
					GameObject cone = Instantiate(conePrefab) as GameObject;
					cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
					
				}

			} else
            {

				// レーンごとにアイテムを生成
				for (int j = -1; j <= 1; j++)
                {
					// アイテムの種類を決める
					int item = Random.Range(1, 11);

					// アイテムをおくZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-5, 6);

					// 60%コイン配置、30%クルマ配置、10%何もなし
					if ( 1 <= item && item <= 6)
                    {
						GameObject coin = Instantiate(coinPrefab) as GameObject;
						

						coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    } else if ( 7 <= item && item <= 9)
                    {
						GameObject car = Instantiate(carPrefab) as GameObject;
						car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);


                    }


                }
            }
        }
		
	}




	
	// Update is called once per frame
	void Update () {

		

		

		//GameObject[] cones = GameObject.FindGameObjectsWithTag("TrafficConeTag");
		//GameObject[] coins = GameObject.FindGameObjectsWithTag("CoinTag");
		//GameObject[] cars = GameObject.FindGameObjectsWithTag("CarTag");



	}

	


	//private GameObject [] toDestoryInvisibleObjest() {
    

	//private void OnBecameInvisible()
    



}
