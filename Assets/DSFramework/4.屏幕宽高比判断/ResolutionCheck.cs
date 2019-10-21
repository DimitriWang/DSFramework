// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             NewBehaviourScript.cs
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):          2019/10/18 17:46:21
// 邮箱(Emial):					  1067163632@qq.com
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace DSFramework
{

    public class ResolutionCheck
    {
#if UNITY_EDITOR
        [MenuItem("DSFramework/4.屏幕宽高比判断",false,4)]
#endif
        static void MenuClicked()
        {

            Debug.Log(IsPadResolution() ? "是 Pad 宽高比" : "不是 Pad 宽高比");
            Debug.Log(IsiPhoneResolution() ? "是 Phone 宽高比" : "不是 Phone 宽高比");
            Debug.Log(IsPhone15Resolution() ? "是 4s 宽高比" : "不是 4s 宽高比");
            Debug.Log(IsPhoneXResolution() ? "是 iPhoneX 宽高比" : "不是 iPhoneX 宽高比");
        }

        public static float GetAspectRatio()
        {
            var islanscape = Screen.width > Screen.height;

            return islanscape ? (float)Screen.width / Screen.height : (float)Screen.height / Screen.width;
        }

        public static bool IsPadResolution()
        {
            return InAspectRange(4.0f / 3);
        }

        public static bool IsiPhoneResolution()
        {
            return InAspectRange(16.0f / 9);
        }

        public static bool IsPhone15Resolution()
        {
            return InAspectRange(3.0f / 2);
        }

        public static bool IsPhoneXResolution()
        {
            return InAspectRange(2436.0f / 1125);
        }

        public static bool InAspectRange(float dstAspectRatio)
        {
            var aspect = GetAspectRatio();
            return aspect > (dstAspectRatio - 0.05f) && aspect < (dstAspectRatio + 0.05f);
        }
    }
}
