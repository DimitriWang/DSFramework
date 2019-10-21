// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             PartialKeyworld.cs
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):          2019/10/21 16:34:20
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
    public partial class TransformSimplify
    {
        public static void AddClild(Transform parentTrans,Transform childTrans)
        {
            childTrans.SetParent(parentTrans);
        }
    }

    public partial class GameObjectSimplify
    {
        public static void Show(Transform transform)
        {
            transform.gameObject.SetActive(true);
        }

        public static void Hide(Transform transform)
        {
            transform.gameObject.SetActive(false);
        }
    }

    public class PartialKeyworld
    {
#if UNITY_EDITOR
        [MenuItem("DSFramework/8.partial 关键字",false,8)]
#endif
        public static void MenuClicked()
        {
            var parentTrans = new GameObject("parentTrans").transform;
            var childTrans = new GameObject("childTrans").transform;
            
            TransformSimplify.AddClild(parentTrans, childTrans);
        }
    }
}
