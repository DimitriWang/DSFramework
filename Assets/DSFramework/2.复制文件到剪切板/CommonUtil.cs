// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             NewBehaviourScript.cs
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):          2019/10/21 16:03:32
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
    public class CommonUtil
    {
#if UNITY_EDITOR
        [MenuItem("DSFramework/2.复制文本到剪切板", false, 2)]
#endif
        private static void MenuClicked2()
        {
            CommonUtil.CopyText("要复制的文本");
        }

        //复制文本到剪切板
        public static void CopyText(string text)
        {
            GUIUtility.systemCopyBuffer = text;
        }
    }
}
