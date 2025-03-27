using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using Khazan_DataEditor.DataControllers;
using KhazanData;

namespace Khazan_DataEditor.src
{
    public class Exporter
    {
        // public static Assembly s_protobufDB = Assembly.Load("GSE.ProtobufDB");
        // public static Assembly s_runtime = Assembly.Load("Protobuf.Runtime");

        /// <summary>
        /// 
        /// </summary>
        private static MD5 _md5 = MD5.Create();

        // public static bool GetIsValidFile(string fileName, string filePath)
        // {
        //     var protobufDBTypes = s_protobufDB.GetTypes();
        //     var runtimeTypes = s_runtime.GetTypes();
        //     // var tuple = GetTypeAssemblyTupleByFileName(fileName, protobufDBTypes, runtimeTypes);
        //
        //     // if (tuple.Item1 == null || tuple.Item2 == null)
        //     //     return false;
        //
        //     return true;
        // }

        public static object CreateInstance(string className)
        {
            // 获取当前执行的程序集
            Assembly assembly = Assembly.GetExecutingAssembly();
        
            // 查找类类型
            Type type = assembly.GetType(className);
            foreach (var typeInfo in assembly.DefinedTypes)
            {
                if (typeInfo.Name == className)
                {
                    type = typeInfo;
                    // Console.WriteLine(className);
                    break;
                }
            }
        
            if (type == null)
            {
                return null;
            }
        
            // 创建类的实例
            return Activator.CreateInstance(type);
        }
        
        public static KhazanTableBase GetDataByFile(string fileName, string filePath)
        {
            JArray? array = JsonConvert.DeserializeObject<JArray>(File.ReadAllText(filePath));
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            var className = fileNameWithoutExtension.Split('_')[0] + "DataTbl";
            var instance = CreateInstance(className);

            if (instance == null)
                return null;
            MethodInfo? method = instance.GetType().GetMethod("Initialize");

            method?.Invoke(instance, [array]);

            return instance as KhazanTableBase;
            
            // var protobufDBTypes = s_protobufDB.GetTypes();
            // var runtimeTypes = s_runtime.GetTypes();
            // var tuple = GetTypeAssemblyTupleByFileName(fileName, protobufDBTypes, runtimeTypes);
            //
            // if (tuple.Item1 == null || tuple.Item2 == null)
            //     return null;
            //
            // var bytes = File.ReadAllBytes(filePath);
            //
            // var realType = tuple.Item1;
            // Type tbType = null;
            //
            // try
            // {
            //     tbType = tuple.Item2.GetTypes().First(a => a.Name == "TB" + realType.Name);
            // }
            // catch (Exception ex)
            // {
            //
            // }
            // if (tbType != null)
            // {
            //     realType = tbType;
            // }
            //
            // var parser = realType.GetProperty("Parser", BindingFlags.Static | BindingFlags.Public);
            // if (parser != null)
            // {
            //     try
            //     {
            //         MessageParser parserValue = parser.GetMethod.Invoke(null, null) as MessageParser;
            //         var message = parserValue.ParseFrom(bytes);
            //         if (message != null)
            //         {
            //             return message;
            //         }
            //     }
            //     catch
            //     {
            //         Console.WriteLine("Data Failed File : " + filePath);
            //     }
            // }
            return null;
        }

        public static void Director(string dir, List<string> list, List<string> filePathList)
        {
            DirectoryInfo d = new DirectoryInfo(dir);
            if (!d.Exists)
                return;
            FileInfo[] files = d.GetFiles();//文件
            DirectoryInfo[] directs = d.GetDirectories();//文件夹
            foreach (FileInfo f in files)
            {
                if (f.Extension == ".json" && f.Name.Contains("_ue")
                    && !f.FullName.Contains("_Header") && !f.FullName.Contains("_Common") && !f.FullName.Contains("_Collection"))
                {
                    list.Add(f.Name);//添加文件名到列表中  
                    var indexOf = f.FullName.LastIndexOf("\\");
                    filePathList.Add(f.FullName);
                }
            }
            //获取子文件夹内的文件列表，递归遍历  
            foreach (DirectoryInfo dd in directs)
            {
                Director(dd.FullName, list, filePathList);
            }
        }

        public static void ExportDescriptionConfig(Dictionary<string, string> config, string path)
        {
            var json = JsonConvert.SerializeObject(config);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllText(path, json);
        }

