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
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DSFramework
{
    public class GameObjectActiveImprovements
    {
#if UNITY_EDITOR
        [MenuItem("DSFramework/13.GameObject 的显示隐藏简化")]
#endif
        private static void MenuClicked()
        {
            var gameobject = new GameObject();

            Hide(gameobject);
        }

        public static void Show(GameObject gameobj)
        {
            gameobj.SetActive(true);
        }

        public static void Hide(GameObject gameobj)
        {
            gameobj.SetActive(false);
        }
    }
}
