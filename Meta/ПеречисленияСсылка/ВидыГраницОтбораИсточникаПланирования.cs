﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Упр)
	///</summary>
	[DataContract]
	public enum ВидыГраницОтбораИсточникаПланирования
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"350bb7e7-f407-4d66-8984-6903578cdc4d\", \"Представление\":\"НачалоПериода\"}")]
		НачалоПериода = 0,//Начало периода
		[EnumMember(Value = "{\"Ссылка\":\"35e61233-4609-4f85-a054-a7ddae09e002\", \"Представление\":\"КонецПериода\"}")]
		КонецПериода = 1,//Конец периода
		[EnumMember(Value = "{\"Ссылка\":\"cb65b24c-b2ca-4683-ab4d-056665fdf3f2\", \"Представление\":\"ФиксированнаяДата\"}")]
		ФиксированнаяДата = 2,//Фиксированная дата
	}
	public static partial class ВидыГраницОтбораИсточникаПланирования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НачалоПериода = new Guid("03698489-8c57-4ddc-4d66-f407350bb7e7");//Начало периода
		public static readonly Guid КонецПериода = new Guid("dda754a0-09ae-02e0-4f85-460935e61233");//Конец периода
		public static readonly Guid ФиксированнаяДата = new Guid("66054dab-fd65-f2f3-4683-b2cacb65b24c");//Фиксированная дата
		public static ВидыГраницОтбораИсточникаПланирования Получить(this ВидыГраницОтбораИсточникаПланирования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыГраницОтбораИсточникаПланирования Получить(this ВидыГраницОтбораИсточникаПланирования Значение, Guid Ссылка)
		{
			if(Ссылка == НачалоПериода)
			{
				return ВидыГраницОтбораИсточникаПланирования.НачалоПериода;
			}
			else if(Ссылка == КонецПериода)
			{
				return ВидыГраницОтбораИсточникаПланирования.КонецПериода;
			}
			else if(Ссылка == ФиксированнаяДата)
			{
				return ВидыГраницОтбораИсточникаПланирования.ФиксированнаяДата;
			}
			return ВидыГраницОтбораИсточникаПланирования.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыГраницОтбораИсточникаПланирования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыГраницОтбораИсточникаПланирования Значение)
		{
			switch (Значение)
			{
				case ВидыГраницОтбораИсточникаПланирования.НачалоПериода: return НачалоПериода;
				case ВидыГраницОтбораИсточникаПланирования.КонецПериода: return КонецПериода;
				case ВидыГраницОтбораИсточникаПланирования.ФиксированнаяДата: return ФиксированнаяДата;
			}
			return Guid.Empty;
		}
	}
}