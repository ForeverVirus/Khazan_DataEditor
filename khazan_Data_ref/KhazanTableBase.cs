using System.Reflection;
using System.Runtime.CompilerServices;
using UAssetAPI;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;
using UAssetAPI.UnrealTypes;

namespace KhazanData;

public class KhazanTableBase
{
    public virtual void Initialize(UAsset uasset)
    {
        
    }

    public void ProcessUAssetTable<T>(List<StructPropertyData> list, ref List<T> table) where T : KhazanDataBase, new()
    {
        table = new List<T>();
        foreach (var item in list)
        {
            var data = new T();
            var properties = data.GetType().GetProperties();
            foreach (var propData in item.Value)
            {
                foreach (var property in properties)
                {
                    if (property.Name == propData.Name.ToString())
                    {
                        ProcessProperty(propData, property, data);
                        data.GetType().GetProperty(property.Name + "_Property")?.SetValue(data, propData);
                        break;
                    }
                }
            }
            table.Add(data);
        }
    }

    void ProcessProperty(PropertyData propData, PropertyInfo property, object data)
    {
        var rawType = propData.RawValue?.GetType();
        if (property.PropertyType != rawType)
        {
            if (propData.RawValue is FString str)
            {
                property.SetValue(data, str.Value);
            }
            else if (propData.PropertyType.ToString() == "EnumProperty" && propData.RawValue is FName fname)
            {
                var enumStr = fname.ToString();
                var split = enumStr.Split("::");
                var enumType = split[0];
                var enumValue = split[1];
                var realEnum = Enum.Parse(Type.GetType($"KhazanData.{enumType}"), enumValue);
                property.SetValue(data, realEnum);
            }
            else if (propData.RawValue is PropertyData[] propertyArray)
            {
                if (propertyArray != null && propertyArray.Length > 0)
                {
                    var elementType = property.PropertyType.GetElementType();
                    var array = Array.CreateInstance(elementType, propertyArray.Length);
                    for (int i = 0; i < propertyArray.Length; i++)
                    {
                        if (propertyArray[i].RawValue is FString arrayStr)
                        {
                            array.SetValue(arrayStr.Value, i);
                            // property.SetValue(data, str.Value);
                        }
                        else if (propertyArray[i].PropertyType.ToString() == "EnumProperty" && propertyArray[i].RawValue is FName arrayFname)
                        {
                            var enumStr = arrayFname.ToString();
                            var split = enumStr.Split("::");
                            var enumType = split[0];
                            var enumValue = split[1];
                            var realEnum = Enum.Parse(Type.GetType($"KhazanData.{enumType}"), enumValue);
                            // property.SetValue(data, realEnum);
                            array.SetValue(realEnum, i);
                        }
                        else if (propertyArray[i].PropertyType.ToString() == "StructProperty")
                        {
                            var list = propertyArray[i].RawValue as List<PropertyData>;
                            var arrayItem = Activator.CreateInstance(elementType);
                            // ProcessProperty()
                            var properties = elementType.GetProperties();
                            foreach (var pArrayItem in list)
                            {
                                foreach (var p in properties)
                                {
                                    if (p.Name == pArrayItem.Name.ToString())
                                    {
                                        ProcessProperty(pArrayItem, p, arrayItem);
                                        arrayItem.GetType().GetProperty(p.Name + "_Property")?.SetValue(arrayItem, pArrayItem);
                                        break;
                                    }
                                }
                            }
                            array.SetValue(arrayItem, i);
                        }
                        else
                        {
                            if (elementType == typeof(int) && propertyArray[i].RawValue is long longValue)
                            {
                                array.SetValue((int)longValue, i);
                            }
                            else
                            {
                                array.SetValue(propertyArray[i].RawValue, i);
                            }
                            
                        }
                    }
                    property.SetValue(data, array);
                }
            }
            else if (propData.PropertyType.ToString() == "StructProperty")
            {
                var list = propData.RawValue as List<PropertyData>;
                var arrayItem = Activator.CreateInstance(property.PropertyType);
                // ProcessProperty()
                var properties = property.PropertyType.GetProperties();
                foreach (var pArrayItem in list)
                {
                    foreach (var p in properties)
                    {
                        if (p.Name == pArrayItem.Name.ToString())
                        {
                            ProcessProperty(pArrayItem, p, arrayItem);
                            arrayItem.GetType().GetProperty(p.Name + "_Property")?.SetValue(arrayItem, pArrayItem);
                            break;
                        }
                    }
                }
                property.SetValue(data, arrayItem);
            }
            else if (property.PropertyType == typeof(int) && propData.RawValue is long rawValue)
            {
                property.SetValue(data, (int)rawValue);
            }
        }
        else
        {
            property.SetValue(data, propData.RawValue);
        }
    }
    
    public virtual List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>();
    }
}