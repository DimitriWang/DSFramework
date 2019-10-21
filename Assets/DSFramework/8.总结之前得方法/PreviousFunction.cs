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
    
    public class PreviousFunction : MonoBehaviour
    {
#if UNITY_EDITOR
        /// <summary>
        /// 获取文件名
        /// </summary>
        /// <returns></returns>
        public static string GeneratePackageName()
        {
            return "DSFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");

        }

        /// <summary>
        /// 复制文本到剪切板
        /// </summary>
        /// <param name="text"></param>
        public static void CopyText(string text)
        {
            GUIUtility.systemCopyBuffer = text;
        }

        /// <summary>
        /// 导出包
        /// </summary>
        /// <param name="assetPathName"></param>
        /// <param name="fileName"></param>
        public static void ExportPackage(string assetPathName, string fileName)
        {
            AssetDatabase.ExportPackage(assetPathName, fileName, ExportPackageOptions.Recurse);
        }

        /// <summary>
        /// 打开所在文件夹
        /// </summary>
        /// <param name="folderPath"></param>
        public static void OpenInFolder(string folderPath)
        {
            Application.OpenURL("file:///" + folderPath);
        }

        /// <summary>
        /// MenuItem复用
        /// </summary>
        /// <param name="itemName"></param>
        public static void CallMenuItem(string itemName)
        {
            EditorApplication.ExecuteMenuItem(itemName);
            Application.OpenURL("file:///" + Path.Combine(Application.dataPath, "../"));
        }

        [MenuItem("DSFramework/8.总结之前的方法/1.生成 UnityPackage 名字")]
        private static void MenuClicked()
        {
            Debug.Log(GeneratePackageName());
        }

        [MenuItem("DSFramework/8.总结之前的方法/2.复制文本到剪切板")]
        private static void MenuClicked2()
        {
            CopyText("要复制的文本");
        }

        [MenuItem("DSFramework/8.总结之前的方法/3.生成文件名到剪切板")]
        private static void MenuClicked3()
        {
            CopyText(GeneratePackageName());
        }

        [MenuItem("DSFramework/8.总结之前的方法/4.导出 UnityPackage")]
        private static void MenuClicked4()
        {
            ExportPackage("Assets/DSFramework", GeneratePackageName() + ".unitypackage");
        }

        [MenuItem("DSFramework/8.总结之前的方法/5.打开所在文件夹")]
        private static void MenuClicked5()
        {
            OpenInFolder(Application.dataPath);
        }

        [MenuItem("DSFramework/8.总结之前的方法/6.MenuItem复用")]
        private static void MenuClicked6()
        {
            ExportPackage("Assets/DSFramework", GeneratePackageName() + ".unitypackage");
            OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }

        [MenuItem("DSFramework/8.总结之前的方法/7.自定义快捷键")]
        private static void MenuClicked7()
        {
            Debug.Log("%e ctrl/cmd + e");
            //EditorApplication.ExecuteMenuItem("DSFramework/8.总结之前的方法/6.MenuItem复用");
        }

#endif
    }
}
