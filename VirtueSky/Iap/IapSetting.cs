﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Purchasing;
using VirtueSky.EditorUtils;

#if UNITY_EDITOR
using System.IO;
using UnityEditor;
#endif
using VirtueSky.Utils;


namespace VirtueSky.Iap
{
    [HideMonoScript]
    public class IapSetting : ScriptableObject
    {
        [SerializeField] private List<IapData> skusData = new List<IapData>();
        [ReadOnly] [SerializeField] private List<IapDataVariable> products = new List<IapDataVariable>();

#if UNITY_EDITOR
        [Space, SerializeField, TextArea] private string googlePlayStoreKey;
#endif
        public List<IapDataVariable> Products => products;


#if UNITY_EDITOR
        private string path = CreateAsset.DefaultResourcesPath("/Iap/Products");

        [Button("Generate Product From Sku")]
        public void GenerateProduct()
        {
            products.Clear();
            for (int i = 0; i < skusData.Count; i++)
            {
                string itemName = skusData[i].id.Split('.').Last();
                Debug.Log(itemName);
                AssetDatabase.DeleteAsset($"{path}/iap_{itemName.ToLower()}.asset");
                var itemDataVariable = CreateInstance<IapDataVariable>();
                itemDataVariable.id = skusData[i].id;
                itemDataVariable.productType = skusData[i].productType;
                products.Add(itemDataVariable);
                AssetDatabase.CreateAsset(itemDataVariable, $"{path}/iap_{itemName.ToLower()}.asset");
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }

        [Button("Obfuscator Key")]
        void ObfuscatorKey()
        {
            var googleError = "";
            var appleError = "";
            ObfuscationGenerator.ObfuscateSecrets(includeGoogle: true,
                appleError: ref googleError,
                googleError: ref appleError,
                googlePlayPublicKey: googlePlayStoreKey);
            string pathAsmdef = GetFile.GetPathInCurrentEnvironent($"VirtueSky/EditorUtils/TemplateAssembly/PurchasingGeneratedAsmdef.txt");
            string pathAsmdefMeta = GetFile.GetPathInCurrentEnvironent($"VirtueSky/EditorUtils/TemplateAssembly/PurchasingGeneratedAsmdefMeta.txt");
            var asmdef = (TextAsset)AssetDatabase.LoadAssetAtPath(pathAsmdef, typeof(TextAsset));
            var meta = (TextAsset)AssetDatabase.LoadAssetAtPath(pathAsmdefMeta, typeof(TextAsset));
            string path = Path.Combine(TangleFileConsts.k_OutputPath, "virtuesky.purchasing.generate.asmdef");
            string pathMeta = Path.Combine(TangleFileConsts.k_OutputPath, "virtuesky.purchasing.generate.asmdef.meta");
            if (!File.Exists(path))
            {
                var writer = new StreamWriter(path, false);
                writer.Write(asmdef.text);
                writer.Close();
            }

            if (!File.Exists(pathMeta))
            {
                var writer = new StreamWriter(pathMeta, false);
                writer.Write(meta.text);
                writer.Close();
            }

            AssetDatabase.ImportAsset(path);
        }

#endif
    }

    [Serializable]
    public class IapData
    {
        public string id;
        public ProductType productType;
    }
}