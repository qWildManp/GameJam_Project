using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update


        void Start()
        {
            LoadLevel();
        }

        private void LoadLevel()
        {
            //�ϴ��˳���Ϸʱ�������Ϸ�ؿ�ID�������һ�ν���Ĭ��Ϊ1
            int levelId = PlayerPrefs.GetInt("level", 1);
            for (int i = 0; i < transform.childCount; i++)
            {
                if (i + 1 > levelId)
                {
                    //ûͨ�صĹؿ�
                    transform.GetChild(i).GetComponent<LevelItem>().Init(i + 1, true);
                }
                else
                {
                    //ͨ�صĹؿ�
                    transform.GetChild(i).GetComponent<LevelItem>().Init(i + 1, false);
                }
            }
        }

}
