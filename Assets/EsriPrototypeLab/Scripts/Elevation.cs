﻿/*
    Copyright 2016 Esri

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.

    You may obtain a copy of the License at
    http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Esri.PrototypeLab.HoloLens.Unity {
    public static class Elevation {
        private const string TERRAIN = "http://elevation3d.arcgis.com/arcgis/rest/services/WorldElevation3D/Terrain3D/ImageServer";
        public static IEnumerator GetHeights(Tile tile, Action<ElevationData> callback) {
            string url = string.Format("{0}/tile/{1}/{2}/{3}", new object[] {
                TERRAIN,
                tile.Zoom,
                tile.Y,
                tile.X
            });

            UnityWebRequest www = UnityWebRequest.Get(url);
            //WWW www = new WWW(url);
            //yield return www;
            yield return www.SendWebRequest();

           byte[] bytes = www.downloadHandler.data;

            uint[] info = new uint[7];
            double[] data = new double[3];

            uint hr = LercDecoder.lerc_getBlobInfo(bytes, (uint)bytes.Length, info, data, info.Length, data.Length);
            if (hr > 0) {
                Debug.Log(string.Format("function lerc_getBlobInfo() failed with error code {0}.", hr));
                yield break;
            }
            yield return null;

            int version = (int)info[0]; // version
            int type = (int)info[1];    // data type
            int cols = (int)info[2];    // nCols
            int rows = (int)info[3];    // nRows
            int bands = (int)info[4];   // nBands
            int valid = (int)info[5];   // num valid pixels
            int size = (int)info[6];    // blob size


            byte[] processed = new byte[cols * rows];
            uint values = (uint)(cols * rows * bands);

            float[] heights = new float[values];
            uint hr2 = LercDecoder.lerc_decode(bytes, (uint)bytes.Length, processed, cols, rows, bands, type, heights);
            
            yield return null;

            float? min = null;
            float? max = null;
            foreach (var v in heights) {
                min = (min.HasValue) ? Math.Min(min.Value, v) : v;
                max = (max.HasValue) ? Math.Max(max.Value, v) : v;
            }

            callback(new ElevationData() {
                Columns = cols,
                Rows = rows,
                Min = min.Value,
                Max = max.Value,
                Heights = heights
            });
        }
    }
}
