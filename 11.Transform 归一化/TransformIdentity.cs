// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             TransformIdentity.cs
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):          2019/10/19 17:04:35
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
    public class TransformIdentity
    {

#if UNITY_EDITOR
        [MenuItem("DSFramework/11.Transform 归一化")]
#endif
        private static void MenuClicked()
        {
            var transform = new GameObject("transform").transform;

            Identity(transform);
        }

        /// <summary>
        /// 重置操作
        /// </summary>
        /// <param name="transform">Trans.</param>
        public static void Identity(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localScale = Vector3.one;
            transform.localRotation = Quaternion.identity;
        }

    }
}
