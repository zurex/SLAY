﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XGame
{
    //通用
    public class UpdateGoldEvent
    {
        public float AnimDur = 0;
        public int BeginValue;
    }
 
 
    public class NewDayEvent { }
    public class ChangeFragmentsEvent { }
  


    public class GuideEndEvent
    {
        public GuideType GuideType;
        public bool IsClickGuideArea;
    }

    public class SetFlyTargetEvent { }
}
