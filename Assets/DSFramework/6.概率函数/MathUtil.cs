// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             PercentFunction.cs
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):          2019/10/19 17:14:29
// 邮箱(Emial):					  1067163632@qq.com
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************
using UnityEngine;
using System;
using Random = UnityEngine.Random;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DSFramework
{

    public class MathUtil
    {

#if UNITY_EDITOR
        [MenuItem("DSFramework/6.概率函数",false,6)]
#endif
        private static void MenuClicked()
        {
            Debug.Log(Percent(50));
        }
        public static bool Percent(int percent)
        {
            return Random.Range(0, 100) < percent;
        }
    }
}
