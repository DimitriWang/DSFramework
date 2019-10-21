// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):            	PreviousFunction.cs
// 作者(Author):                  	Dimitri Wang
// 创建时间(CreateTime):       		2019/10/14 14:51:45
// 邮箱(Emial):						1067163632@qq.com
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************
using UnityEngine;
using System;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DSFramework
{
    public class CommonUtil
    {
        //复制文本到剪切板
        public static void CopyText(string text)
        {
            GUIUtility.systemCopyBuffer = text;
        }
    }

    public class Exporter
    {
        //获取文件名
        public static string GeneratePackageName()
        {
            return "DSFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");
        }
    }

    public class EditorUtil
    {
#if UNITY_EDITOR

        //打开所在文件夹
        public static void OpenInFolder(string folderPath)
        {
            Application.OpenURL("file:///" + folderPath);
        }

        //MenuItem复用
        public static void CallMenuItem(string itemName)
        {
            EditorApplication.ExecuteMenuItem(itemName);
            Application.OpenURL("file:///" + Path.Combine(Application.dataPath, "../"));
        }

        //导出包
        public static void ExportPackage(string assetPathName, string fileName)
        {
            AssetDatabase.ExportPackage(assetPathName, fileName, ExportPackageOptions.Recurse);
        }
#endif
    }

    public class PreviousFunction : MonoBehaviour
    {
        [Obsolete("方法以过时,请使用 CommonUtil.CopyText(text);")]
        public static void CopyText(string text)
        {
            CommonUtil.CopyText(text);
        }
        [Obsolete("方法以过时,请使用 Exporter.GeneratePackageName();")]
        public static string GeneratePackageName()
        {
            
            return Exporter.GeneratePackageName();
        }
        [Obsolete("方法以过时,请使用 EditorUtil.OpenInFolder(folderPath);")]
        public static void OpenInFolder(string folderPath)
        {
            EditorUtil.OpenInFolder(folderPath);
        }
#if UNITY_EDITOR
        [Obsolete("方法以过时,请使用 EditorUtil.CallMenuItem(itemName);")]
        public static void CallMenuItem(string itemName)
        {
            EditorUtil.CallMenuItem(itemName);
        }
        [Obsolete("方法以过时,请使用 EditorUtil.ExportPackage(assetPathName,fileName);")]
        public static void ExportPackage(string assetPathName, string fileName)
        {
            EditorUtil.ExportPackage(assetPathName, fileName);
        }
#endif
#if UNITY_EDITOR
        [MenuItem("DSFramework/8.总结之前的方法/1.生成 UnityPackage 名字")]
        private static void MenuClicked()
        {
            Debug.Log(Exporter.GeneratePackageName());
        }
        [MenuItem("DSFramework/8.总结之前的方法/2.复制文本到剪切板")]
        private static void MenuClicked2()
        {
            CommonUtil.CopyText("要复制的文本");
        }
        [MenuItem("DSFramework/8.总结之前的方法/3.生成文件名到剪切板")]
        private static void MenuClicked3()
        {
            CommonUtil.CopyText(Exporter.GeneratePackageName());
        }
        [MenuItem("DSFramework/8.总结之前的方法/4.导出 UnityPackage")]
        private static void MenuClicked4()
        {
            EditorUtil.ExportPackage("Assets/DSFramework", Exporter.GeneratePackageName() + ".unitypackage");
        }
        [MenuItem("DSFramework/8.总结之前的方法/5.打开所在文件夹")]
        private static void MenuClicked5()
        {
            EditorUtil.OpenInFolder(Application.dataPath);
        }
        [MenuItem("DSFramework/8.总结之前的方法/6.MenuItem复用")]
        private static void MenuClicked6()
        {
            EditorUtil.ExportPackage("Assets/DSFramework", Exporter.GeneratePackageName() + ".unitypackage");
            EditorUtil.OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }
#endif
    }
}
