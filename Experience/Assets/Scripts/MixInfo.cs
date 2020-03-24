﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MixInfo
{
    public int itemID;   // 아이템 번호(완성품) 조합템 1,2,3으로 만듬.
    public int itemID_1; // 조합 아이템 번호 1
    public int itemID_2; // 조합 아이템 번호 2
    public int itemID_3; // 조합 아이템 번호 3
    
    public MixInfo(int _itemID, int _itemID_1, int _itemID_2, int _itemID_3) // ItemInfo 클래스에 대한 생성자
    {
        itemID = _itemID;
        itemID_1 = _itemID_1;
        itemID_2 = _itemID_2;
        itemID_3 = _itemID_3;
    }
}
