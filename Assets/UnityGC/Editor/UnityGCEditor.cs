﻿using UnityEngine;
using UnityEditor;

namespace GameCanvas
{
    namespace Editor
    {
        public class GameCanvasAssetProcessor : AssetPostprocessor
        {
            void OnPreprocessTexture()
            {
                // インポートした画像を、スクリプトから読み込み可能にします
                var importar = (TextureImporter)assetImporter;
                importar.textureType         = TextureImporterType.Advanced;
                importar.textureFormat       = TextureImporterFormat.AutomaticTruecolor;
                importar.filterMode          = FilterMode.Point;
                importar.spritePixelsPerUnit = 1f;
                importar.mipmapEnabled       = false;
            }

            void OnPreprocessAudio()
            {
                var audioImporter = (AudioImporter)assetImporter;
                var setting = audioImporter.defaultSampleSettings;
                setting.compressionFormat   = AudioCompressionFormat.ADPCM;
                setting.loadType            = AudioClipLoadType.Streaming;
                audioImporter.defaultSampleSettings = setting;
            }
        }
    }
}