        public static void ExportItemDataBytes(Dictionary<string, byte[]> itemData, string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            //write itemData to file with BinaryWriter
            using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.CreateNew)))
            {
                bw.Write(itemData.Count);
                foreach (var item in itemData)
                {
                    bw.Write(item.Key);
                    bw.Write(item.Value.Length);
                    bw.Write(item.Value);
                }
            }
        }

        public static Dictionary<string, byte[]> ImportItemDataBytes(string path)
        {
            Dictionary<string, byte[]> itemData = new Dictionary<string, byte[]>();

            //read itemData from file
            using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                var count = br.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    var key = br.ReadString();
                    var byteLength = br.ReadInt32();
                    var bytes = br.ReadBytes(byteLength);

                    itemData.Add(key, bytes);
                }
            }
            return itemData;
        }

        public static Dictionary<string, string> ImportDescriptionConfig(string path)
        {
            var dict = new Dictionary<string, string>();
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);

                dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }

            return dict;
        }

        public static void SaveDataFile(string path, DataFile dataFile)
        {
            if (dataFile == null) return;
            
            string dir = Path.GetDirectoryName(path);
            
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
            // using (FileStream output = File.Create(path))
            // {
            if (dataFile._FileData == null && dataFile.Tag is string)
            {
                dataFile.LoadData();
            }

            var jsonContent = JsonConvert.SerializeObject(dataFile._FileData.GetTable());
            // jsonContent.Replace("\"Table\":", "");
            File.WriteAllText(path, jsonContent);

            // dataFile._FileData.WriteTo(output);
            // }
        }

        public static async Task<List<(string, DataFile, DataItem)>> GlobalSearchCacheAsync(List<DataFile> fileList)
        {
            return await Task.Run(() =>
            {
                List<(string, DataFile, DataItem)> cache = new List<(string, DataFile, DataItem)>();

                foreach (DataFile file in fileList)
                {
                    file.LoadData();
                    if (file._FileDataItemList != null && file._FileDataItemList.Count > 0)
                    {
                        foreach (var data in file._FileDataItemList)
                        {
                            string cacheKey = $"{file._FileName}({file._Desc})-{data._ID}({data._Desc})";
                            cache.Add((cacheKey, file, data));
                            MainWindow.s_TraditionGlobalSearchCache.Add((cacheKey, file, data));

                            data.LoadData();

                            var propertyItems = data._DataPropertyItems;
                            foreach (var property in propertyItems)
                            {
                                if (property != null)
                                {
                                    var value = property._PropertyInfo.GetValue(property._BelongData, null);

                                    ProcessGlobalSearch(value, file, data, cache, property._PropertyName, property._PropertyDesc);
                                }
                            }
                        }
                    }
                }

                return cache;
            });
        }

        static void ProcessGlobalSearch(object value, DataFile file, DataItem data, List<(string, DataFile, DataItem)> cache, string propertyName, string propertyDesc = "")
        {
            if (value is string)
            {
                string key = $"{file._FileName}({file._Desc})-{data._ID}({data._Desc})-{propertyName}({propertyDesc})-{value}";

                cache.Add((key, file, data));
            }
            else if (IsNumber(value))
            {
                string key = $"{file._FileName}({file._Desc})-{data._ID}({data._Desc})-{propertyName}({propertyDesc})-{value}";

                cache.Add((key, file, data));
            }
            else if (value is Enum)
            {
                string key = $"{file._FileName}({file._Desc})-{data._ID}({data._Desc})-{propertyName}({propertyDesc})-{value.ToString()}";

                cache.Add((key, file, data));
            }
            else if (value is KhazanDataBase)
            {
                var type = value.GetType();

                //var ps = type.GetProperties();
                if (!PropertiesDataController.Instance.Get(type, out var ps))
                {
                    ps = PropertiesDataController.Instance.Add(type);
                }

                foreach (var p in ps)
                {
                    ProcessGlobalSearch(p.GetValue(value), file, data, cache, p.Name, "");
                }
            }
            else if (value != null && typeof(IList).IsAssignableFrom(value.GetType()))
            {
                var listValue = value as IList;
                int index = 0;
                foreach (var item in listValue)
                {
                    ProcessGlobalSearch(item, file, data, cache, $"{propertyName}{index}", "");
                    index++;
                }
            }
        }
        public static bool IsNumber(object value)
        {
            if (value == null) return false;

            TypeCode typeCode = Type.GetTypeCode(value.GetType());
            return typeCode == TypeCode.Int32 || typeCode == TypeCode.Int64 || typeCode == TypeCode.Single || typeCode == TypeCode.Double;
        }

        public static Dictionary<string, string> GenerateFirstDescConfig(List<DataFile> fileList)
        {
            Dictionary<string, string> descConfig = new Dictionary<string, string>();

            foreach (var file in fileList)
            {
                file.LoadData();
                if (file._FileDataItemList != null && file._FileDataItemList.Count > 0)
                {
                    foreach (var data in file._FileDataItemList)
                    {
                        var properties = data._Data.GetType().GetProperties();
                        foreach (var property in properties)
                        {
                            if (property.PropertyType == typeof(string))
                            {
                                var value = property.GetValue(data._Data, null) as string;
                                if (ContainsChineseUsingRegex(value))
                                {
                                    descConfig.TryAdd(file._FileData.GetType().Name + "_" + data._ID, value);
                                    break;
                                }
                                if (IsPathFormat(value))
                                {
                                    descConfig.TryAdd(file._FileData.GetType().Name + "_" + data._ID, GetFileName(value));
                                }
                            }
                            if (property.PropertyType == typeof(int))
                            {
                                var value = (int)property.GetValue(data._Data, null);
                                if (property.Name.Contains("ID", StringComparison.OrdinalIgnoreCase) && !property.Name.Equals("ID", StringComparison.OrdinalIgnoreCase))
                                {
                                    descConfig.TryAdd(file._FileData.GetType().Name + "_" + data._ID, value.ToString());
                                }
                            }
                        }
                    }
                }
            }
            return descConfig;
        }

        static bool ContainsChineseUsingRegex(string input)
        {
            // 使用正则表达式判断中文字符
            return Regex.IsMatch(input, @"[\u4e00-\u9fff]");
        }

        static bool IsPathFormat(string path)
        {
            // 正则表达式匹配路径格式
            string pattern = @"^[^/]*(/[^/ ]+)+/?$";
            return Regex.IsMatch(path, pattern);
        }

        static string GetFileName(string path)
        {
            // 提取最后一个斜杠后的部分作为文件名
            return path.Substring(path.LastIndexOf('.') + 1);
        }

        public static Dictionary<string, string> CollectItemMD5(List<DataFile> fileList)
        {
            Dictionary<string, string> md5Config = new Dictionary<string, string>();
        
            foreach (var file in fileList)
            {
                file.LoadData();
                if (file._FileDataItemList != null && file._FileDataItemList.Count > 0)
                {
                    foreach (var data in file._FileDataItemList)
                    {
                        var key = file._FileData.GetType().Name + "_" + data._ID;
                        var bytes = JsonConvert.SerializeObject(data._Data);
                        var md5 = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(bytes));
                        var md5Str = BitConverter.ToString(md5).Replace("-", "").ToLower();
                        md5Config.TryAdd(key, md5Str);
                    }
                }
            }
        
            return md5Config;
        }

        public static Dictionary<string, byte[]> CollectItemBytes(List<DataFile> fileList)
        {
            Dictionary<string, byte[]> itemData = new Dictionary<string, byte[]>();
        
            foreach (var file in fileList)
            {
                file.LoadData();
                if (file._FileDataItemList != null && file._FileDataItemList.Count > 0)
                {
                    foreach (var data in file._FileDataItemList)
                    {
                        var key = file._FileData.GetType().Name + "_" + data._ID;
                        var bytes = JsonConvert.SerializeObject(data._Data);
                        itemData.TryAdd(key, Encoding.UTF8.GetBytes(bytes));
                    }
                }
            }
        
            return itemData;
        }

        public static bool IsSameAsMd5(DataItem item, Dictionary<string, string> md5Config)
        {
            if (item == null || item._Data == null)
                return false;
            
            string key = item._File._FileData.GetType().Name + "_" + item._ID;
            
            if (md5Config.TryGetValue(key, out var md5))
            {
                var bytes = JsonConvert.SerializeObject(item._Data);
                var itemMd5 = _md5.ComputeHash(Encoding.UTF8.GetBytes(bytes));
                var md5Str = BitConverter.ToString(itemMd5).Replace("-", "").ToLower();
                bytes = null;
                return md5Str.Equals(md5);
            }

            return false;

        }
    }
}
