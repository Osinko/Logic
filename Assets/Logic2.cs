using UnityEngine;
using System.Collections;

public class Logic2 : MonoBehaviour
{
		//C＃のAND　　A ∧ B　などの論理式が「条件付き理論積」である事を確認する
		//checkをtrueにするとAという条件を満たしたので”Bが実行され評価される”
		//しかしfalseの場合、条件は満たされていないので、Bの実行すらオミットされ、Bが評価されることすら無い
		
		public bool check;

		void Start ()
		{
				if (check && Execute ()) {
						print ("!");
				}
		}

		bool Execute ()
		{
				print ("Exec");
				return true;
		}
}

