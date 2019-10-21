// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             GameObjectActiveImprovements.cs
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):          2019/10/19 17:23:17
// 邮箱(Emial):					  1067163632@qq.com
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DSFramework
{
    public partial class GameObjectSimplify
    {

        public static void Show(GameObject gameobj)
        {
            gameobj.SetActive(true);
        }
        public static void Hide(GameObject gameobj)
        {
            gameobj.SetActive(false);
        }
#if UNITY_EDITOR
        [MenuItem("DSFramework/7.GameObject 简化",false,7)]
#endif
        private static void MenuClicked()
        {
            var gameobject = new GameObject();
            Hide(gameobject);
        }
    }
}
